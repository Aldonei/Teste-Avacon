CREATE TABLE dbo.RegistrationTable
(
	Id int NOT NULL IDENTITY (1, 1),
	Nome varchar(80) NOT NULL,
	CpfCnpj varchar(14) NOT NULL,
	Telefone varchar(20) NULL,
	Logradouro varchar(80) NULL,
	Numero varchar(10) NULL,
	Cep varchar(8) NULL,
	Bairro varchar(80) NULL,
	Cidade varchar(80) NULL,
	Uf char (2) NULL,
	Pais varchar(80) NULL
)  ON [PRIMARY]
