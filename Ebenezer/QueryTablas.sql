create database Ebenezer;
use Ebenezer;

create table Cliente 
(
	Fecha date,
	Cliente varchar(200),
	NitCc varchar(20) unique,
	Direccion varchar(max),
	Contacto varchar(200),
	Telefonos varchar(50),
	Correo varchar(max),
	Notas varchar(max),

	ClienteId int identity(1, 1) primary key,

	UsuarioLog varchar(20),
	FechaLog datetime default getdate()
);

create table Vehiculo
(
	Fecha date,
	Placa varchar(10) unique,
	Marca varchar(50),
	Modelo varchar(50),
	Garantia date,
	Notas varchar(max),

	VehiculoId int identity(1, 1) primary key,
	ClienteId int foreign key references Cliente(ClienteId),

	UsuarioLog varchar(20),
	FechaLog datetime default getdate()
);

create table VehiculoMantenimiento
(
	Fecha date,
	Tipo varchar(50),
	PorGarantia varchar(50),
	Actividades varchar(max),
	Notas varchar(max),
	Usuario varchar(20),

	VehiculoMantenimientoId int identity(1, 1) primary key,
	VehiculoId int foreign key references Vehiculo(VehiculoId),

	FechaLog datetime default getdate()
);

create table Usuario
(
	Usuario varchar(20) unique,
	Contraseña varchar(10),
	Nombres varchar(200),	
	Rol varchar(20),

	UsuarioId int identity(1, 1) primary key
);

Create View VehiculoView
As
SELECT 
	Cliente, Cliente.ClienteId,
	Vehiculo.Fecha, Placa, Marca, Modelo, Garantia, Vehiculo.Notas, VehiculoId, Vehiculo.UsuarioLog
FROM 
	Cliente 
		INNER JOIN
	Vehiculo
		ON
	Cliente.ClienteId = Vehiculo.ClienteId

CREATE VIEW VehiculoMantenimientoView
AS
SELECT 
	Cliente.Cliente, Cliente.ClienteId,
	Vehiculo.Placa, Vehiculo.VehiculoId, Vehiculo.Garantia,
	VehiculoMantenimiento.Fecha, Tipo, VehiculoMantenimiento.PorGarantia, Actividades, VehiculoMantenimiento.Notas, Usuario, VehiculoMantenimientoId, VehiculoMantenimiento.FechaLog
FROM 
	Cliente
		INNER JOIN
	Vehiculo
		ON
	Cliente.ClienteId = Vehiculo.ClienteId
		INNER JOIN
	VehiculoMantenimiento
		ON
	Vehiculo.VehiculoId = VehiculoMantenimiento.VehiculoId

	select * from VehiculoMantenimientoView;

DELETE FROM VehiculoMantenimiento;
DELETE FROM Vehiculo;
DELETE FROM Cliente;
DELETE FROM Usuario;

DBCC CHECKIDENT (VehiculoMantenimiento, RESEED, 0);
DBCC CHECKIDENT (Vehiculo, RESEED, 0);
DBCC CHECKIDENT (Cliente, RESEED, 0);
DBCC CHECKIDENT (Usuario, RESEED, 0);

select * from Usuario;
