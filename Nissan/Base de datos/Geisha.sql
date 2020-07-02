drop database Geisha
--Creación de la base de datos

create database Geisha
use Geisha


create table Vin(
vin  varchar(25) primary key,
descripcion varchar(60) not null,
cuota int not null,
cabecera varchar(25) not null,
motor varchar(25) not null,
colext varchar(25) not null,
estatus varchar(25)check(estatus='Entregado' or estatus='En proceso' or estatus='No iniciado')default'No iniciado'not null
)

-------------------------

create table Ventanilla(
idventanilla int identity(1,1) primary key,
nombre varchar(80) unique not null,
contraseña varchar(30) not null,
roles varchar(30) not null
)

create table Asesor(
idapv int primary key,
nombres varchar(80) not null,
contraseña varchar(30) not null,
roles varchar(30) not null
)
drop table Asesor
select * from Asesor


create table Asesor2(
idapv int primary key,
nombres varchar(80) not null,
)
select * from Asesor2
drop table Asesor2

create table OperadorVentanilla(
idope int identity(1,1) primary key,
nombres varchar(80) unique not null,
contraseña varchar(30) not null,
roles varchar(30) not null
)

create table SAccesorios(
idaccesorios int identity(1,1) primary key,
nombres varchar(80) unique not null,
contraseña varchar(30) not null,
roles varchar(30) not null
)

create table Tramites(
idtramites int identity(1,1) primary key,
nombres varchar(80) unique not null,
contraseña varchar(30) not null,
roles varchar(30) not null
)

create table Operarios(
idoperarios int identity(1,1) primary key,
nombres varchar(80) unique not null,
contraseña varchar(30) not null,
roles varchar(30) not null
)

create table sesion(
idsesion int identity(1,1) primary key,
usuario varchar(80) not null,
contraseña varchar(30) not null,
roles varchar(30) not null
)
drop table sesion

create table acceso(
fecha date primary key,
usuario varchar(30) not null,
foreign key (usuario) references sesion(Usuario)
)
drop table acceso
-----------------------------------------
create table Tramite(
nombre varchar(100) primary key,
estatus varchar(20)check(estatus='Terminado' or estatus='En proceso' or estatus='No iniciado')default'No iniciado' not null,
idope int not null,
encargado varchar(50) not null,
fecha date not null,
vin varchar(25) not null,
observacion varchar(100),
foreign key (vin) references Vin(vin),
foreign key (idope) references OperadorVentanilla(idope)
)

create table Accesorios(
idaccesorio int identity(1,1) primary key,
vin varchar(25) not null,
accesorio varchar(60) not null,
idope int not null,
encargado varchar(50) not null,
estatus varchar(30) check(estatus='Terminado' or estatus='En proceso' or estatus='No iniciado') default'No iniciado' not null,
fechapromesa date not null,
observacion varchar(100),
foreign key (vin) references Vin(vin),
foreign key (idope) references OperadorVentanilla(idope)
)

create table Preparacion(
preparacion varchar(60) primary key,
vin varchar(25) not null,
idope int not null,
encargado varchar(50) not null,
estatus varchar(30)check(estatus='Terminado' or estatus='En proceso' or estatus='No iniciado')default'No iniciado' not null,
fechapromesa date not null,
observacion varchar(100),
foreign key (vin) references Vin(vin),
foreign key (idope) references OperadorVentanilla(idope)
)

create table Venta(
idventa varchar(60) primary key,
idapv int not null,
vin varchar(25) not null,
fechapromesa date not null,
clente varchar(100) not null,
foreign key (idapv) references Asesor(idapv),
foreign key (vin) references Vin(vin)
)
drop table Venta

--Inserts sesion
insert sesion values('juan','1234','Administrador')
insert sesion values('dani','1234','Ventanilla unica')
insert sesion values('omar','1234','apv')
insert sesion values('ivan','1234','gerente de ventas')
insert sesion values('templos','1234','Operador Ventanilla Unica')
--insert sesion values('jose','1234','Mecannico')

--insert Operador de Ventanilla
insert OperadorVentanilla values('templos','1234','Operador Ventanilla Unica')


--Store procedure´s


--Extras
select * from OperadorVentanilla
select * from sesion
select * from sesion where usuario='juan' and contraseña='1234'

select * from Vin

select * from Asesor
select * from sesion