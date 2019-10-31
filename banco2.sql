use tcc_OficinaMecanica

delete from tcc_Automovel
delete from tcc_Cliente
delete from tcc_Mecanico
delete from tcc_Orcamento
delete from tcc_Produto
delete from tcc_produtoOrcamento
delete from tcc_Servico

drop table tcc_Automovel
drop table tcc_Cliente
drop table tcc_Mecanico
drop table tcc_Orcamento
drop table tcc_Produto
drop table tcc_produtoOrcamento
drop table tcc_Servico

create table tcc_Cliente(
	IDCliente integer primary key NOT NULL identity(1,1),
	nome nvarchar(MAX),
	documentoSocial nvarchar(15),
	telefone nvarchar(11),
	email nvarchar(MAX),
	--ENDERECO--
	logradouro nvarchar(30),
	numero nvarchar(5),
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
	fantasia nvarchar(MAX),
	cnpj nvarchar(15),
	ie nvarchar(15),
	telefone nvarchar(11),
	email nvarchar(MAX),
	contaBancaria nvarchar(10),
	agenciaBancaria nvarchar(10),
	comissao integer,
	--ENDERECO--
	logradouro nvarchar(30),
	numero nvarchar(5),
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
	precoUnit float
)

create table tcc_Orcamento(
	IDOrcamento integer primary key NOT NULL identity(1,1),
	dataConsulta datetime,
	IDAutomovel integer,  -- foreign key
)

create table tcc_produtoOrcamento(
	IDOrcamento integer, -- foreign key
	IDProduto integer, -- foreign key
	quantidadeVenda integer,
	precoUnitario float,
	primary key(IDOrcamento, IDProduto)
)

create table tcc_Servico(
	IDMecanico integer, -- foreign key
	IDOrcamento integer, -- foreign key
	dataInicio datetime,
	dataFim datetime,
	obs ntext,
	desconto float,
	notaFiscal nvarchar(MAX),
	primary key(IDMecanico, IDOrcamento)
)

alter table tcc_Servico
add constraint IDOrcamento
foreign key (IDOrcamento) references tcc_Orcamento(IDOrcamento)

--relacionamento cliente-automovel
alter table tcc_Automovel
add constraint IDCliente
foreign key (IDCliente) references tcc_Cliente(IDCliente)

--relacionamento carro-orçamento
alter table tcc_Orcamento
add constraint IDAutomovel
foreign key (IDAutomovel) references tcc_Automovel(IDAutomovel)

--relacionamento orcamento-prdutoOrçamento-produto
alter table tcc_produtoOrcamento
add constraint IDOrcamento
foreign key (IDOrcamento) references tcc_Orcamento(IDOrcamento)

alter table tcc_produtoOrcamento
add constraint IDProduto
foreign key (IDProduto) references tcc_Produto(IDProduto)

--relacionamento orçamento - serviço - mecanico
alter table tcc_Servico
add constraint IDMecanico
foreign key (IDMecanico) references tcc_Mecanico(IDMecanico)

alter table tcc_Servico
add constraint IDOrcamento
foreign key (IDOrcamento) references tcc_Orcamento(IDOrcamento)