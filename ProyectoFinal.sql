-- Crear la base de datos FarmaciasMP
CREATE DATABASE FarmaciasMP;

USE FarmaciasMP;
GO

--[Propietarios]
CREATE TABLE ownerTable
(
    ownerId INT PRIMARY KEY IDENTITY(1,1), -- Identificador único del propietario
    ownerName NVARCHAR(50) NOT NULL,       -- Nombre del propietario
    ownerLastName NVARCHAR(50) NOT NULL,   -- Apellido del propietario
    ownerGender CHAR(1) NOT NULL,          -- Género
    ownerPhoneNumber NVARCHAR(20),         -- Número telefónico
    ownerGmail NVARCHAR(128)               -- Información de contacto (Correo electrónico)
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
    totalInventoryValue DECIMAL(18, 2) NULL,  -- Valor total del inventario
    FOREIGN KEY (ownerId) REFERENCES ownerTable(ownerId),
    FOREIGN KEY (locationId) REFERENCES locationTable(locationId)
);

--[Medicamento]
CREATE TABLE medicineTable
(
    medicineId INT PRIMARY KEY IDENTITY(1,1), -- Identificador único del medicamento
    medicineName NVARCHAR(50) NOT NULL,         -- Nombre del medicamento
    medicinePrice DECIMAL(18, 2) NOT NULL       -- Precio del medicamento
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
GO

--[Trigger 1: Evitar stock negativo en el inventario]
CREATE TRIGGER trg_StockNoNegativo
ON inventoryTable
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @pharmacyId INT, @medicineId INT, @stock INT;
    
    -- Obtener los valores de las filas insertadas o actualizadas
    SELECT @pharmacyId = pharmacyId, @medicineId = medicineId, @stock = stock
    FROM inserted;
    
    -- Verificar si el stock es negativo
    IF @stock < 0
    BEGIN
        -- Generar error si el stock es negativo
        RAISERROR('El stock no puede ser negativo.', 16, 1);
        ROLLBACK TRANSACTION;  -- Revertir la transacción
    END
END;
GO

--[Trigger 2: Actualizar el valor total del inventario en la farmacia]
-- Este trigger actualiza el valor total del inventario en la tabla 'pharmacyTable'
CREATE TRIGGER trg_ActualizarValorInventario
ON inventoryTable
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @pharmacyId INT, @totalValue DECIMAL(18, 2);

    -- Obtener el ID de la farmacia afectada
    SELECT @pharmacyId = pharmacyId FROM inserted;
    IF @pharmacyId IS NULL
    BEGIN
        SELECT @pharmacyId = pharmacyId FROM deleted;
    END

    -- Calcular el nuevo valor total del inventario para esa farmacia
    SELECT @totalValue = SUM(i.stock * m.medicinePrice)
    FROM inventoryTable i
    JOIN medicineTable m ON i.medicineId = m.medicineId
    WHERE i.pharmacyId = @pharmacyId;

    -- Actualizar el valor total del inventario en la tabla pharmacyTable
    UPDATE pharmacyTable
    SET totalInventoryValue = @totalValue -- Asegúrate de tener esta columna en la tabla pharmacyTable
    WHERE pharmacyId = @pharmacyId;
END;
GO

--[Trigger 3: Evitar eliminar una farmacia con medicamentos en inventario]
-- Este trigger evita que se elimine una farmacia que tenga medicamentos en inventario
CREATE TRIGGER trg_EvitarEliminarFarmaciaConInventario
ON pharmacyTable
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @pharmacyId INT;
    
    -- Obtener el ID de la farmacia que se quiere eliminar
    SELECT @pharmacyId = pharmacyId FROM deleted;
    
    -- Verificar si la farmacia tiene medicamentos en el inventario
    IF EXISTS (SELECT 1 FROM inventoryTable WHERE pharmacyId = @pharmacyId)
    BEGIN
        -- Si tiene inventario, no permitir la eliminación y generar un mensaje de error
        RAISERROR('No se puede eliminar la farmacia porque tiene medicamentos en inventario.', 16, 1);
    END
    ELSE
    BEGIN
        -- Si no tiene inventario, proceder con la eliminación
        DELETE FROM pharmacyTable WHERE pharmacyId = @pharmacyId;
    END
END;
GO
-- Función 1: Calcular el valor total del inventario de una farmacia
CREATE FUNCTION dbo.CalcularValorInventario (@pharmacyId INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @totalValue DECIMAL(18, 2);

    -- Calcular el valor total del inventario sumando stock * precio del medicamento
    SELECT @totalValue = SUM(i.stock * m.medicinePrice)
    FROM inventoryTable i
    JOIN medicineTable m ON i.medicineId = m.medicineId
    WHERE i.pharmacyId = @pharmacyId;

    RETURN @totalValue;
END;
GO

-- Función 2: Obtener la cantidad total de medicamentos en una farmacia
CREATE FUNCTION dbo.CantidadTotalMedicamentosPorFarmacia (@pharmacyId INT)
RETURNS INT
AS
BEGIN
    DECLARE @totalStock INT;

    -- Obtener el total de stock de medicamentos
    SELECT @totalStock = SUM(i.stock)
    FROM inventoryTable i
    WHERE i.pharmacyId = @pharmacyId;

    RETURN @totalStock;
END;
GO

-- Función 3: Obtener la farmacia con el mayor inventario
CREATE FUNCTION dbo.FarmaciaConMayorInventario ()
RETURNS INT
AS
BEGIN
    DECLARE @pharmacyId INT;

    -- Obtener la farmacia con el mayor total de stock
    SELECT TOP 1 @pharmacyId = i.pharmacyId
    FROM inventoryTable i
    GROUP BY i.pharmacyId
    ORDER BY SUM(i.stock) DESC;

    RETURN @pharmacyId;
END;
GO

-- Procedimientos y datos de ejemplo

-- Procedimiento 1: Insertar Propietarios con Transacción
CREATE PROCEDURE InsertarPropietariosConTransaccion
    @ownerName NVARCHAR(50),
    @ownerLastName NVARCHAR(50),
    @ownerGender CHAR(1),
    @ownerPhoneNumber NVARCHAR(20),
    @ownerGmail NVARCHAR(128)
AS
BEGIN
    BEGIN TRANSACTION; -- Inicia la transacción

    BEGIN TRY
        -- Intentar insertar los datos
        INSERT INTO ownerTable (ownerName, ownerLastName, ownerGender, ownerPhoneNumber, ownerGmail)
        VALUES (@ownerName, @ownerLastName, @ownerGender, @ownerPhoneNumber, @ownerGmail);

        -- Si no hay errores, confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Si hay algún error, revertir la transacción
        ROLLBACK TRANSACTION;
        
        -- Imprimir el error
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

-- Procedimiento 2: Actualizar Inventario con Transacción
CREATE PROCEDURE ActualizarInventarioConTransaccion
    @pharmacyId INT,
    @medicineId INT,
    @newStock INT
AS
BEGIN
    BEGIN TRANSACTION; -- Inicia la transacción

    BEGIN TRY
        -- Intentar actualizar el inventario
        UPDATE inventoryTable
        SET stock = @newStock
        WHERE pharmacyId = @pharmacyId AND medicineId = @medicineId;

        -- Si no hay errores, confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Si hay algún error, revertir la transacción
        ROLLBACK TRANSACTION;
        
        -- Imprimir el error
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END;
GO

-- Procedimiento 3: Crear Farmacia con Transacción
CREATE PROCEDURE CrearFarmaciaConTransaccion
    @pharmacyName NVARCHAR(50),
    @ownerId INT,
    @locationId INT
AS
BEGIN
    BEGIN TRANSACTION; -- Inicia la transacción

    BEGIN TRY
        -- Intentar insertar la nueva farmacia
        INSERT INTO pharmacyTable (pharmacyName, ownerId, locationId)
        VALUES (@pharmacyName, @ownerId, @locationId);

        -- Si no hay errores, confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Si hay un error, revertir la transacción
        ROLLBACK TRANSACTION;
        
        -- Imprimir el error
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END;

-- Insertar datos de ejemplo en las tablas (para pruebas)
INSERT INTO ownerTable (ownerName, ownerLastName, ownerGender, ownerPhoneNumber, ownerGmail)
VALUES
('Carlos', 'Gómez', 'M', '1234567890', 'carlos.gomez@gmail.com'),
('Ana', 'Martínez', 'F', '1234567891', 'ana.martinez@gmail.com'),
('Luis', 'Fernández', 'M', '1234567892', 'luis.fernandez@gmail.com');

INSERT INTO locationTable (locationAddress, locationCity, locationState)
VALUES
('Av. Reforma 123', 'Ciudad de México', 'CDMX'),
('Calle 10 #45', 'Guadalajara', 'Jalisco'),
('Col. Centro #567', 'Monterrey', 'Nuevo León');

INSERT INTO medicineTable (medicineName, medicinePrice)
VALUES
('Paracetamol', 15.00),
('Ibuprofeno', 20.50),
('Amoxicilina', 30.00);

-- Crear farmacias de ejemplo
INSERT INTO pharmacyTable (pharmacyName, ownerId, locationId)
VALUES
('Farmacia Gómez', 1, 1),
('Farmacia Martínez', 2, 2);

-- Insertar medicamentos en el inventario
INSERT INTO inventoryTable (pharmacyId, medicineId, stock)
VALUES
(1, 1, 100),
(1, 2, 50),
(2, 3, 200);

-- Ejecutar procedimientos con transacciones

-- Insertar un nuevo propietario
EXEC InsertarPropietariosConTransaccion 'Juan', 'Pérez', 'M', '9876543210', 'juan.perez@gmail.com';

-- Actualizar el inventario de la Farmacia Gómez para el medicamento Paracetamol
EXEC ActualizarInventarioConTransaccion 1, 1, 150;

-- Crear una nueva farmacia
EXEC CrearFarmaciaConTransaccion 'Farmacia Pérez', 3, 3;

-- Consultas de ejemplo con las nuevas funciones

-- Calcular el valor total del inventario de la farmacia con ID 1
SELECT dbo.CalcularValorInventario(1) AS TotalValorInventario;

-- Obtener la cantidad total de medicamentos de la farmacia con ID 1
SELECT dbo.CantidadTotalMedicamentosPorFarmacia(1) AS TotalMedicamentos;

-- Obtener la farmacia con el mayor inventario
SELECT dbo.FarmaciaConMayorInventario() AS FarmaciaConMayorInventario;
