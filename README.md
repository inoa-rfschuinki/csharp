# 🚀 Meu Roadmap de C# & .NET: Do Zero ao Mercado

Repositório dedicado a documentar a minha jornada de aprendizado em C# e no ecossistema .NET pelos próximos 7 meses. Goal: Dominar a base, aprofundar em arquitetura e me consolidar como um dev pronto para o mercado.

---

## 📚 Fontes de Estudo Utilizadas

* **Iniciante:** Livro *Head First C# (Use a Cabeça! C#)* - Foco em fundamentos e prática visual.
* **Aprofundamento:** Documentação Oficial da Microsoft (Learn .NET), Balta.io, Macoratti, e o livro *C# 12 and .NET 8* (ou versões mais recentes) de Mark J. Price.

---

## 🗺️ O Cronograma (7 Meses)

### ⏱️ Mês 1: Fundamentos Básicos (O Início com Head First)
*Foco em entender a sintaxe, lógica e as primeiras ferramentas da linguagem.*

- [x] Instalação do ambiente (VS Code / Visual Studio / .NET SDK)
- [x] Criar e executar o primeiro `Hello World` via CLI
- [ ] Variáveis, Tipos de Dados (`int`, `string`, `bool`, `double`) e Conversões (Typecasting)
- [ ] Estruturas Condicionais (`if`, `else`, `switch`)
- [ ] Estruturas de Repetição (`while`, `do-while`, `for`, `foreach`)
- [ ] Arrays e Coleções Básicas (`List<T>`)
- [ ] **Projeto do Mês:** Criar um console app de calculadora de console completa ou um gerenciador de tarefas simples (Todo List).

### 🧱 Mês 2: Orientação a Objetos (OOO) na Prática
*Transição para a verdadeira engrenagem do C#.*

- [ ] Classes, Objetos, Atributos e Métodos
- [ ] Construtores e Modificadores de Acesso (`public`, `private`, `protected`, `internal`)
- [ ] Os 4 Pilares da POO:
    - [ ] Abstração
    - [ ] Encapsulamento (Propriedades `{ get; set; }`)
    - [ ] Herança
    - [ ] Polimorfismo (Métodos `virtual`, `override` e `abstract`)
- [ ] Interfaces vs. Classes Abstratas
- [ ] Tratamento de Erros e Exceções (`try`, `catch`, `finally`, `throw`)
- [ ] **Projeto do Mês:** Sistema de um Banco (Contas Corrente/Poupança, saques, depósitos e validações utilizando POO).

### 🔍 Mês 3: C# Avançado & LINQ
*Escrevendo código limpo, performático e expressivo. Fim da linha para o livro Head First, hora de migrar para documentações e livros técnicos.*

- [ ] Tipos de Valor vs. Tipos de Referência (`struct` vs `class`)
- [ ] Generics (`List<T>`, `Dictionary<TKey, TValue>`)
- [ ] Delegates, Expressões Lambda e Eventos
- [ ] **LINQ (Language Integrated Query):** Métodos de extensão (`Where`, `Select`, `OrderBy`, `GroupBy`, `FirstOrDefault`)
- [ ] Manipulação de Arquivos (`System.IO`, JSON com `System.Text.Json`)
- [ ] Introdução ao Asincronismo (`async` e `await`, `Task`)
- [ ] **Projeto do Mês:** Aplicativo de console que lê um arquivo CSV/JSON de vendas, processa os dados usando LINQ e gera um relatório detalhado.

### 🌐 Mês 4: Desenvolvimento Web com ASP.NET Core
*Entrando no mundo das APIs que dominam o mercado corporativo.*

- [ ] Entender a arquitetura da Web (HTTP, Verbos, Status Codes, REST)
- [ ] Estrutura de um projeto ASP.NET Core Web API (Program.cs, Controllers, Middlewares)
- [ ] Injeção de Dependência (DI) e Tempo de Vida dos Serviços (`Transient`, `Scoped`, `Singleton`)
- [ ] Validação de dados de entrada (`Data Annotations` ou `FluentValidation`)
- [ ] Roteamento e Passagem de Parâmetros (`[FromRoute]`, `[FromQuery]`, `[FromBody]`)
- [ ] **Projeto do Mês:** Construir uma API REST de um e-commerce ou catálogo de filmes (CRUD completo).

### 💾 Mês 5: Banco de Dados & Entity Framework Core (EF Core)
*Conectando a aplicação ao mundo real dos dados persistidos.*

- [ ] Conceitos básicos de Bancos de Dados Relacionais (SQL Server, PostgreSQL)
- [ ] Introdução ao EF Core (Abordagem Code-First)
- [ ] Configuração de Contexto (`DbContext`) e Mapeamento de Entidades
- [ ] Relacionamentos no EF Core (1:1, 1:N, N:N)
- [ ] Executando Migrations e atualizando a base de dados
- [ ] Consultas e persistência de dados com EF Core via API
- [ ] **Projeto do Mês:** Integrar a API do Mês 4 com um banco de dados real usando EF Core.

### 🧪 Mês 6: Testes Automatizados e Qualidade de Código
*O divisor de águas entre o programador amador e o profissional.*

- [ ] Conceitos de Testes (Unitários, Integração)
- [ ] Criação de projetos de testes com **xUnit** ou **NUnit**
- [ ] O padrão AAA (Arrange, Act, Assert)
- [ ] Utilização de Mocks (Biblioteca **Moq** ou **NSubstitute**)
- [ ] Princípios **SOLID** aplicados ao C#
- [ ] Noções de Clean Code (Nomes significativos, funções pequenas)
- [ ] **Projeto do Mês:** Cobrir a API desenvolvida com pelo menos 70% de testes unitários.

### 🏗️ Mês 7: Arquitetura, Segurança e Deploy
*Preparando o terreno para grandes sistemas.*

- [ ] Introdução a Arquiteturas de Software (Clean Architecture ou Onion Architecture)
- [ ] Padrão Repository e Unit of Work (discussão sobre uso com EF Core)
- [ ] Autenticação e Autorização (JWT Bearer Token, Roles e Claims)
- [ ] Deploy básico (Dockerizar a aplicação, subir no Azure/AWS ou Render)
- [ ] **Projeto Final de Encerramento do Ano:** Uma aplicação robusta, com Clean Architecture, autenticação JWT, banco de dados persistido, 100% testada e rodando em um container Docker.
