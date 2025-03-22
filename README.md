# API Project

## Descrição
Este projeto é uma API desenvolvida em .NET Core que utiliza o Entity Framework para interagir com um banco de dados, permitindo o resgate e manipulação de valores armazenados.

## Tecnologias Utilizadas
- .NET Core
- Entity Framework Core
- SQL Server (ou outro banco suportado pelo EF Core)
- Swagger para documentação da API
- Dependency Injection

## Instalação
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/API-Project.git
   ```
2. Navegue até a pasta do projeto:
   ```bash
   cd API-Project
   ```
3. Instale as dependências:
   ```bash
   dotnet restore
   ```
4. Configure a string de conexão no arquivo `appsettings.json`:
   ```json
   "ConnectionStrings": {
      "DefaultConnection": "Server=seu-servidor;Database=sua-base;User Id=seu-usuario;Password=sua-senha;"
   }
   ```
5. Execute as migrações do banco de dados:
   ```bash
   dotnet ef database update
   ```
6. Execute a aplicação:
   ```bash
   dotnet run
   ```

## Endpoints Principais
A API conta com os seguintes endpoints:

- **GET /api/entidade** - Retorna todos os registros da entidade.
- **GET /api/entidade/{id}** - Retorna um registro específico.
- **POST /api/entidade** - Cria um novo registro.
- **PUT /api/entidade/{id}** - Atualiza um registro existente.
- **DELETE /api/entidade/{id}** - Remove um registro.

## Documentação
A API conta com documentação via Swagger. Para acessá-la, inicie a aplicação e acesse:
```
http://localhost:5000/swagger
```

## Contribuição
Se deseja contribuir com este projeto:
1. Fork o repositório.
2. Crie uma branch para sua funcionalidade:
   ```bash
   git checkout -b minha-nova-feature
   ```
3. Faça commit das suas alterações:
   ```bash
   git commit -m "Adiciona nova feature"
   ```
4. Envie as alterações para seu fork:
   ```bash
   git push origin minha-nova-feature
   ```
5. Abra um Pull Request.

## Licença
Este projeto está licenciado sob a MIT License - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

