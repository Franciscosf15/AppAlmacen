use master
go
if exists (select * from sysdatabases where name = 'BdAbarrotes')
	drop database BdAbarrotes
go
create database BdAbarrotes
go

-------------------------CREACION DE TABLAS-----------------------------
use BdAbarrotes
go
------- Tabla: TProducto -----------
create table TProducto
( --- lista de atributos
	CodProducto varchar (10) not null,
	Descripcion varchar (50) not null,
	Unidad varchar (20) not null,
	Marca varchar (20) not null,
	Stock int not null,
	Precio float not null,

	----- Determinacion de las claves
	primary key (CodProducto)
)
go

create table TUsuario
( --- lista de atributos
	IdUsuario varchar (20) not null,
	Nombres varchar (50) not null,
	Contraseña varchar (20) not null,
	NivelAcceso int not null,
	Habilitado varchar(2) not null,

	----- Determinacion de las claves
	primary key (IdUsuario)
)
go

create table TBoleta
( --- lista de atributos
	NroBoleta varchar (10) not null,
	Cliente varchar (50) not null,
	Fecha datetime not null,
	IdUsuario varchar (20) not null,

	----- Determinacion de las claves
	primary key (NroBoleta),
	foreign key (IdUsuario) references TUsuario
)
go

create table TDetalleBoleta
( --- lista de atributos
	NroBoleta varchar (10) not null,
	CodProducto varchar (10) not null,
	Cantidad int not null,
	Precio float not null,

	----- Determinacion de las claves
	primary key (NroBoleta, CodProducto),
	foreign key (NroBoleta) references TBoleta,
	foreign key (CodProducto) references TProducto
)
go

------insercion de datos ejemplo----------------------------------
use BdAbarrotes
go

--- configurar formato de fecha
set dateformat 'dMy'
go 

insert into TUsuario values ('Osito','Osito','Lopiteam0','1','Si')
insert into TUsuario values ('123','osito','123','0','Si')


