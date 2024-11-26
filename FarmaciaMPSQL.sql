--[Base de Datos]
CREATE DATABASE FarmaciasMP

USE FarmaciasMP

--[Propietarios]
CREATE TABLE ownerTable
(
    ownerId INT PRIMARY KEY IDENTITY(1,1), -- Identificador �nico del propietario
    ownerName NVARCHAR(50) NOT NULL,       -- Nombre del propietario
	ownerLastName NVARCHAR(50) NOT NULL,   -- Apellido del propietario
	ownerGender CHAR(1) NOT NULL,          -- Genero
	ownerPhoneNumber NVARCHAR(20),         -- Numero telefonico
    ownerGmail NVARCHAR(128)               -- Informaci�n de contacto (Correo electronico)
);

--[Ubicacion]
CREATE TABLE locationTable
(
    locationId INT PRIMARY KEY IDENTITY(1,1), -- Identificador �nico de la ubicaci�n
    locationAddress NVARCHAR(75),             -- Direcci�n
    locationCity NVARCHAR(50),                -- Ciudad
    locationState NVARCHAR(50)                -- Estado
);

--[Farmacia]
CREATE TABLE pharmacyTable
(
    pharmacyId INT PRIMARY KEY IDENTITY(1,1), -- Identificador �nico de la farmacia
    pharmacyName NVARCHAR(50) NOT NULL,      -- Nombre de la farmacia
    ownerId INT NOT NULL,                     -- Relaci�n con el propietario
    locationId INT NOT NULL,                  -- Relaci�n con la ubicaci�n
    FOREIGN KEY (ownerId) REFERENCES ownerTable(ownerId),
    FOREIGN KEY (locationId) REFERENCES locationTable(locationId)
);

--[Medicamento]
CREATE TABLE medicineTable
(
    medicineId INT PRIMARY KEY IDENTITY(1,1), -- Identificador �nico del medicamento
    medicineName NVARCHAR(50) NOT NULL,      -- Nombre del medicamento
);

--[Inventario]
CREATE TABLE inventoryTable
(
    pharmacyId INT NOT NULL,                  -- Relaci�n con la farmacia
    medicineId INT NOT NULL,                  -- Relaci�n con el medicamento
    stock INT NOT NULL,                       -- Cantidad en inventario
    FOREIGN KEY (pharmacyId) REFERENCES pharmacyTable(pharmacyId),
    FOREIGN KEY (medicineId) REFERENCES medicineTable(medicineId),
    PRIMARY KEY (pharmacyId, medicineId)      -- Llave primaria compuesta
);

SELECT * FROM ownerTable
SELECT * FROM pharmacyTable
SELECT * FROM locationTable
SELECT * FROM medicineTable
SELECT * FROM inventoryTable

DELETE FROM ownerTable
DBCC CHECKIDENT ('ownerTable', RESEED, 0);

--[PRUEBA DE PROPIETARIOS]
INSERT INTO ownerTable (ownerName, ownerLastName, ownerGender, ownerPhoneNumber, ownerGmail)
VALUES
('John', 'Doe', 'M', '1234567890', 'john.doe@gmail.com'),
('Jane', 'Smith', 'F', '9876543210', 'jane.smith@gmail.com'),
('Carlos', 'Mart�nez', 'M', '5552345678', 'carlos.martinez@gmail.com'),
('Laura', 'Gonz�lez', 'F', '4447651234', 'laura.gonzalez@gmail.com'),
('Ahmed', 'Khan', 'M', '1112223333', 'ahmed.khan@gmail.com'),
('Emily', 'Clark', 'F', '3334445555', 'emily.clark@gmail.com'),
('Miguel', 'Torres', 'M', '2223334444', 'miguel.torres@gmail.com'),
('Sofia', 'Lopez', 'F', '6667778888', 'sofia.lopez@gmail.com'),
('David', 'Brown', 'M', '9998887777', 'david.brown@gmail.com'),
('Lucia', 'Hern�ndez', 'F', '8887776666', 'lucia.hernandez@gmail.com');

