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
    FOREIGN KEY (ownerId) REFERENCES ownerTable(ownerId),
    FOREIGN KEY (locationId) REFERENCES locationTable(locationId)
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
