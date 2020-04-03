--Creación de la base de datos

create database Geisha
use Geisha

create table Vin(
vin  varchar(18) primary key,
descripcion varchar(60) not null,
cuota int not null,
cabecera varchar(6) not null,
motor varchar(12) not null,
colext varchar(3) not null,
estatus varchar(20)check(estatus='Entregado' or estatus='En proceso' or estatus='No iniciado')default'No iniciado'not null
)
create table Ventanilla(
idventanilla int identity(1,1) primary key,
nombre varchar(50) not null
)
create table APV(
idapv int identity(1,1) primary key,
nombres varchar(50),
apellido_materna varchar(50),
apellido_paterno varchar(50)
)
create table Tramite(
nombre varchar(100) primary key,
estatus varchar(20)check(estatus='Terminado' or estatus='En proceso' or estatus='No iniciado')default'No iniciado' not null,
idventanilla int not null,
encargado varchar(50) not null,
fecha date not null,
vin varchar(18) not null,
observacion varchar(100),
foreign key (vin) references Vin(vin),
foreign key (idventanilla) references Ventanilla(idventanilla)
)
create table Accesorios(
idaccesorio int identity(1,1) primary key,
vin varchar(18) not null,
accesorio varchar(60) not null,
idventanilla int not null,
encargado varchar(50) not null,
estatus varchar(30) check(estatus='Terminado' or estatus='En proceso' or estatus='No iniciado') default'No iniciado' not null,
fechapromesa date not null,
observacion varchar(100),
foreign key (vin) references Vin(vin),
foreign key (idventanilla) references Ventanilla(idventanilla)
)
create table Preparacion(
preparacion varchar(60) primary key,
vin varchar(18) not null,
idventanilla int not null,
encargado varchar(50) not null,
estatus varchar(30)check(estatus='Terminado' or estatus='En proceso' or estatus='No iniciado')default'No iniciado' not null,
fechapromesa date not null,
observacion varchar(100),
foreign key (vin) references Vin(vin),
foreign key (idventanilla) references Ventanilla(idventanilla)
)
create table Venta(
idventa varchar(60) primary key,
idapv int not null,
vin varchar(18) not null,
fechapromesa date not null,
clente varchar(100) not null,
foreign key (idapv) references APV(idapv),
foreign key (vin) references Vin(vin)
)
create table sesion(
usuario varchar(30) primary key,
contraseña varchar(30) not null,
roles varchar(30) not null
)

create table acceso(
fecha date primary key,
usuario varchar(30) not null,
foreign key (usuario) references sesion(Usuario)
)

--Inserts

insert sesion values('juan','1234','Administrador')
insert sesion values('dani','1234','Ventanilla unica')
insert sesion values('omar','1234','apv')
insert sesion values('ivan','1234','gerente de ventas')
--insert sesion values('jose','1234','Mecannico')

--Store procedure´s


--Extras
select * from sesion
select * from sesion where usuario='juan' and contraseña='1234'