--[PRUEBA DE UBICACIONES]
INSERT INTO locationTable (locationAddress, locationCity, locationState)
VALUES
('Calle Reforma #123', 'Ciudad de M�xico', 'Ciudad de M�xico'),
('Av. Universidad #456', 'Guadalajara', 'Jalisco'),
('Calle Hidalgo #789', 'Monterrey', 'Nuevo Le�n'),
('Boulevard D�az Ordaz #321', 'Tijuana', 'Baja California'),
('Calle Morelos #654', 'Canc�n', 'Quintana Roo'),
('Av. Ju�rez #111', 'Puebla', 'Puebla'),
('Calle Independencia #222', 'M�rida', 'Yucat�n'),
('Boulevard Benito Ju�rez #333', 'Chihuahua', 'Chihuahua'),
('Calle Zaragoza #444', 'Toluca', 'Estado de M�xico'),
('Av. L�pez Mateos #555', 'Aguascalientes', 'Aguascalientes'),
('Calle Insurgentes #666', 'Quer�taro', 'Quer�taro'),
('Av. Col�n #777', 'Veracruz', 'Veracruz'),
('Calle Victoria #888', 'Villahermosa', 'Tabasco'),
('Boulevard Hidalgo #999', 'San Luis Potos�', 'San Luis Potos�'),
('Calle Matamoros #121', 'Saltillo', 'Coahuila'),
('Av. Constituci�n #343', 'Tepic', 'Nayarit'),
('Calle Morelos #565', 'Tuxtla Guti�rrez', 'Chiapas'),
('Boulevard Reforma #787', 'Culiac�n', 'Sinaloa'),
('Calle Ju�rez #909', 'Zacatecas', 'Zacatecas'),
('Av. Independencia #141', 'La Paz', 'Baja California Sur');


-- CREAR VISTA DESDE LA TABLA PROPIETARIOS
CREATE VIEW vw_ownerDetails AS
SELECT 
    ownerId AS ID,
    CONCAT(ownerName, ' ', ownerLastName) AS FullName,
    ownerGender AS Gender,
    ownerPhoneNumber AS Phone,
    ownerGmail AS Email
FROM ownerTable;

SELECT * FROM vw_ownerDetails;


--CREAR VISTA DESDE LA TABLA PARA VER LA UBICACIONES DE LAS FARMACIAS
CREATE VIEW vw_localizacionFarmacias AS
SELECT 
    locationId AS ID,
    CONCAT(locationAddress, ', ', locationCity, ', ', locationState) AS FullAddress
FROM locationTable;


SELECT * FROM vw_localizacionFarmacias;

--VISTA EN LA QUE SE PUEDE VER LA DIRECCION DE LOS PROPIETARIOS
CREATE VIEW propietarios_direcciones AS
SELECT 
    p.pharmacyId AS PharmacyID,
    p.pharmacyName AS PharmacyName,
    CONCAT(o.ownerName, ' ', o.ownerLastName) AS OwnerName,
    CONCAT(l.locationAddress, ', ', l.locationCity, ', ', l.locationState) AS Location
FROM pharmacyTable p
INNER JOIN ownerTable o ON p.ownerId = o.ownerId
INNER JOIN locationTable l ON p.locationId = l.locationId;

SELECT * FROM propietarios_direcciones

--INVENTARIO DE MEDICAMENTO EN FARMACIAS
CREATE VIEW inventario_farmacias AS
SELECT 
    p.pharmacyName AS Pharmacy,
    m.medicineName AS Medicine,
    i.stock AS Stock
FROM inventoryTable i
INNER JOIN pharmacyTable p ON i.pharmacyId = p.pharmacyId
INNER JOIN medicineTable m ON i.medicineId = m.medicineId;

SELECT * FROM inventario_farmacias;

--vista global de farmacias para todos lo datos en base de datoS
--CONSULTA USANDO INNER JOIN RELACIONANDO LA TABLA DE PROPIETARIO, LOCALIZACION, INVENTARIO DE MEDICAMENTOS
CREATE VIEW Pharmacy_infoData AS
SELECT 
    p.pharmacyName AS Pharmacy,
    CONCAT(o.ownerName, ' ', o.ownerLastName) AS Owner,
    CONCAT(l.locationAddress, ', ', l.locationCity, ', ', l.locationState) AS Location,
    m.medicineName AS Medicine,
    i.stock AS Stock
