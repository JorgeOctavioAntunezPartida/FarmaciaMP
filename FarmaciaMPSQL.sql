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


--PROCEDIMIENTOS  CON TRANSACTIONS COMMIT Y ROLLBACK
--PRIMER PROCEDIMIENTO
CREATE PROCEDURE AgregarPropietario
(
    @ownerName NVARCHAR(50),
    @ownerLastName NVARCHAR(50),
    @ownerGender CHAR(1),
    @ownerPhoneNumber NVARCHAR(20),
    @ownerGmail NVARCHAR(128)
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Validar datos de entrada
        IF @ownerName IS NULL OR @ownerLastName IS NULL OR @ownerGender IS NULL
        BEGIN
            RAISERROR('Los campos de nombre, apellido y g�nero son obligatorios.', 16, 1);
        END

        -- Insertar nuevo propietario
        INSERT INTO ownerTable (ownerName, ownerLastName, ownerGender, ownerPhoneNumber, ownerGmail)
        VALUES (@ownerName, @ownerLastName, @ownerGender, @ownerPhoneNumber, @ownerGmail);

        -- Obtener el ID del propietario reci�n insertado
        DECLARE @newOwnerId INT = SCOPE_IDENTITY();

        COMMIT TRANSACTION;
        
        -- Devolver el ID del nuevo propietario
        SELECT @newOwnerId AS NewOwnerId;
    END TRY
    BEGIN CATCH
        -- Si hay un error, revertir la transacci�n
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Lanzar el error original
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE(),
                @ErrorSeverity INT = ERROR_SEVERITY(),
                @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;


--SEGUNDO PROCEDIMIENTO
-- Procedimiento para agregar una nueva farmacia con manejo de transacciones
CREATE PROCEDURE AgregarFarmacia
(
    @pharmacyName NVARCHAR(50),
    @ownerId INT,
    @locationId INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Validar datos de entrada
        IF @pharmacyName IS NULL OR @ownerId IS NULL OR @locationId IS NULL
        BEGIN
            RAISERROR('Todos los campos son obligatorios para agregar una farmacia.', 16, 1);
        END

        -- Verificar que el propietario existe
        IF NOT EXISTS (SELECT 1 FROM ownerTable WHERE ownerId = @ownerId)
        BEGIN
            RAISERROR('El propietario especificado no existe.', 16, 1);
        END

        -- Verificar que la ubicaci�n existe
        IF NOT EXISTS (SELECT 1 FROM locationTable WHERE locationId = @locationId)
        BEGIN
            RAISERROR('La ubicaci�n especificada no existe.', 16, 1);
        END

        -- Insertar nueva farmacia
        INSERT INTO pharmacyTable (pharmacyName, ownerId, locationId)
        VALUES (@pharmacyName, @ownerId, @locationId);

        -- Obtener el ID de la farmacia reci�n insertada
        DECLARE @newPharmacyId INT = SCOPE_IDENTITY();

        COMMIT TRANSACTION;
        
        -- Devolver el ID de la nueva farmacia
        SELECT @newPharmacyId AS NewPharmacyId;
    END TRY
    BEGIN CATCH
        -- Si hay un error, revertir la transacci�n
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Lanzar el error original
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE(),
                @ErrorSeverity INT = ERROR_SEVERITY(),
                @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;

--TERCER PROCEDIMIENTO
-- Procedimiento para agregar un medicamento al inventario con manejo de transacciones
CREATE PROCEDURE AgregarMedicamentoInventario
(
    @pharmacyId INT,
    @medicineId INT,
    @stock INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Validar datos de entrada
        IF @pharmacyId IS NULL OR @medicineId IS NULL OR @stock < 0
        BEGIN
            RAISERROR('Datos inv�lidos. Verifique los valores de farmacia, medicamento y stock.', 16, 1);
        END

        -- Verificar que la farmacia existe
        IF NOT EXISTS (SELECT 1 FROM pharmacyTable WHERE pharmacyId = @pharmacyId)
        BEGIN
            RAISERROR('La farmacia especificada no existe.', 16, 1);
        END

        -- Verificar que el medicamento existe
        IF NOT EXISTS (SELECT 1 FROM medicineTable WHERE medicineId = @medicineId)
        BEGIN
            RAISERROR('El medicamento especificado no existe.', 16, 1);
        END

        -- Verificar si ya existe el registro en inventario
        IF EXISTS (SELECT 1 FROM inventoryTable WHERE pharmacyId = @pharmacyId AND medicineId = @medicineId)
        BEGIN
            -- Si ya existe, actualizar el stock
            UPDATE inventoryTable
            SET stock = stock + @stock
            WHERE pharmacyId = @pharmacyId AND medicineId = @medicineId;
        END
        ELSE
        BEGIN
            -- Si no existe, insertar nuevo registro de inventario
            INSERT INTO inventoryTable (pharmacyId, medicineId, stock)
            VALUES (@pharmacyId, @medicineId, @stock);
        END

        COMMIT TRANSACTION;
        
        -- Confirmar operaci�n exitosa
        SELECT 1 AS OperationStatus;
    END TRY
    BEGIN CATCH
        -- Si hay un error, revertir la transacci�n
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Lanzar el error original
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE(),
                @ErrorSeverity INT = ERROR_SEVERITY(),
                @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;

SELECT * FROM sys.procedures 
WHERE name IN ('AgregarPropietario', 'AgregarFarmacia', 'AgregarMedicamentoInventario')