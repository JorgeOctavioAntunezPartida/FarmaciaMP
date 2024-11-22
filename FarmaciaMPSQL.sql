--[Base de Datos]
CREATE DATABASE FarmaciasMP

USE FarmaciasMP

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
    locationId INT PRIMARY KEY IDENTITY(1,1),  -- Identificador único de la ubicación
    locationAddress NVARCHAR(255),             -- Dirección
    locationCity NVARCHAR(100),                -- Ciudad
    locationState NVARCHAR(100)                -- Estado
);

--[Farmacia]
CREATE TABLE pharmacyTable
(
    pharmacyId INT PRIMARY KEY IDENTITY(1,1), -- Identificador único de la farmacia
    pharmacyName NVARCHAR(100) NOT NULL,      -- Nombre de la farmacia
    ownerId INT NOT NULL,                     -- Relación con el propietario
    locationId INT NOT NULL,                  -- Relación con la ubicación
    FOREIGN KEY (OwnerId) REFERENCES ownerTable(OwnerId),
    FOREIGN KEY (LocationId) REFERENCES locationTable(LocationId)
);

--[Medicamento]
CREATE TABLE medicineTable
(
    medicineId INT PRIMARY KEY IDENTITY(1,1), -- Identificador único del medicamento
    medicineName NVARCHAR(100) NOT NULL,      -- Nombre del medicamento
);

--[Inventario]
CREATE TABLE inventoryTable
(
    pharmacyId INT NOT NULL,                  -- Relación con la farmacia
    medicineId INT NOT NULL,                  -- Relación con el medicamento
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
