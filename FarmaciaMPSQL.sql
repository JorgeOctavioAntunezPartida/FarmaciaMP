--[Base de Datos]
CREATE DATABASE FarmaciasMP

USE FarmaciasMP
GO
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

DELETE FROM 
DBCC CHECKIDENT ('ownerTable', RESEED, 0);

-- [Propietarios]
INSERT INTO ownerTable (ownerName, ownerLastName, ownerGender, ownerPhoneNumber, ownerGmail)
VALUES
('Carlos', 'G�mez', 'M', '1234567890', 'carlos.gomez@gmail.com'),
('Ana', 'Mart�nez', 'F', '1234567891', 'ana.martinez@gmail.com'),
('Luis', 'Fern�ndez', 'M', '1234567892', 'luis.fernandez@gmail.com'),
('Mar�a', 'L�pez', 'F', '1234567893', 'maria.lopez@gmail.com'),
('Jos�', 'P�rez', 'M', '1234567894', 'jose.perez@gmail.com'),
('Laura', 'Ram�rez', 'F', '1234567895', 'laura.ramirez@gmail.com'),
('Javier', 'Torres', 'M', '1234567896', 'javier.torres@gmail.com'),
('Marta', 'S�nchez', 'F', '1234567897', 'marta.sanchez@gmail.com'),
('Andr�s', 'Castro', 'M', '1234567898', 'andres.castro@gmail.com'),
('Luc�a', 'Vega', 'F', '1234567899', 'lucia.vega@gmail.com'),
('Miguel', 'Ortega', 'M', '1234567800', 'miguel.ortega@gmail.com'),
('Sof�a', 'Morales', 'F', '1234567801', 'sofia.morales@gmail.com'),
('Juan', 'N��ez', 'M', '1234567802', 'juan.nunez@gmail.com'),
('Isabel', 'Herrera', 'F', '1234567803', 'isabel.herrera@gmail.com'),
('Pedro', 'Flores', 'M', '1234567804', 'pedro.flores@gmail.com'),
('Elena', 'Rivas', 'F', '1234567805', 'elena.rivas@gmail.com'),
('H�ctor', 'Ruiz', 'M', '1234567806', 'hector.ruiz@gmail.com'),
('Clara', 'Cruz', 'F', '1234567807', 'clara.cruz@gmail.com'),
('Roberto', 'Navarro', 'M', '1234567808', 'roberto.navarro@gmail.com'),
('Gabriela', 'Castillo', 'F', '1234567809', 'gabriela.castillo@gmail.com');

-- [Ubicaciones]
INSERT INTO locationTable (locationAddress, locationCity, locationState)
VALUES
('Av. Reforma 123', 'Ciudad de M�xico', 'CDMX'),
('Calle 10 #45', 'Guadalajara', 'Jalisco'),
('Col. Centro #567', 'Monterrey', 'Nuevo Le�n'),
('Paseo de las Flores 21', 'Puebla', 'Puebla'),
('Av. Sol 90', 'Canc�n', 'Quintana Roo'),
('Av. Insurgentes 450', 'Quer�taro', 'Quer�taro'),
('Calle Luna #11', 'Tijuana', 'Baja California'),
('Plaza Mayor #32', 'Le�n', 'Guanajuato'),
('Zona R�o #88', 'Mexicali', 'Baja California'),
('Calle Oro 15', 'Culiac�n', 'Sinaloa'),
('Paseo del Valle 98', 'M�rida', 'Yucat�n'),
('Col. Roma Norte #45', 'Ciudad de M�xico', 'CDMX'),
('Calle Sur 13', 'Toluca', 'Estado de M�xico'),
('Av. Hidalgo 32', 'Tepic', 'Nayarit'),
('Boulevard San �ngel 200', 'Chihuahua', 'Chihuahua'),
('Col. San Pedro #89', 'Saltillo', 'Coahuila'),
('Calle Norte 44', 'Villahermosa', 'Tabasco'),
('Paseo del Norte #77', 'Zacatecas', 'Zacatecas'),
('Calle Diamante 12', 'Morelia', 'Michoac�n'),
('Av. Principal 101', 'Oaxaca', 'Oaxaca');

