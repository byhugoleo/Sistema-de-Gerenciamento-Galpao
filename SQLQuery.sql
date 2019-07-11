create table lote(
	numero int not null primary key,
	quantidadeaves int,
	fasecrescimento varchar(22), 
	pesomedio decimal(2,2),
	mortalidade int
);

create table contas_receber(
	idcontareceber int not null identity(1, 1) primary key,
	valor decimal(6, 2) not null,
	parcela int not null,
	datainicial date not null default getdate(),
	situacao varchar(11) not null
);

create table contas_pagar(
	idcontapagar int not null identity(1, 1) primary key,
	valor decimal(6, 2) not null,
	parcela int not null,
	datainicial date not null default getdate(),
	situacao varchar(11) not null
);

create table venda(
	idvenda int not null identity(1, 1) primary key,
	valorunitario decimal(3, 2) not null,
	quantidade int not null,
	data smalldatetime not null default current_timestamp,
	idcontareceber int not null,
	idcliente int not null,
	nlote int not null,
	foreign key(idcontareceber) references contas_receber(idcontareceber),
	foreign key(nlote) references lote(numero),
);

create table compra(
	idcompra int not null identity(1, 1) primary key,
	valorunitario decimal(3, 2) not null,
	quantidade int not null,
	data smalldatetime not null default current_timestamp,
	idcontapagar int not null,
	nlote int not null,
	foreign key(idcontapagar) references contas_pagar(idcontapagar),
	foreign key(nlote) references lote(numero)
);

create table produto(
	codigo int not null primary key,
	descricao varchar(50) not null,
	fornecedor varchar(30) not null
);

create table compra_produto(
	idcompra int not null,
	codigo int not null,
	primary key(idcompra, codigo),
	foreign key(idcompra) references compra(idcompra),
	foreign key(codigo) references produto(codigo)
);

create table movimentacao(
	idmovimentacao int not null identity(1, 1) primary key,
	data date not null default getdate(),
	valor decimal(7,2) not null,
	tipo varchar(10) not null,
	idcontapagar int not null,
	idcontareceber int not null,
	foreign key(idcontapagar) references contas_pagar(idcontapagar),
	foreign key(idcontareceber) references contas_receber(idcontareceber)
);

create table cliente(
	idcliente int not null identity(1, 1) primary key,
	nome varchar(36) not null unique,
	estado varchar(6) not null,
	cidade varchar(30) not null,
	rua varchar(55) not null,
	numero int not null,
	bairro varchar(20) not null,
	cpf varchar(13) unique,
	cnpj varchar(15) unique
);

ALTER TABLE VENDA ADD CONSTRAINT FK_IDCLIENTE FOREIGN KEY(IDCLIENTE) REFERENCES CLIENTE(IDCLIENTE)