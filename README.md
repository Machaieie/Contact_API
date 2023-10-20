
```markdown
# API de Contatos

Esta é uma API de Contatos desenvolvida em ASP.NET Core que permite a criação, leitura, atualização e exclusão de contatos. Além disso, a API oferece autenticação de usuário por nome de usuário e senha para proteger os dados dos contatos.

## Requisitos

- ASP.NET Core SDK [Instalação](https://dotnet.microsoft.com/download)
- SQL Server ou outro banco de dados compatível
- Um ambiente de desenvolvimento ou servidor de hospedagem

## Configuração

1. Clone o repositório:

   ```bash
   git clone https://seu-repositorio/api-de-contatos.git
   ```

2. Navegue até o diretório do projeto:

   ```bash
   cd api-de-contatos
   ```

3. Configure a conexão com o banco de dados em `appsettings.json`.

4. Execute as migrações do banco de dados para criar as tabelas:

   ```bash
   dotnet ef database update
   ```

5. Inicie a aplicação:

   ```bash
   dotnet run
   ```

## Autenticação de Usuário

A API requer autenticação para acessar recursos de contato. Para obter um token de acesso, faça uma solicitação POST para `/api/auth/login` com o seguinte corpo JSON:

```json
{
    "username": "seu-usuario",
    "password": "sua-senha"
}
```

Isso retornará um token de acesso que você deve incluir no cabeçalho das solicitações autenticadas como `Authorization: Bearer {seu-token}`.

## Endpoints

- `GET /api/contatos`: Retorna a lista de contatos.
- `GET /api/contatos/{id}`: Retorna os detalhes de um contato específico.
- `POST /api/contatos`: Cria um novo contato.
- `PUT /api/contatos/{id}`: Atualiza um contato existente.
- `DELETE /api/contatos/{id}`: Exclui um contato.

Certifique-se de incluir o token de autenticação no cabeçalho de todas as solicitações para os endpoints protegidos.

## Exemplo de Solicitação

Para criar um novo contato:

```http
POST /api/contatos
Content-Type: application/json
Authorization: Bearer {seu-token}

{
    "nome": "Nome do Contato",
    "numero": "+123456789",
    "email": "contato@example.com"
}
```

## Contribuindo

Sinta-se à vontade para contribuir com melhorias para esta API de contatos. Basta fazer um fork do repositório, criar uma branch com sua contribuição e enviar um pull request.



Lembre-se de substituir os espaços reservados, como `{seu-repositorio}`, `{seu-usuario}`, `{sua-senha}`, e `{seu-token}`, com os valores específicos do seu projeto. Além disso, certifique-se de adicionar informações detalhadas sobre a estrutura de sua API, modelos de dados e qualquer outra informação relevante.
