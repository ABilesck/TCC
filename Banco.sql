--create database tcc_Oficina
-- use tcc_Oficina

create table tcc_Cliente(
	IDCliente integer primary key NOT NULL identity(1,1),
	nome nvarchar(MAX),
	documentoSocial nvarchar(15),
	telefone nvarchar(11),
	email nvarchar(MAX),
	--ENDERECO--
	logradouro nvarchar(30),
	bairro nvarchar(30),
	cidade nvarchar(MAX),
	complemento nvarchar(30),
	uf nvarchar(2),
	cep nvarchar(8)
)

create table tcc_Automovel(
	IDAutomovel integer primary key NOT NULL identity(1,1),
	IDCliente integer, -- foreign key
	placa nvarchar(7),
	modelo nvarchar(30),
	ano nvarchar(4),
	cor nvarchar(30),
	kmRodado nvarchar(10)
)

create table tcc_Mecanico(
	IDMecanico integer primary key NOT NULL identity(1,1),
	razaoSocial nvarchar(MAX),
	cnpj nvarchar(15),
	ie nvarchar(15),
	telefone nvarchar(11),
	email nvarchar(MAX),
	contaBancaria nvarchar(10),
	agenciaBancaria nvarchar(10),
	comissao integer,
	--ENDERECO--
	logradouro nvarchar(30),
	bairro nvarchar(30),
	cidade nvarchar(MAX),
	complemento nvarchar(30),
	uf nvarchar(2),
	cep nvarchar(8)
)

create table tcc_Produto(
	IDProduto integer primary key NOT NULL identity(1,1),
	descricao nvarchar(MAX),
	quantidade integer,
	precoVenda float,
	precoCompra float
)

create table tcc_Orcamento(
	IDOrcamento integer primary key NOT NULL identity(1,1),
	dataConsulta datetime,
	IDAutomovel integer,  -- foreign key
)

create table tcc_produtoOrcamento(
	IDOrcamento integer, -- foreign key
	IDProduto integer, -- foreign key
	quantidade integer,
	precoUnitario float,
	primary key(IDOrcamento, IDProduto)
)

create table tcc_Servico(
	IDMecanico integer, -- foreign key
	IDOrcamento integer, -- foreign key
	dataInicio datetime,
	dataFim datetime,
	primary key(IDMecanico, IDOrcamento)
)

--relacionamento cliente-automovel
alter table tcc_Automovel
add constraint IDCliente
foreign key (IDCliente) references tcc_Cliente(IDCliente)

--relacionamento carro-or�amento
alter table tcc_Orcamento
add constraint IDAutomovel
foreign key (IDAutomovel) references tcc_Automovel(IDAutomovel)

--relacionamento orcamento-prdutoOr�amento-produto
alter table tcc_produtoOrcamento
add constraint IDOrcamento
foreign key (IDOrcamento) references tcc_Orcamento(IDOrcamento)

alter table tcc_produtoOrcamento
add constraint IDProduto
foreign key (IDProduto) references tcc_Produto(IDProduto)

--relacionamento or�amento - servi�o - mecanico
alter table tcc_Servico
add constraint IDMecanico
foreign key (IDMecanico) references tcc_Mecanico(IDMecanico)

alter table tcc_Servico
add constraint IDOrcamento
foreign key (IDOrcamento) references tcc_Orcamento(IDOrcamento)