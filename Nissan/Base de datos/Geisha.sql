create database Geisha
use Geisha

create table usuarios(
usuario varchar(30) primary key not null,
passw varchar(30) not null,
rol varchar(30) not null
)

create table datos(
idvin int identity(1,1) primary key,
descripcion varchar(60) not null,
cuota int not null,
cabecera varchar(6) not null,
vin varchar(18) not null,
motor varchar(12) not null,
colext varchar(3) not null
)

create table clientes(
idcliente int identity(1,1) primary key,
nombre varchar(30) not null,
apellidop varchar(30) not null,
apellidom varchar(30) not null,
direccion varchar(30) not null,
correo varchar(30) not null,
numero varchar(15) not null,
)

create table ventas(
idventa int identity(1,1) primary key,
usuario varchar(30) not null,
idvin int not null,
idcliente int not null,
fechapromesa date not null,
foreign key (usuario) references usuarios(usuario),
foreign key (idvin) references datos(idvin),
foreign key (idcliente) references clientes(idcliente)
)

create table accesorios(
idaccesorio int identity(1,1) primary key,
idvin int not null,
accesorio varchar(60) not null,
estatus varchar(30) not null,
fechapromesa date not null,
foreign key (idvin) references datos(idvin)
)

create table tramites(
idtramite int identity(1,1) primary key,
idvin int not null,
tramite varchar(60) not null,
estatus varchar(30) not null,
fechapromesa date not null,
foreign key (idvin) references datos(idvin)
)

create table preparacion(
idpreparacion int identity(1,1) primary key,
idvin int not null,
preparacion varchar(60) not null,
estatus varchar(30) not null,
fechapromesa date not null,
foreign key (idvin) references datos(idvin)
)
create table estatusfinal(
idestatus int identity(1,1) primary key,
idvin int not null, 
estatus varchar(30) not null, 
porcentaje int not null
foreign key (idvin) references datos(idvin)
)



insert into usuarios values('Danis','danis123','admin');
insert into usuarios values('Omar','omar123','apv');