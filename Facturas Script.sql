--INTEGRANTES--
--ABITIA ROJO ENDHIR FERNANDO
--BELTRAN ANGULO MARIA CRISTINA
--REYES RIVERA JOEL

CREATE DATABASE FACTURAS
GO
USE FACTURAS
GO

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
Clave BIGINT PRIMARY KEY,
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

CREATE TABLE PagoProveedor(
Clave INT IDENTITY (1,1) PRIMARY KEY,
Proveedor INT NOT NULL,
Fecha date NOT NULL,
Importe Money NOT NULL,
FOREIGN KEY (Proveedor) REFERENCES Proveedor(Clave)
)
--RESTRICCIONES/CONSTRAINTS

ALTER TABLE DetalleFactura
ADD CONSTRAINT Articulo_Detalle_Unico UNIQUE (Factura,Articulo); 

ALTER TABLE Factura
ADD CONSTRAINT Factura_Clave UNIQUE (Clave); 

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

--PROCEDIMIENTO PARA ELIMINAR DETALLE FACTURA
GO
CREATE PROC	EliminaDetalleFactura (
	@FACTURA BIGINT,
	@ARTICULO INT,
	@CANTIDAD INT,
	@PRECIO MONEY
)
AS 
	BEGIN
	    DECLARE @PROVEEDOR INT, @SALDO INT, @MONTO MONEY

		SET @Proveedor=(SELECT Provedor FROM Factura WHERE Clave=@FACTURA)
		SET @SALDO=(SELECT Saldo FROM Proveedor WHERE Clave=@PROVEEDOR)
		SET @MONTO=(@PRECIO*@CANTIDAD)

		UPDATE Articulo SET Cantidad=Cantidad+@CANTIDAD WHERE Clave=@ARTICULO
		
		UPDATE Factura SET Monto=Monto-@MONTO WHERE Clave=@FACTURA

		DELETE FROM DetalleFactura WHERE Factura=@FACTURA  AND Articulo=@ARTICULO AND Cantidad=@CANTIDAD AND Precio=@PRECIO
				
		IF(@SALDO>=@MONTO)
			UPDATE Proveedor SET Saldo=Saldo-@MONTO WHERE Clave=@PROVEEDOR
		ELSE
			UPDATE Proveedor SET Saldo=0 WHERE Clave=@PROVEEDOR
	END

--TRIGGER PARA ACTUALIZAR SALDO PROVEEDOR
GO
CREATE TRIGGER SaldoProveedor ON PagoProveedor FOR INSERT
AS
		DECLARE @PROVEEDOR INT
		DECLARE @IMPORTE MONEY
		DECLARE @SALDO MONEY

	SELECT @PROVEEDOR = Proveedor, @IMPORTE = Importe  FROM inserted 

	SET @SALDO = (SELECT Saldo FROM Proveedor WHERE Clave=@PROVEEDOR)

	IF (@SALDO-@IMPORTE) < (0)
			ROLLBACK
	ELSE
			UPDATE Proveedor SET Saldo=Saldo-@IMPORTE	WHERE Clave=@PROVEEDOR
GO
--INSERSIONES EJEMPLO
GO
INSERT INTO Articulo
VALUES ('PAN','BIMBO',30.5,17)
INSERT INTO Articulo
VALUES ('LECHE','LALA',25.5,10)

INSERT INTO Proveedor
VALUES (1,'JOEL REYES','JORR110899','HUERTOS',0)
INSERT INTO Proveedor
VALUES (2,'CRISTINA BELTRAN','BACR110399','LOS PINOS',0)
INSERT INTO Proveedor
VALUES (3,'FERNANDO ABITIA','NAND112698','LA PENI',0)

INSERT INTO Factura
VALUES (1,1,'04/05/2019',0)
INSERT INTO Factura
VALUES (2,2,'02/06/2019',0)
INSERT INTO Factura
VALUES (3,3,'01/01/2019',0)


exec InsertarDetalleFactura 1,1,10
exec InsertarDetalleFactura 2,2,6
exec InsertarDetalleFactura 3,1,5
exec InsertarDetalleFactura 3,2,1


SELECT * FROM Articulo
SELECT * FROM Proveedor
SELECT * FROM Factura
SELECT * FROM DetalleFactura

select * from DetalleFactura where Factura = 1 and Articulo = 1
SELECT COUNT (Factura) FROM DetalleFactura WHERE Factura=2
SELECT COUNT (Clave) FROM Articulo
SELECT CLAVE FROM FACTURA ORDER BY CLAVE ASC
SELECT Descripcion FROM ARTICULO ORDER BY Descripcion ASC
SELECT clave,Provedor,format(Fecha	,'dd/MM/yyyy'),monto FROM FACTURA where clave =1
select a.Clave,a.Descripcion,d.Precio,d.Cantidad from DetalleFactura d inner join Articulo a on a.Clave=d.Articulo where d.Factura=1

SELECT * FROM DetalleFactura
SELECT Descripcion FROM Articulo ORDER BY Descripcion ASC

select d.Factura,a.clave,a.descripcion,d.Precio,d.Cantidad,(d.Precio*d.Cantidad) from DetalleFactura d inner join Articulo a on d.Articulo=a.clave 

select f.clave,p.clave,p.Nombre,f.monto,format(f.fecha,'dd/MM/yyyy') from Factura f inner join Proveedor p on f.provedor=p.Clave where p.Nombre ='JOEL'
SELECT F.CLAVE FROM FACTURA  F INNER JOIN Proveedor P ON P.Clave=f.provedor where P.Nombre='JOEL'
select d.Factura,d.Articulo,a.descripcion,a.marca,d.Cantidad,d.Precio,(d.Cantidad*d.Precio) from DetalleFactura d inner join Articulo a on a.clave = d.Articulo where d.Factura = 1

SELECT * FROM Factura F INNER JOIN DetalleFactura D ON F.Clave=D.Factura WHERE F.Clave=10

SELECT F.Clave,P.Nombre,FORMAT(F.Fecha,'dd/MM/yyyy') AS Fecha,F.Monto FROM Factura F 
INNER JOIN Proveedor P ON F.Provedor=P.Clave ORDER BY F.Clave

SELECT A.Clave,A.Descripcion,DF.Cantidad,DF.Precio FROM DetalleFactura DF 
INNER JOIN Articulo A ON DF.Articulo=A.Clave WHERE DF.Factura=1
ORDER BY DF.Factura

SELECT P.Nombre,P.Clave FROM Factura F INNER JOIN Proveedor P ON F.Provedor=P.Clave WHERE F.Clave=1

SELECT PA.Clave, P.Clave AS ClaveP, P.Nombre, FORMAT(PA.Fecha,'dd/MM/yyyy')AS Fecha, PA.Importe FROM PagoProveedor PA 
INNER JOIN Proveedor P ON PA.Proveedor=P.Clave