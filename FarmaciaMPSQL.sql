--[Base de Datos]
CREATE DATABASE FarmaciasMP

USE FarmaciasMP
GO
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

DELETE FROM 
DBCC CHECKIDENT ('ownerTable', RESEED, 0);

-- [Propietarios]
INSERT INTO ownerTable (ownerName, ownerLastName, ownerGender, ownerPhoneNumber, ownerGmail)
VALUES
('Carlos', 'Gómez', 'M', '1234567890', 'carlos.gomez@gmail.com'),
('Ana', 'Martínez', 'F', '1234567891', 'ana.martinez@gmail.com'),
('Luis', 'Fernández', 'M', '1234567892', 'luis.fernandez@gmail.com'),
('María', 'López', 'F', '1234567893', 'maria.lopez@gmail.com'),
('José', 'Pérez', 'M', '1234567894', 'jose.perez@gmail.com'),
('Laura', 'Ramírez', 'F', '1234567895', 'laura.ramirez@gmail.com'),
('Javier', 'Torres', 'M', '1234567896', 'javier.torres@gmail.com'),
('Marta', 'Sánchez', 'F', '1234567897', 'marta.sanchez@gmail.com'),
('Andrés', 'Castro', 'M', '1234567898', 'andres.castro@gmail.com'),
('Lucía', 'Vega', 'F', '1234567899', 'lucia.vega@gmail.com'),
('Miguel', 'Ortega', 'M', '1234567800', 'miguel.ortega@gmail.com'),
('Sofía', 'Morales', 'F', '1234567801', 'sofia.morales@gmail.com'),
('Juan', 'Núñez', 'M', '1234567802', 'juan.nunez@gmail.com'),
('Isabel', 'Herrera', 'F', '1234567803', 'isabel.herrera@gmail.com'),
('Pedro', 'Flores', 'M', '1234567804', 'pedro.flores@gmail.com'),
('Elena', 'Rivas', 'F', '1234567805', 'elena.rivas@gmail.com'),
('Héctor', 'Ruiz', 'M', '1234567806', 'hector.ruiz@gmail.com'),
('Clara', 'Cruz', 'F', '1234567807', 'clara.cruz@gmail.com'),
('Roberto', 'Navarro', 'M', '1234567808', 'roberto.navarro@gmail.com'),
('Gabriela', 'Castillo', 'F', '1234567809', 'gabriela.castillo@gmail.com');

-- [Ubicaciones]
INSERT INTO locationTable (locationAddress, locationCity, locationState)
VALUES
('Av. Reforma 123', 'Ciudad de México', 'CDMX'),
('Calle 10 #45', 'Guadalajara', 'Jalisco'),
('Col. Centro #567', 'Monterrey', 'Nuevo León'),
('Paseo de las Flores 21', 'Puebla', 'Puebla'),
('Av. Sol 90', 'Cancún', 'Quintana Roo'),
('Av. Insurgentes 450', 'Querétaro', 'Querétaro'),
('Calle Luna #11', 'Tijuana', 'Baja California'),
('Plaza Mayor #32', 'León', 'Guanajuato'),
('Zona Río #88', 'Mexicali', 'Baja California'),
('Calle Oro 15', 'Culiacán', 'Sinaloa'),
('Paseo del Valle 98', 'Mérida', 'Yucatán'),
('Col. Roma Norte #45', 'Ciudad de México', 'CDMX'),
('Calle Sur 13', 'Toluca', 'Estado de México'),
('Av. Hidalgo 32', 'Tepic', 'Nayarit'),
('Boulevard San Ángel 200', 'Chihuahua', 'Chihuahua'),
('Col. San Pedro #89', 'Saltillo', 'Coahuila'),
('Calle Norte 44', 'Villahermosa', 'Tabasco'),
('Paseo del Norte #77', 'Zacatecas', 'Zacatecas'),
('Calle Diamante 12', 'Morelia', 'Michoacán'),
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
('Losartán'),
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
('Acetaminofén'),
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
            RAISERROR('Los campos de nombre, apellido y género son obligatorios.', 16, 1);
        END

        -- Insertar nuevo propietario
        INSERT INTO ownerTable (ownerName, ownerLastName, ownerGender, ownerPhoneNumber, ownerGmail)
        VALUES (@ownerName, @ownerLastName, @ownerGender, @ownerPhoneNumber, @ownerGmail);

        -- Obtener el ID del propietario recién insertado
        DECLARE @newOwnerId INT = SCOPE_IDENTITY();

        COMMIT TRANSACTION;
        
        -- Devolver el ID del nuevo propietario
        SELECT @newOwnerId AS NewOwnerId;
    END TRY
    BEGIN CATCH
        -- Si hay un error, revertir la transacción
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

        -- Verificar que la ubicación existe
        IF NOT EXISTS (SELECT 1 FROM locationTable WHERE locationId = @locationId)
        BEGIN
            RAISERROR('La ubicación especificada no existe.', 16, 1);
        END

        -- Insertar nueva farmacia
        INSERT INTO pharmacyTable (pharmacyName, ownerId, locationId)
        VALUES (@pharmacyName, @ownerId, @locationId);

        -- Obtener el ID de la farmacia recién insertada
        DECLARE @newPharmacyId INT = SCOPE_IDENTITY();

        COMMIT TRANSACTION;
        
        -- Devolver el ID de la nueva farmacia
        SELECT @newPharmacyId AS NewPharmacyId;
    END TRY
    BEGIN CATCH
        -- Si hay un error, revertir la transacción
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
            RAISERROR('Datos inválidos. Verifique los valores de farmacia, medicamento y stock.', 16, 1);
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
        
        -- Confirmar operación exitosa
        SELECT 1 AS OperationStatus;
    END TRY
    BEGIN CATCH
        -- Si hay un error, revertir la transacción
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