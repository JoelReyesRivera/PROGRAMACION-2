--INTEGRANTES--
--ABITIA ROJO ENDHIR FERNANDO
--BELTRAN ANGULO MARIA CRISTINA
--REYES RIVERA JOEL

CREATE DATABASE FACTURAS
GO
USE FACTURAS

--CREACION DE LAS TABLAS
CREATE TABLE Articulo (
Clave INT IDENTITY (1,1) PRIMARY KEY,
Descripcion VARCHAR(50) NOT NULL,
Marca CHAR (10) NOT NULL,
Precio MONEY NOT NULL,
Cantidad INT NOT NULL
)

CREATE TABLE Proveedor (
Clave INT PRIMARY KEY,
Nombre VARCHAR(50) NOT NULL,
RFC CHAR(10) NOT NULL,
Domicilio VARCHAR(50) NOT NULL,
Saldo MONEY NOT NULL,
)

CREATE TABLE Factura (
Clave BIGINT IDENTITY (1,1) PRIMARY KEY,
Provedor INT NOT NULL,
Fecha date NOT NULL,
Monto Money NOT NULL,
FOREIGN KEY (Provedor) REFERENCES Proveedor(Clave)
)

CREATE TABLE DetalleFactura(
Factura BIGINT NOT NULL,
Articulo INT NOT NULL,
Cantidad INT NOT NULL,
Precio MONEY NOT NULL,
FOREIGN KEY (Articulo) REFERENCES Articulo(Clave),
FOREIGN KEY (Factura) REFERENCES Factura(Clave)
)

--RESTRICCIONES/CONSTRAINTS

ALTER TABLE DetalleFactura
ADD CONSTRAINT Articulo_Detalle_Unico UNIQUE (Factura,Articulo); 

ALTER TABLE Articulo
ADD CONSTRAINT PrecioArticuloInvalido  CHECK (Precio>0)

ALTER TABLE Articulo
ADD CONSTRAINT CantidadArticuloInvalido  CHECK (Cantidad>=0)

ALTER TABLE DetalleFactura
ADD CONSTRAINT PrecioDetalleInvalido  CHECK (Precio>0)

ALTER TABLE DetalleFactura
ADD CONSTRAINT CantidadDetalleInvalido  CHECK (Precio>0)

ALTER TABLE Proveedor
ADD CONSTRAINT SaldoInvalido CHECK (Saldo>-1)

--PROCEDIMIENTO INSERTAR DETALLE FACTURA
GO
CREATE PROC	InsertarDetalleFactura (
	@Factura BIGINT,
	@Articulo INT,
	@Cantidad INT
)
AS 
	BEGIN
		DECLARE @Precio MONEY
		SET @Precio = (SELECT Precio FROM Articulo WHERE Clave=@Articulo)
		INSERT INTO DetalleFactura VALUES (@Factura,@Articulo,@Cantidad,@Precio)
	END

--TRIGGER PARA RESTAR EXISTENCIA
GO
CREATE TRIGGER RestarExistencia ON DetalleFactura AFTER INSERT
AS
		DECLARE @Articulo INT
		DECLARE @Cantidad INT

	SELECT @Articulo = Articulo, @Cantidad = Cantidad  FROM inserted 
	DECLARE @CantidadActual INT

	set @CantidadActual = (select Cantidad from Articulo where Clave = @Articulo)

	IF (@CantidadActual-@Cantidad) < (0)
		BEGIN
			Print 'CANTIDAD INSUFICIENTE'
			Rollback Transaction
		END
	ELSE
		BEGIN
			UPDATE Articulo SET Cantidad=Cantidad-@Cantidad	WHERE Clave=@Articulo
			Declare @Monto Money, @Provedor int,@Factura BigInt
			Set @Factura = (Select Factura from inserted)
			Set @Provedor = (Select Provedor from Factura where Clave = @Factura) 
			Set @Monto = (Select (precio * cantidad) from inserted)
			UPDATE Proveedor Set saldo=saldo+@Monto where clave = @Provedor
			UPDATE Factura Set Monto = Monto+@Monto where Clave = @Factura
		END

GO
---TRIGGER PARA VERIFICAR EL SALDO DESPUÉS DEL UPDATE (SIN CHECK)---
CREATE TRIGGER DecrementaSaldo ON Proveedor FOR UPDATE AS

	DECLARE @Clave INT
	DECLARE @Saldo MONEY

	select @Clave = Clave  FROM inserted
	set @Saldo = (select Saldo from Proveedor where Clave=@Clave)
	IF (@Saldo<0)
		BEGIN
			Print 'EL IMPORTE A RESTAR DEBE SER IGUAL O MENOR QUE EL SALDO ACTUAL'
			Rollback Transaction
		END

--INSERSIONES EJEMPLO
GO
INSERT INTO Articulo
VALUES ('PAN','BIMBO',30.5,15)

INSERT INTO Proveedor
VALUES (1,'JOEL','JORR110899','HUERTOS',0)

INSERT INTO Factura
VALUES (1,'04/05/2019',0)

exec InsertarDetalleFactura 1,1,15

SELECT * FROM Articulo
SELECT * FROM Proveedor
SELECT * FROM Factura
SELECT * FROM DetalleFactura

select * from DetalleFactura where Factura = 1 and Articulo = 1
SELECT COUNT (Factura) FROM DetalleFactura WHERE Factura=2
SELECT COUNT (Clave) FROM Articulo