FROM pharmacyTable p
INNER JOIN ownerTable o ON p.ownerId = o.ownerId
INNER JOIN locationTable l ON p.locationId = l.locationId
INNER JOIN inventoryTable i ON p.pharmacyId = i.pharmacyId
INNER JOIN medicineTable m ON i.medicineId = m.medicineId;

SELECT * FROM Pharmacy_infoData;

-- M�todo para consultar ownerTable en orden ascendente y descendente
CREATE PROCEDURE GetOwnerTableData(@orderDirection NVARCHAR(4))
AS
BEGIN
    IF @orderDirection = 'ASC'
        SELECT * FROM ownerTable ORDER BY ownerId ASC;
    ELSE IF @orderDirection = 'DESC'
        SELECT * FROM ownerTable ORDER BY ownerId DESC;
    ELSE
        PRINT 'Por favor, use "ASC" o "DESC" como argumento.';
END;

-- M�todo para consultar locationTable en orden ascendente y descendente
CREATE PROCEDURE GetLocationTableData(@orderDirection NVARCHAR(4))
AS
BEGIN
    IF @orderDirection = 'ASC'
        SELECT * FROM locationTable ORDER BY locationId ASC;
    ELSE IF @orderDirection = 'DESC'
        SELECT * FROM locationTable ORDER BY locationId DESC;
    ELSE
        PRINT 'Por favor, use "ASC" o "DESC" como argumento.';
END;

-- M�todo para consultar pharmacyTable en orden ascendente y descendente
CREATE PROCEDURE GetPharmacyTableData(@orderDirection NVARCHAR(4))
AS
BEGIN
    IF @orderDirection = 'ASC'
        SELECT * FROM pharmacyTable ORDER BY pharmacyId ASC;
    ELSE IF @orderDirection = 'DESC'
        SELECT * FROM pharmacyTable ORDER BY pharmacyId DESC;
    ELSE
        PRINT 'Por favor, use "ASC" o "DESC" como argumento.';
END;

-- M�todo para consultar medicineTable en orden ascendente y descendente
CREATE PROCEDURE GetMedicineTableData(@orderDirection NVARCHAR(4))
AS
BEGIN
    IF @orderDirection = 'ASC'
        SELECT * FROM medicineTable ORDER BY medicineId ASC;
    ELSE IF @orderDirection = 'DESC'
        SELECT * FROM medicineTable ORDER BY medicineId DESC;
    ELSE
        PRINT 'Por favor, use "ASC" o "DESC" como argumento.';
END;

-- M�todo para consultar inventoryTable en orden ascendente y descendente
CREATE PROCEDURE GetInventoryTableData(@orderDirection NVARCHAR(4))
AS
BEGIN
    IF @orderDirection = 'ASC'
        SELECT * FROM inventoryTable ORDER BY pharmacyId ASC, medicineId ASC;
    ELSE IF @orderDirection = 'DESC'
        SELECT * FROM inventoryTable ORDER BY pharmacyId DESC, medicineId DESC;
    ELSE
        PRINT 'Por favor, use "ASC" o "DESC" como argumento.';
END;

-- Consultar ownerTable en orden ascendente
EXEC GetOwnerTableData 'ASC';

-- Consultar ownerTable en orden descendente
EXEC GetOwnerTableData 'DESC';

-- Consultar locationTable en orden ascendente
EXEC GetLocationTableData 'ASC';

-- Consultar locationTable en orden descendente
EXEC GetLocationTableData 'DESC';

-- Consultar pharmacyTable en orden ascendente
EXEC GetPharmacyTableData 'ASC';

-- Consultar pharmacyTable en orden descendente
EXEC GetPharmacyTableData 'DESC';

-- Consultar medicineTable en orden ascendente
EXEC GetMedicineTableData 'ASC';

-- Consultar medicineTable en orden descendente
EXEC GetMedicineTableData 'DESC';

-- Consultar inventoryTable en orden ascendente
EXEC GetInventoryTableData 'ASC';

-- Consultar inventoryTable en orden descendente
EXEC GetInventoryTableData 'DESC';
