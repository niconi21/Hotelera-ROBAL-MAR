CREATE DATABASE Hotelera_ROBAL_MAR;
GO
USE Hotelera_ROBAL_MAR;
GO
CREATE TABLE Piso(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	numero INT NOT NULL);
GO
CREATE TABLE Habitacion(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	numero INT NOT NULL,
	estatus VARCHAR(13) NOT NULL,
	tipo VARCHAR(10) NOT NULL,
	precio SMALLMONEY NOT NULL,
	piso INT NOT NULL CONSTRAINT fk_habitacion_esta_piso REFERENCES Piso);
GO
CREATE TABLE Personal(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	tipoPersonal INT NOT NULL,
	nombre VARCHAR(30) NOT NULL,
	apepat VARCHAR(30) NOT NULL,
	apemat VARCHAR(30) NOT NULL,
	usuario VARCHAR(30) NOT NULL,
	clave VARCHAR(30) NOT NULL,
	curp VARCHAR(18) NOT NULL);
GO
CREATE TABLE Cliente(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	nombre VARCHAR(30) NOT NULL,
	apepat VARCHAR(30) NOT NULL,
	apemat VARCHAR(30) NOT NULL,
	curp VARCHAR(18) NOT NULL);
GO
CREATE TABLE Historial(
	id INT Identity(0,1) PRIMARY KEY NOT NULL,
	cliente INT NOT NULL CONSTRAINT fk_historial_tiene_cliente REFERENCES Cliente,
	Personal INT NOT NULL CONSTRAINT fk_historial_tiene_Personal REFERENCES Personal, 
	habitacion INT NOT NULL CONSTRAINT fk_historial_tiene_habitacion REFERENCES Habitacion,
	pagoPorDia SMALLMoney NOT NULL,
	montoTotal SMALLMoney NOT NULL,
	fechaInicio DATE NOT NULL,
	fechaFinal DATE);

/* usuarios*/
	/* Gerente*/
INSERT INTO Personal VALUES (0,'Nicolas','Moreno','Durán','niconi','niconi','MODN000821HPLRRCA7');
	/* Personal*/
INSERT INTO Personal VALUES (1,'Francisto Enrique','Alberto','Cordova','francisco','francisco','MODN000821HPLRRCA7');

/* Direcciones*/
	/* Gerente*/
INSERT INTO DIreccion VALUES (0,'Teziutlán','Santa Rosa','Reforma','66',null,'Una cuadra arriba de la primaria','73887');
	/* Personal*/
INSERT INTO DIreccion VALUES (1,'yolo','yolo2','yolo3','1',null,'Yolo4','73880');

/* Telefonos*/
	/* Gerente*/
INSERT INTO Telefono VALUES ('Personal','231-140-5938',0);
	/* Personal*/
INSERT INTO Telefono VALUES ('Personal','231-111-5938',1);

/* Pisos*/
INSERT INTO Piso VALUES(1);
INSERT INTO Piso VALUES(2);
INSERT INTO Piso VALUES(3);
INSERT INTO Piso VALUES(4);
INSERT INTO Piso VALUES(5);


/* Habitaciones*/
	/* Piso 1*/
INSERT INTO Habitacion VALUES(101,'Disponible','Individual',500.00,0);
INSERT INTO Habitacion VALUES(102,'Disponible','Doble',1000.00,0);
INSERT INTO Habitacion VALUES(103,'Mantenimiento','Individual',500.00,0);
INSERT INTO Habitacion VALUES(104,'Disponible','Doble',1000.00,0);
INSERT INTO Habitacion VALUES(105,'Disponible','Triple',1500.00,0);
INSERT INTO Habitacion VALUES(106,'Disponible','Individual',500.00,0);
INSERT INTO Habitacion VALUES(107,'Mantenimiento','Individual',500.00,0);
INSERT INTO Habitacion VALUES(108,'Disponible','Doble',1000.00,0);
INSERT INTO Habitacion VALUES(109,'Disponible','Individual',500.00,0);
INSERT INTO Habitacion VALUES(110,'Mantenimiento','Triple',1500.00,0);
	/* Piso 2*/
