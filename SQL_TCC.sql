create database tcc_Oficina

use tcc_Oficina

create table tcc_Cliente(
	idCliente integer primary key NOT NULL identity(1,1),
	nome nvarchar(60),
	documentoSocial nvarchar(14),
	telefone nvarchar(11),
	email nvarchar(60),
	--endereco--
	logradouro nvarchar(30),
	numero nvarchar(10),
	bairro nvarchar(30),
	cidade nvarchar(30),
	UF nvarchar(2),
	complemento nvarchar(30),
	CEP nvarchar(8)
)

create table tcc_Carro(
	idCarro integer primary key NOT NULL identity(1,1),
	idCliente integer,
	modelo nvarchar(20),
	ano nvarchar(4),
	cor nvarchar(20),
	placa nvarchar(7),
	quilometros nvarchar(15)
)

--chave estrangeira do carro--
alter table Tcc_Carro
add constraint idCliente
foreign key(idCliente) references tcc_Cliente(idCliente)

create table tcc_Mecanico(
	idMecanico integer primary key NOT NULL identity(1,1),
	razaoSocial nvarchar(50),
	CNPJ nvarchar(14),
	IE nvarchar(20),
	telefone nvarchar(11),
	email nvarchar(60),
	--endereco--
	logradouro nvarchar(30),
	numero nvarchar(10),
	bairro nvarchar(30),
	cidade nvarchar(30),
	UF nvarchar(2),
	complemento nvarchar(30),
	CEP nvarchar(8)
)

create table tcc_Produto(
	idProduto integer primary key NOT NULL identity(1,1),
	descricao nvarchar(50),
	quantidade integer,
	precoCompra float,
	precoVenda float
)

create table tcc_Orcamento(
	idOrcamento integer primary key NOT NULL identity(1,1),

)

--inserts e selects

insert into tcc_Cliente
values('alex','46304768818','15998394298','alex.bilesck@gmail.com','rua jossei toda','236','wanel ville','sorocaba','sp','casa 34','18055037');

select * from tcc_Cliente

insert into tcc_Carro
values(1,'freemont','2012','preto','oei5565','74000');

select * from tcc_Carro

insert into tcc_Mecanico
values('Alex','01234567891234','12345678900123456789','15998394298','alex.bilesck@gmail.com','rua jossei toda','236','wanel ville','sorocaba','sp','casa 34','18055037');

select * from tcc_Mecanico

insert into tcc_Produto
values('oleo',5,15,30);

select * from tcc_Produto