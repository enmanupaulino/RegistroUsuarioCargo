create database RegistroUsuarioDb
GO

Use RegistroUsuarioDb

create table Usuarios
(
 UsuarioId int primary key identity ,
 Nombres varchar (50),
 Email varchar (50),
 NivelUsuario varchar (50),
 Usuario varchar (20) unique,
 Clave varchar (20),
 FechaIngreso datetime


)
go

create table Cargos(
CargoId int primary key identity,
Descripcion varchar (30)
)
go