insert into TProducto values('P00001','ARROZ UN KILO','BOLSA','GALLITO',30,3.20)
insert into TProducto values('P00002','ARROZ MEDIO KILO','BOLSA','GALLITO',35,1.60)
insert into TProducto values('P00003','ARROZ UN KILO','BOLSA','ESPIGA DE ORO',22,3.40)
insert into TProducto values('P00004','ARROZ MEDIO KILO','BOLSA','ESPIGA DE ORO',28,1.70)
insert into TProducto values('P00005','ARROZ UN KILO','BOLSA','CAMPERO',18,4.00)
insert into TProducto values('P00006','ARROZ MEDIO KILO','BOLSA','CAMPERO',15,2.00)
insert into TProducto values('P00007','ARROZ 3/4 KILO','BOLSA','VALLE DEL NORTE',18,3.80)
insert into TProducto values('P00008','CERROCILLO UN KILO','BOLSA','SM',20,2.00)
insert into TProducto values('P00009','CERROCILLO MEDIO KILO','BOLSA','SM',20,2.00)
insert into TProducto values('P00010','HARINA FAVORITA','BOLSA','SM',16,1.20)
insert into TProducto values('P00011','HARINA PREPARADA UN KILO','BOLSA','BLANCA FLOR',10,6.50)
insert into TProducto values('P00012','HARINA PREPARADA MEDIO KILO','BOLSA','BLANCA FLOR',8,3.50)
insert into TProducto values('P00013','HARINA A GRANEL','KILOGRAMO','VICTORIA',25,3.00)
insert into TProducto values('P00014','GELATINA','BOLSA','RUBI',22,2.20)
insert into TProducto values('P00015','GELATINA','BOLSA','NEGRITA',20,3.00)
insert into TProducto values('P00016','MAZAMORRA','BOLSA','NEGRITA',15,2.20)
insert into TProducto values('P00017','AVENA 150 GR.','BOLSA','TRES OSITOS',20,1.00)
insert into TProducto values('P00018','AVENA 60 GR.','BOLSA','TRES OSITOS',20,0.50)
insert into TProducto values('P00019','AVENA QUINUA PREMIUM 170 GR.','BOLSA','TRES OSITOS',19,2.50)
insert into TProducto values('P00020','AVENA CON DHA 120 GR.','BOLSA','TRES OSITOS',16,2.00)
insert into TProducto values('P00021','AVENA CON HIERRO 150 GR.','BOLSA','TRES OSITOS',16,2.00)
insert into TProducto values('P00022','CREMA DE HABA 150 GR.','BOLSA','LA CUSQUEÑITA',12,1.50)
insert into TProducto values('P00023','CREMA DE HABA 90 GR.','BOLSA','LA CUSQUEÑITA',10,1.20)
insert into TProducto values('P00024','CREMA DE HABA 60 GR.','BOLSA','LA CUSQUEÑITA',15,0.70)
insert into TProducto values('P00025','AZUCAR UN KILO','BOLSA','CASA GRANDE',17,3.00)
insert into TProducto values('P00026','KETCHUP 100 GR.','SOBRE','ALACENA',10,1.80)
insert into TProducto values('P00027','MAYONESA 150 GR.','SOBRE','ALACENA',13,2.70)
insert into TProducto values('P00028','TARI 85 GR.','SOBRE','ALACENA',9,2.20)
insert into TProducto values('P00029','UCHUCUTA 85 GR.','SOBRE','SOBRE',11,2.00)
insert into TProducto values('P00030','SALSA DE TOMATE 160 GR.','SOBRE','NICOLINI',11,1.50)
insert into TProducto values('P00031','SALSA DE TOMATE 200 GR.','SOBRE','DON VITORIO',8,2.00)
insert into TProducto values('P00032','MAYONESA 10 CM3','SOBRE','ALACENA',10,0.40)
insert into TProducto values('P00033','MERMELADA 85 GR.','SOBRE','FANNY',14,1.20)
insert into TProducto values('P00034','MERMELADA 100 GR.','SOBRE','GLORIA',15,1.30)
insert into TProducto values('P00035','CHOCOLATE 90 GR.','SOBRE','GLORIA',20,1.30)
insert into TProducto values('P00036','MANJAR 200 GR.','SOBRE','NESTLE',15,3.80)
insert into TProducto values('P00037','CHOCOLATE 100 GR. PURO','SOBRE','CHUNCHO',10,4.00)
insert into TProducto values('P00038','CAFE 8 GR.','SOBRE','CHOLITA',30,0.30)
insert into TProducto values('P00039','CAFE ECCO 50 GR.','LATA','NESTLE',15,4.50)
insert into TProducto values('P00040','CAFE ECCO 190 GR.','LATA','NESTLE',10,8.50)
insert into TProducto values('P00041','CAFE ECCO 10 GR.','SOBRE','NESTLE',10,0.70)
insert into TProducto values('P00042','CAFE 9 GR.','SOBRE','KIRMA',18,1.00)
insert into TProducto values('P00043','CHOCOLATE PURO','SOBRE','ESTRELLA',15,1.20)
insert into TProducto values('P00044','NESCAFE TRADICION 17 GR.','SOBRE','NESTLE',20,2.00)
insert into TProducto values('P00045','NESCAFE DESCAFEINADO 7 GR.','SOBRE','NESTLE',25,1.00)
insert into TProducto values('P00046','NESCAFE ESPECIAL 8 GR.','SOBRE','NESTLE',32,1.20)
insert into TProducto values('P00047','CAFE TRADICION 9 GR.','SOBRE','NESTLE',22,1.10)
insert into TProducto values('P00048','MANTEQUILLA 90 GR.','ENVASE','MANTY',15,1.50)
insert into TProducto values('P00049','MANTEQUILLA 45 GR.','SOBRE','SELLO DE ORO',21,0.80)
insert into TProducto values('P00050','MANTEQUILLA 300 GR.','SOBRE','MANTY',10,4.50)
insert into TProducto values('P00051','MITU 18 GR.','SOBRE','NESTLE',11,1.00)
insert into TProducto values('P00052','CHAQUEPA TOSTADA','KILO','SM',14,3.80)
insert into TProducto values('P00053','QUINUA PELADA','KILO','SM',12,8.50)
insert into TProducto values('P00054','MORON','KILO','SM',10,3.80)
insert into TProducto values('P00055','CHAQUEPA SIN TOSTAR','KILO','SM',11,3.50)
insert into TProducto values('P00056','HABA MOLIDA A GRANEL','KILO','SM',12,6.00)
insert into TProducto values('P00057','MAICENA A GRANEL','KILO','SM',15,6.00)
insert into TProducto values('P00058','OJUELA DE QUINUA','KILO','SM',20,10.00)
insert into TProducto values('P00059','OJUELA DE SOYA','KILO','SM',22,10.00)
insert into TProducto values('P00060','SOYA ENTERA A GRANEL','KILO','SM',15,4.00)
insert into TProducto values('P00061','HARINA DE MORAYA','KILO','SM',18,6.00)
insert into TProducto values('P00062','HARINA DE CHUÑO','KILO','SM',10,5.00)
insert into TProducto values('P00063','CHOCOLATE NESQUIK 18 GR.','SOBRE','NESTLE',15,1.00)
insert into TProducto values('P00064','CAFE 6 GR.','SOBRE','KIRMA',25,0.80)