INSERT INTO Habitacion VALUES(201,'Mantenimiento','Individual',500.00,1);
INSERT INTO Habitacion VALUES(202,'Disponible','Doble',1000.00,1);
INSERT INTO Habitacion VALUES(203,'Mantenimiento','Individual',500.00,1);
INSERT INTO Habitacion VALUES(204,'Disponible','Doble',1000.00,1);
INSERT INTO Habitacion VALUES(205,'Mantenimiento','Triple',1500.00,1);
INSERT INTO Habitacion VALUES(206,'Disponible','Individual',500.00,1);
INSERT INTO Habitacion VALUES(207,'Mantenimiento','Individual',500.00,1);
INSERT INTO Habitacion VALUES(208,'Disponible','Doble',1000.00,1);
INSERT INTO Habitacion VALUES(209,'Disponible','Individual',500.00,1);
INSERT INTO Habitacion VALUES(210,'Mantenimiento','Triple',1500.00,1);
	/* Piso 3*/
INSERT INTO Habitacion VALUES(301,'Disponible','Individual',500.00,2);
INSERT INTO Habitacion VALUES(302,'Disponible','Doble',1000.00,2);
INSERT INTO Habitacion VALUES(303,'Disponible','Individual',500.00,2);
INSERT INTO Habitacion VALUES(304,'Disponible','Doble',1000.00,2);
INSERT INTO Habitacion VALUES(305,'Disponible','Triple',1500.00,2);
INSERT INTO Habitacion VALUES(306,'Disponible','Individual',500.00,2);
INSERT INTO Habitacion VALUES(307,'Disponible','Individual',500.00,2);
INSERT INTO Habitacion VALUES(308,'Disponible','Doble',1000.00,2);
INSERT INTO Habitacion VALUES(309,'Disponible','Individual',500.00,2);
INSERT INTO Habitacion VALUES(310,'Mantenimiento','Triple',1500.00,2);
	/* Piso 4*/
INSERT INTO Habitacion VALUES(401,'Disponible','Individual',500.00,3);
INSERT INTO Habitacion VALUES(402,'Mantenimiento','Doble',1000.00,3);
INSERT INTO Habitacion VALUES(403,'Mantenimiento','Individual',500.00,3);
INSERT INTO Habitacion VALUES(404,'Mantenimiento','Doble',1000.00,3);
INSERT INTO Habitacion VALUES(405,'Mantenimiento','Triple',1500.00,3);
INSERT INTO Habitacion VALUES(406,'Mantenimiento','Individual',500.00,3);
INSERT INTO Habitacion VALUES(407,'Mantenimiento','Individual',500.00,3);
INSERT INTO Habitacion VALUES(408,'Mantenimiento','Doble',1000.00,3);
INSERT INTO Habitacion VALUES(409,'Mantenimiento','Individual',500.00,3);
INSERT INTO Habitacion VALUES(410,'Mantenimiento','Triple',1500.00,3);
	/* Piso 5*/
INSERT INTO Habitacion VALUES(501,'Disponible','Individual',500.00,4);
INSERT INTO Habitacion VALUES(502,'Disponible','Doble',1000.00,4);
INSERT INTO Habitacion VALUES(503,'Disponible','Individual',500.00,4);
INSERT INTO Habitacion VALUES(504,'Disponible','Doble',1000.00,4);
INSERT INTO Habitacion VALUES(505,'Disponible','Triple',1500.00,4);
INSERT INTO Habitacion VALUES(506,'Disponible','Individual',500.00,4);
INSERT INTO Habitacion VALUES(507,'Disponible','Individual',500.00,4);
INSERT INTO Habitacion VALUES(508,'Disponible','Doble',1000.00,4);
INSERT INTO Habitacion VALUES(509,'Disponible','Individual',500.00,4);
INSERT INTO Habitacion VALUES(510,'Disponible','Triple',1500.00,4);

select * from personal;
select * from Direccion;
SELECT * FROM Telefono;
SELECT * FROM Habitacion;
SELECT * FROM Piso;
SELECT * FROM Cliente;
SELECT * FROM Historial;

SELECT 
	Cliente.id,
	Cliente.nombre, 
	Cliente.apepat, 
	Cliente.apemat, 
	Cliente.curp, 
	Habitacion.numero,
	Historial.pagoPorDia,
	Historial.fechaInicio
	FROM Historial 
	INNER JOIN Cliente ON Historial.Cliente = Cliente.id
	INNER JOIN Habitacion ON Historial.habitacion = Habitacion.id
	WHERE Historial.fechaFinal IS NULL;

		Delete from Historial;
		Delete from Cliente;
		UPDATE Habitacion set estatus ='DIsponible';
	
	USE OUTDOOR;
	USE Hotelera_ROBAL_MAR;
	Drop database Hotelera_ROBAL_MAR;
	