## Sistema de Venda de Produtos -  [Nome do Projeto]

Este projeto é um sistema web de venda de produtos desenvolvido com C# no Visual Studio 2022, utilizando o padrão MVC (Model-View-Controller). O sistema oferece funcionalidades completas para gerenciar clientes, fornecedores, produtos e vendas.

## Funcionalidades

**Gerenciamento de Cadastros:**

* **Clientes:**
    * Cadastro completo com nome, CPF/CNPJ, endereço, telefone, email e status (ativo/inativo).
    * Edição e exclusão de registros.
    * Busca por clientes.
* **Fornecedores:**
    * Cadastro com nome da empresa, CNPJ, endereço, telefone e email.
    * Edição e exclusão de registros.
    * Busca por fornecedores.
* **Produtos:**
    * Cadastro com nome, descrição, preço, quantidade em estoque e associação com fornecedores.
    * Edição e exclusão de registros.
    * Busca por produtos.

**Gerenciamento de Vendas:**

* **Emissão de Vendas:**
    * Seleção do cliente e dos produtos.
    * Cálculo automático do valor total da venda.
    * Registro da data de emissão.
    * Visualização e edição de vendas.

**Funcionalidades Bônus (Opcionais):**

* **Autenticação e Controle de Acesso:**
    * Sistema de login para controlar o acesso a funcionalidades específicas.
* **Relatório de Vendas:**
    * Gerar relatórios de vendas em um período específico, incluindo o total faturado.
* **Controle de Estoque:**
    * Atualização automática do estoque com base nas vendas registradas.
* **Dashboard Resumido:**
    * Tela com indicadores chave como número de clientes ativos, produtos em estoque e vendas totais.

## Tecnologias Utilizadas

* **C#**
* **Visual Studio 2022**
* **ASP.NET MVC**
* **Banco de Dados (ex: SQL Server, MySQL, PostgreSQL)**

## Instalação e Execução

1. **Clone o Repositório:**
    ```bash
    git clone https://github.com/SeuUsuario/SeuRepositório.git
    ```
2. **Abra o Projeto no Visual Studio:**
    * Abra a solução do projeto no Visual Studio 2022.
3. **Restaure os Pacotes NuGet:**
    * Restaure os pacotes NuGet necessários para o projeto.
4. **Configure a Conexão com o Banco de Dados:**
    * Configure a conexão com o banco de dados escolhido no arquivo de configuração do projeto.
5. **Execute a Aplicação:**
    * Execute o projeto para iniciar o sistema web.