insert into TProducto values('P00066','PAN HUARO','UNIDAD','HUARO',30,0.20)
insert into TProducto values('P00067','PAN ESPECIAL','UNIDAD','SM',38,0.20)
insert into TProducto values('P00068','PAY DE MANZANA','UNIDAD','SM',30,0.50)
insert into TProducto values('P00069','PIONINO','UNIDAD','SM',30,0.20)
insert into TProducto values('P00070','ALFAJOR','UNIDAD','SM',34,0.50)
insert into TProducto values('P00071','OREO GRANDE','UNIDAD 230gr.','NESTLÉ',39,3.80)
insert into TProducto values('P00072','TENTACIÓN','UNIDAD 47gr.','VICTORIA',100,0.60)
insert into TProducto values('P00073','CHOMP','UNIDAD 42gr.','VICTORIA',38,0.60)
insert into TProducto values('P00074','WAFER MABELS','UNIDAD 110gr.','MABELS',31,1.20)
insert into TProducto values('P00075','WAFER MABELS','UNIDAD 46gr.','MABELS',78,0.60)
insert into TProducto values('P00076','WAFER COSTA','UNIDAD 140gr.','COSTA',30,2.00)
insert into TProducto values('P00077','GALLETAS FITNESS INTEGRAL','UNIDAD 26 gr.','NESTLÉ',30,0.20)
insert into TProducto values('P00078','GALLETAS AGUA 150','UNIDAD 150gr.','VICTORIA',78,1.30)
insert into TProducto values('P00079','GALLETAS RELLENITAS','UNIDAD 36gr.','SM',45,0.50)
insert into TProducto values('P00080','GALLETAS FIELD','UNIDAD 37gr.','SM',56,0.70)
insert into TProducto values('P00081','SODA V','UNIDAD 43gr.','VICTORIA',30,0.60)
insert into TProducto values('P00082','SODA OIA','UNIDAD 250gr.','SM',98,2.00)
insert into TProducto values('P00083','GALLETAS VAINILLA','UNIDAD 250gr.','VICTORIA',56,2.00)
insert into TProducto values('P00084','GALLETAS CREAM CRACKER´S','UNIDAD 295gr','SM',45,3.50)
insert into TProducto values('P00085','DOÑA PEPA FIELD','UNIDAD 23gr','SM',45,0.70)
insert into TProducto values('P00086','CHOCOLATE CON LECHE','UNIDAD 30gr.','DONOFRIO',39,1.50)
insert into TProducto values('P00087','SUBLIME NESTLÉ','UNIDAD 55gr.','NESTLÉ',78,2.00)
insert into TProducto values('P00088','SUBLIME NESTLÉ','UNIDAD 30gr.','NESTLÉ',30,1.50)
insert into TProducto values('P00089','CHOCOLATE PRINCESA','UNIDAD 30gr.','NESTLÉ',30,1.30)
insert into TProducto values('P00090','GALLETAS MOROCHAS','UNIDAD 30gr','NESTLÉ',30,0.80)
insert into TProducto values('P00091','CHICOTAC','UNIDAD 100ml','GLORIA',30,0.50)
insert into TProducto values('P00092','FRUGOS','UNIDAD 145ml','GLORIA',30,0.70)
insert into TProducto values('P00093','CHICOLAC','UNIDAD 180 gr.','GLORIA',30,1.20)
insert into TProducto values('P00094','TRIGO MACHACADO','UNIDAD 1KL','SM',30,3.80)
insert into TProducto values('P00095','TRIGO PELADO','UNIDAD 1KL','SM',30,3.80)
insert into TProducto values('P00096','HABA SECA','UNIDAD 1KL','SM',30,5.80)
insert into TProducto values('P00097','MAÍZ PARA TOSTAR EN GRANEL','UNIDAD 1KL','SM',89,6.00)
insert into TProducto values('P00098','LECHE DE SOYA CRUDA','UNIDAD','SM',70,5.00)
insert into TProducto values('P00099','LECHE DE SOYA TOSTADA','UNIDAD','SM',30,6.00)
insert into TProducto values('P00100','PAPA MAQTILLO','UNIDAD 1KL','SM',30,2.20)
insert into TProducto values('P00101','PAPA AMARILLA','UNIDAD 1KL','SM',30,3.20)
insert into TProducto values('P00102','PAPA CANCHAN','UNIDAD 1KL','SM',30,2.00)
insert into TProducto values('P00103','CEBOLLA 1KL','UNIDAD','SM',38,2.50)
insert into TProducto values('P00104','ZANAHORIA 1KL','UNIDAD','SM',78,1.50)
insert into TProducto values('P00105','PEPINO','UNIDAD','SM',30,1.00)
insert into TProducto values('P00106','ARBEJA 1KL','UNIDAD','SM',30,4.00)
insert into TProducto values('P00107','HABA VERDE 1KL','UNIDAD','SM',78,2.00)
insert into TProducto values('P00108','ROCOTO','UNIDAD','SM',30,0.30)
insert into TProducto values('P00109','LIMON','UNIDAD','SM',30,0.20)
insert into TProducto values('P00110','KION 1KL','UNIDAD','SM',30,10.00)
insert into TProducto values('P00111','ZAPALLO 1KL','UNIDAD','SM',30,2.50)
insert into TProducto values('P00112','PLATANO 4X1','UNIDAD','SM',30,1.00)
insert into TProducto values('P00113','PLATANO','UNIDAD','SM',30,0.30)
insert into TProducto values('P00114','PLATANO DE FREIR','UNIDAD','SM',30,0.50)
insert into TProducto values('P00115','PALTA 1KL','UNIDAD','SM',30,8.00)
insert into TProducto values('P00116','PAPAYA 1KL','UNIDAD','SM',30,3.50)
insert into TProducto values('P00117','MANZANA VERDE','UNIDAD','SM',45,3.50)
insert into TProducto values('P00118','POCKOR 1KL','UNIDAD','SM',30,5.00)
insert into TProducto values('P00119','MANZANA ISRAEL','UNIDAD','SM',30,5.00)
insert into TProducto values('P00120','CHANCACA','UNIDAD','SM',30,0.50)


select * from TBoleta