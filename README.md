# Sistema de Venda de Produtos - [Nome do Projeto]

Este projeto é um sistema web de venda de produtos desenvolvido com C# no Visual Studio 2022, utilizando o padrão MVC (Model-View-Controller). O sistema oferece funcionalidades completas para gerenciar clientes, fornecedores, produtos e vendas.

## Funcionalidades

**Gerenciamento de Cadastros:**

* **Clientes:** Cadastro completo com nome, CPF/CNPJ, endereço, telefone, email e status (ativo/inativo). Edição e exclusão de registros. Busca por clientes.
* **Fornecedores:** Cadastro com nome da empresa, CNPJ, endereço, telefone e email. Edição e exclusão de registros. Busca por fornecedores.
* **Produtos:** Cadastro com nome, descrição, preço, quantidade em estoque e associação com fornecedores. Edição e exclusão de registros. Busca por produtos.

**Gerenciamento de Vendas:**

* **Emissão de Vendas:** Seleção do cliente e dos produtos. Cálculo automático do valor total da venda. Registro da data de emissão. Visualização e edição de vendas.

**Funcionalidades Bônus (Opcionais):**

* **Autenticação e Controle de Acesso:** Sistema de login para controlar o acesso a funcionalidades específicas.
* **Relatório de Vendas:** Gerar relatórios de vendas em um período específico, incluindo o total faturado.
* **Controle de Estoque:** Atualização automática do estoque com base nas vendas registradas.
* **Dashboard Resumido:** Tela com indicadores chave como número de clientes ativos, produtos em estoque e vendas totais.

## Tecnologias Utilizadas

* **C#**
* **Visual Studio 2022** (ou versão compatível)
* **ASP.NET MVC** (especificar versão se aplicável)
* **Banco de Dados:** [Especificar o banco de dados usado, ex: SQL Server, MySQL, PostgreSQL]

## Instalação e Execução

**Pré-requisitos:**

* **.NET SDK:**  [Link para download do .NET SDK] -  Verifique a versão necessária no arquivo `.csproj`.
* **Visual Studio 2022 (ou superior):**  Recomendado para desenvolvimento e depuração.
* **Banco de Dados:** Instale e configure o banco de dados especificado acima.

**Passos:**

1. **Clone o Repositório:**

   ```bash
   git clone <URL_DO_SEU_REPOSITORIO>

2.**Abra o Projeto no Visual Studio:**

3.**Abra a solução (.sln) no Visual Studio 2022.**

4.**Restaure os Pacotes NuGet:**

**O Visual Studio geralmente restaura os pacotes automaticamente. Caso contrário, clique com o botão direito no projeto e selecione "Restaurar Pacotes NuGet".**

Configure a String de Conexão:

Abra o arquivo appsettings.json (ou similar) e configure a string de conexão para o seu banco de dados. Exemplo para SQL Server:
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=<SeuNomeDoBancoDeDados>;Trusted_Connection=True;MultipleActiveResultSets=true"
}

5.**Adapte para o seu banco de dados.**

6.**Crie o Banco de Dados (se necessário):**

7**Se o banco de dados não existir, crie-o usando um script SQL (se fornecido no repositório).**

8.**Execute a Aplicação:**

Pressione F5 no Visual Studio para executar o projeto.

Solução de Problemas:

Erros de Conexão com o Banco de Dados: Verifique a string de conexão, as credenciais e a instalação do banco de dados.
Erros de NuGet: Verifique sua conexão com a internet e tente restaurar os pacotes novamente.
Erros de Compilação: Verifique o log de erros do Visual Studio para identificar e corrigir problemas no código.
