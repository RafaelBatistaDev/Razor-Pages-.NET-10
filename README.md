# 🎬 Razor Pages Movie Application

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10.0-blue)](https://dotnet.microsoft.com)
[![C#](https://img.shields.io/badge/C%23-13-green)](https://docs.microsoft.com/dotnet/csharp)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Razor%20Pages-purple)](https://learn.microsoft.com/aspnet/core)

Aplicação web profissional para gerenciamento de filmes desenvolvida com **ASP.NET Core Razor Pages** e **.NET 10**.

## 📋 Sobre o Projeto

Sistema completo de catálogo de filmes com operações CRUD, busca avançada, paginação e validação de dados, utilizando **Entity Framework Core** com banco **SQLite**.

### Funcionalidades

- 🎞️ **CRUD Completo** — Criar, ler, atualizar e excluir filmes
- 🔍 **Busca Avançada** — Filtros por título, gênero e avaliação mínima
- 📊 **Paginação** — Navegação entre páginas com 8 filmes por página
- ✅ **Validação Robusta** — Data Annotations com mensagens em português
- 🎨 **Design Responsivo** — Bootstrap 5 com tema profissional
- 💾 **Persistência** — SQLite + Entity Framework Core
- 🏗️ **Arquitetura Limpa** — Code-behind, DI, separação de responsabilidades

## 🛠️ Requisitos

- [.NET SDK 10.0](https://dotnet.microsoft.com/download)
- Git

## ⚡ Quick Start

```bash
# Clone o repositório
git clone https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10.git
cd Razor-Pages-.NET-10

# Restaure as dependências
dotnet restore

# Execute com hot reload
dotnet watch run
```

Acesse em: **http://localhost:5279**

## 🗂️ Estrutura do Projeto

```
Pages/
├── Index.cshtml              # Página inicial com estatísticas
├── Privacy.cshtml            # Política de privacidade
├── Error.cshtml              # Página de erro personalizada
├── Movies/
│   ├── Index.cshtml          # Listagem com busca e paginação
│   ├── Create.cshtml         # Cadastro de filmes
│   ├── Edit.cshtml           # Edição de filmes
│   ├── Delete.cshtml         # Exclusão com confirmação
│   └── Details.cshtml        # Detalhes do filme
├── Models/
│   ├── ModelsMovie.cs        # Entidade Movie
│   └── MovieDbContext.cs     # Contexto do EF Core
└── Shared/
    ├── _Layout.cshtml        # Layout profissional
    └── _ValidationScriptsPartial.cshtml
```

## 🧪 Endpoints

| Rota | Descrição |
|------|-----------|
| `/` | Página inicial |
| `/Movies` | Catálogo de filmes |
| `/Movies/Create` | Novo filme |
| `/Movies/Edit?id=N` | Editar filme |
| `/Movies/Details?id=N` | Detalhes do filme |
| `/Movies/Delete?id=N` | Excluir filme |
| `/health` | Health check |

## 📄 Licença

Distribuído sob licença MIT. Veja [LICENSE](LICENSE) para mais informações.

---

Desenvolvido por **Rafael Batista**
