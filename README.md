Teste-Avacon

Descrição do Sistema
	Criar um Webservice(em C#), com 4 métodos, inclusão, alteração, exclusão e Consulta, de um cliente;
    O cliente possui, CPF ou CNPJ, Nome, endereço, número, cep, bairro, cidade, UF, país, telefone;
    Aceitar somente CPF e CNPJ válidos;
    Os campos CPF ou CNPJ e Nome, são obrigatórios;

Dados Técnicos
	Linguagem: C#
	Ferramenta de desenvolvimento: Microsoft Visual Studio Professional 2013
	Arquiterura: ASP.NET MVC 5
	Framework: .NET Framework 4.5

Realização de Testes
	Testes realizados no Google Chrome

Instalação
	1. Faça download do arquivo zip: Teste-Avacon.zip.
	2. Descompacte num diretório preferencial. 
	3. Abrir os arquivos WebAppCliente.sln (solução) e o WcfServiceCliente.sln no Microsoft Visual Studio Professional 2013
	4. Rodar o script de banco (scrip_create_table_cliente.sql) para criar a tabela RegistrationTable
	5. Execute-o com o comando Run. (http://localhost:49351/Cliente.aspx) 
	
Observação
	Para testar o WcfServiceCliente standalone basta abrir o IIS (Internet Information Service) e configurá-lo.
	1. Não foi possível criar um "pacote de instalação" já que é uma aplicação Web.
	2. Criei e testei no meu banco SQl Server local. Favor verificar o script de criação de banco para que possa funcionar corretamente.
	
	