-- [Medicamentos]
INSERT INTO medicineTable (medicineName)
VALUES
('Paracetamol'),
('Ibuprofeno'),
('Amoxicilina'),
('Loratadina'),
('Omeprazol'),
('Metformina'),
('Atorvastatina'),
('Losart�n'),
('Salbutamol'),
('Aspirina'),
('Ranitidina'),
('Cefalexina'),
('Clonazepam'),
('Azitromicina'),
('Diclofenaco'),
('Enalapril'),
('Furosemida'),
('Ketorolaco'),
('Metronidazol'),
('Prednisona'),
('Ciprofloxacino'),
('Simvastatina'),
('Dexametasona'),
('Fluconazol'),
('Propranolol'),
('Acetaminof�n'),
('Naproxeno'),
('Tramadol'),
('Cetirizina'),
('Claritromicina'),
('Hidroxicloroquina'),
('Valproato'),
('Glimepirida'),
('Levotiroxina'),
('Sertralina'),
('Lorazepam'),
('Tamsulosina'),
('Amlodipino'),
('Esomeprazol'),
('Montelukast'),
('Doxiciclina'),
('Gabapentina'),
('Alprazolam'),
('Rosuvastatina'),
('Venlafaxina'),
('Pregabalina'),
('Lamotrigina'),
('Sitagliptina'),
('Zolpidem'),
('Carbamazepina');

SELECT * FROM ownerTable
SELECT * FROM locationTable
SELECT * FROM medicineTable

-- CREAR VISTA DESDE LA TABLA PROPIETARIOS
CREATE VIEW Detalles_Propietarios AS
SELECT 
    ownerId AS ID,
    CONCAT(ownerName, ' ', ownerLastName) AS FullName,
    ownerGender AS Gender,
    ownerPhoneNumber AS Phone,
    ownerGmail AS Email
FROM ownerTable;

SELECT * FROM Detalles_Propietarios;


--CREAR VISTA DESDE LA TABLA PARA VER LA UBICACIONES DE LAS FARMACIAS
CREATE VIEW Local_Farmacias AS
SELECT 
    locationId AS ID,
    CONCAT(locationAddress, ', ', locationCity, ', ', locationState) AS FullAddress
FROM locationTable;


SELECT * FROM LocalizacionFarmacias;

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
CREATE PROCEDURE Propietarios_Tabla(@orderDirection NVARCHAR(4))
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
CREATE PROCEDURE Localizacion_Farmacias(@orderDirection NVARCHAR(4))
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
CREATE PROCEDURE Farmacias(@orderDirection NVARCHAR(4))
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
CREATE PROCEDURE Medicamentos(@orderDirection NVARCHAR(4))
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
CREATE PROCEDURE Inventario(@orderDirection NVARCHAR(4))
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
EXEC Propietarios_Tabla 'ASC';

-- Consultar ownerTable en orden descendente
EXEC Propietarios_Tabla'DESC';

-- Consultar locationTable en orden ascendente
EXEC Localizacion_Farmacias'ASC';

-- Consultar locationTable en orden descendente
EXEC Localizacion_Farmacias'DESC';

-- Consultar pharmacyTable en orden ascendente
EXEC Farmacias 'ASC';

-- Consultar pharmacyTable en orden descendente
EXEC Farmacias 'DESC';

-- Consultar medicineTable en orden ascendente
EXEC Medicamentos 'ASC';

-- Consultar medicineTable en orden descendente
EXEC Medicamentos 'DESC';

-- Consultar inventoryTable en orden ascendente
EXEC Inventario 'ASC';

-- Consultar inventoryTable en orden descendente
EXEC Inventario'DESC';
