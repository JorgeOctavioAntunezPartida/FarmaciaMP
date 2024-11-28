--[Base de Datos]
CREATE DATABASE FarmaciasMP

USE FarmaciasMP
GO

--[TABLAS]====================================================================================
--[Propietarios]
CREATE TABLE ownerTable
(
    ownerId INT PRIMARY KEY IDENTITY(1,1), -- Identificador único del propietario
    ownerName NVARCHAR(50) NOT NULL,       -- Nombre del propietario
	ownerLastName NVARCHAR(50) NOT NULL,   -- Apellido del propietario
	ownerGender CHAR(1) NOT NULL,          -- Genero
	ownerPhoneNumber NVARCHAR(20),         -- Numero telefonico
    ownerGmail NVARCHAR(128)               -- Información de contacto (Correo electronico)
);

--[Ubicacion]
CREATE TABLE locationTable
(
    locationId INT PRIMARY KEY IDENTITY(1,1), -- Identificador único de la ubicación
    locationAddress NVARCHAR(75),             -- Dirección
    locationCity NVARCHAR(50),                -- Ciudad
    locationState NVARCHAR(50)                -- Estado
);

--[Farmacia]
CREATE TABLE pharmacyTable
(
    pharmacyId INT PRIMARY KEY IDENTITY(1,1), -- Identificador único de la farmacia
    pharmacyName NVARCHAR(50) NOT NULL,      -- Nombre de la farmacia
    ownerId INT NOT NULL,                     -- Relación con el propietario
    locationId INT NOT NULL,                  -- Relación con la ubicación
    FOREIGN KEY (ownerId) REFERENCES ownerTable(ownerId) ON DELETE CASCADE,
    FOREIGN KEY (locationId) REFERENCES locationTable(locationId) ON DELETE CASCADE
);

--[Medicamento]
CREATE TABLE medicineTable
(
    medicineId INT PRIMARY KEY IDENTITY(1,1), -- Identificador único del medicamento
    medicineName NVARCHAR(50) NOT NULL,      -- Nombre del medicamento
);

--[Inventario]
CREATE TABLE inventoryTable
(
    inventoryId INT PRIMARY KEY IDENTITY(1,1), -- Nueva columna como clave primaria
    pharmacyId INT NOT NULL,                   -- Relación con la farmacia
    medicineId INT NULL,                       -- Relación con el medicamento, permite NULL
    stock INT NOT NULL,                        -- Cantidad en inventario
    FOREIGN KEY (pharmacyId) REFERENCES pharmacyTable(pharmacyId) ON DELETE CASCADE,
    FOREIGN KEY (medicineId) REFERENCES medicineTable(medicineId) ON DELETE SET NULL,
    UNIQUE (pharmacyId, medicineId)            -- Restricción de unicidad
);

--[TEST REGISTROS]==========================================================================
SELECT * FROM ownerTable
SELECT * FROM pharmacyTable
SELECT * FROM locationTable
SELECT * FROM medicineTable
SELECT * FROM inventoryTable

DELETE FROM inventoryTable

DBCC CHECKIDENT ('ownerTable', RESEED, 0);
DBCC CHECKIDENT ('locationTable', RESEED, 0);
DBCC CHECKIDENT ('pharmacyTable', RESEED, 0);
DBCC CHECKIDENT ('medicineTable', RESEED, 0);

UPDATE pharmacyTable SET pharmacyName = 'FarmaciaNew7' WHERE pharmacyId = 6
--[REGISTROS]=================================================================================
INSERT INTO ownerTable (ownerName, ownerLastName, ownerGender, ownerPhoneNumber, ownerGmail) 
VALUES 
('Carlos', 'Pérez', 'M', '1234567890', 'carlos.perez@example.com'),
('María', 'López', 'F', '0987654321', 'maria.lopez@example.com'),
('Juan', 'Martínez', 'M', '1122334455', 'juan.martinez@example.com'),
('Ana', 'García', 'F', '2233445566', 'ana.garcia@example.com'),
('Luis', 'Hernández', 'M', '3344556677', 'luis.hernandez@example.com'),
('Sofía', 'Ramírez', 'F', '4455667788', 'sofia.ramirez@example.com'),
('Miguel', 'Torres', 'M', '5566778899', 'miguel.torres@example.com'),
('Laura', 'Gómez', 'F', '6677889900', 'laura.gomez@example.com'),
('Diego', 'Vargas', 'M', '7788990011', 'diego.vargas@example.com'),
('Elena', 'Morales', 'F', '8899001122', 'elena.morales@example.com');

INSERT INTO locationTable (locationAddress, locationCity, locationState) 
VALUES 
('Avenida Constitución 1000', 'Aguascalientes', 'Aguascalientes'),
('Calle Paseo del Río 200', 'Tijuana', 'Baja California'),
('Avenida del Mar 150', 'La Paz', 'Baja California Sur'),
('Calle Central 123', 'Tuxtla Gutiérrez', 'Chiapas'),
('Avenida Pacheco 700', 'Chihuahua', 'Chihuahua'),
('Calle Reforma 1234', 'Ciudad de México', 'Ciudad de México'),
('Avenida Juárez 555', 'Saltillo', 'Coahuila'),
('Calle Colima 1020', 'Colima', 'Colima'),
('Avenida Guanajuato 700', 'León', 'Guanajuato'),
('Calle Guerrero 456', 'Acapulco', 'Guerrero');

INSERT INTO pharmacyTable (pharmacyName, ownerId, locationId) 
VALUES 
('Farmacia 1', 1, 1),
('Farmacia 2', 2, 2),
('Farmacia 3', 3, 3),
('Farmacia 4', 4, 4),
('Farmacia 5', 5, 5),
('Farmacia 6', 6, 6),
('Farmacia 7', 7, 7),
('Farmacia 8', 8, 8),
('Farmacia 9', 9, 9),
('Farmacia 10', 10, 10);

INSERT INTO medicineTable (medicineName) 
VALUES 
('Paracetamol'),
('Ibuprofeno'),
('Amoxicilina'),
('Diclofenaco'),
('Loratadina'),
('Ranitidina'),
('Metformina'),
('Clonazepam'),
('Omeprazol'),
('Azitromicina');

INSERT INTO inventoryTable (pharmacyId, medicineId, stock) 
VALUES 
(1, 1, 50),
(1, 2, 30),
(2, 3, 20),
(2, 4, 40),
(3, 5, 15),
(3, 6, 25),
(8, 7, 60),
(8, 8, 10),
(5, 9, 35),
(5, 10, 45);
--[VISTAS]====================================================================================
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

--DROP VIEW propietarios_direcciones (Vista Actualizada)
--VISTA EN LA QUE SE PUEDE VER LA DIRECCION DE LOS PROPIETARIOS
CREATE VIEW propietarios_direcciones AS
SELECT 
    p.pharmacyId AS ID,
    p.pharmacyName AS Farmacia,
    CONCAT(o.ownerName, ' ', o.ownerLastName) AS Propietario,
    CONCAT(l.locationCity, '-', l.locationAddress) AS Ubicación
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

--[PROCEDURES]====================================================================================
-- Método para consultar ownerTable en orden ascendente y descendente
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

-- Método para consultar locationTable en orden ascendente y descendente
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

-- Método para consultar pharmacyTable en orden ascendente y descendente
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

-- Método para consultar medicineTable en orden ascendente y descendente
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

-- Método para consultar inventoryTable en orden ascendente y descendente
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
