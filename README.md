# API de Viagens - Rotas do Sol
![api agencia](https://github.com/Julianapds/backend-api-rotasdosol-dotnet/assets/94876661/f5769074-f08c-4ccb-bbef-ea5a70dc61d6)

## Descrição

API para gerenciamento de clientes em uma agência de viagens. Permite operações CRUD (Create, Read, Update, Delete) em um banco de dados de clientes.

## Requisitos

- MySQL
- .NET

## Banco de Dados
### Script de Criação do Banco de Dados

```sql
CREATE DATABASE IF NOT EXISTS db_viagens;
USE db_viagens;

CREATE TABLE Cliente (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255),
    email VARCHAR(255) UNIQUE,
    cpf VARCHAR(11) UNIQUE,
    telefone VARCHAR(15),
    endereco VARCHAR(255),
    senha VARCHAR(255)
);

INSERT INTO Cliente (nome, email, cpf, telefone, endereco, senha) VALUES
('João Silva', 'joao.silva@example.com', '12345678901', '11987654321', 'Rua Exemplo, 123', 'senha123');
```

## Como Executar
1. Clone o repositório do projeto.
2. avegue até a pasta do projeto via terminal.
3. Execute o comando `dotnet restore` para restaurar as dependências.
4. Execute o comando `dotnet run` para iniciar a aplicação.

## Rotas Disponíveis
As rotas disponíveis podem ser consultadas através da documentação Swagger, acessível em `http://localhost:5207/swagger` após iniciar a aplicação. As rotas incluem:

- Listar todos os clientes `(GET /clientes)`
- Visualizar um cliente por ID `(GET /clientes/{id})`
- Adicionar um novo cliente `(POST /clientes)`
- Editar um cliente `(PUT /clientes/{id})`
- Deletar um cliente `(DELETE /clientes/{id})`
