# Changelog

Todas as mudanças notáveis neste projeto serão documentadas neste arquivo.

O formato é baseado em [Keep a Changelog](https://keepachangelog.com/),
e este projeto segue [Semantic Versioning](https://semver.org/).

---

## [1.0.0] - 2026-04-04

### ✨ Added
- ✅ CRUD completo para gerenciamento de filmes (Create, Read, Update, Delete)
- ✅ Entity Framework Core com SQLite integrado
- ✅ Migrações de banco de dados automáticas
- ✅ Validação de dados robusta (Data Annotations)
- ✅ Pesquisa e filtragem por título, gênero e ano
- ✅ Interface responsiva com Bootstrap 5
- ✅ Layout profissional com _Layout.cshtml e CSS customizado
- ✅ Tratamento de erros centralizado (Error.cshtml)
- ✅ Página de Privacy e termos de uso
- ✅ Static assets otimizados (CSS/JS minimizados em Release)
- ✅ Model binding automático (ASP.NET Core)
- ✅ CSRF Token em formulários (segurança)
- ✅ Encoding de output (proteção contra XSS)

### 🔧 Changed
- Atualização para **.NET 10.0** (Latest preview)
- Utilização de **C# 13** com nullable reference types
- Modernização do `Program.cs` (top-level statements)
- Appsettings organizado e documentado
- Estrutura de páginas otimizada para melhor legibilidade

### 🐛 Fixed
- N/A (primeira release)

### ⚠️ Deprecated
- N/A (primeira release)

### 🔒 Security
- ✅ CSRF Token automático em Razor Pages
- ✅ SQL Injection prevenido com EF Core parameterizado
- ✅ XSS Protection com output encoding automático
- ✅ HTTPS recomendado em produção
- ✅ Validação de entrada server-side obrigatória

### 📚 Documentation
- ✅ README.md profissional (~450 linhas) com badges, quick start e exemplos
- ✅ DEVELOPMENT.md com guia completo de setup e workflow
- ✅ CONTRIBUTING.md com padrões de contribuição
- ✅ GITHUB-CONFIG.md com configuração recomendada do repositório
- ✅ Comentários em código-fonte (boas práticas)
- ✅ Arquivos de exemplo (appsettings.json com defaults)

### 🚀 Infrastructure
- ✅ .gitignore otimizado para projetos .NET
- ✅ MIT License adicionada
- ✅ Estrutura profissional de repositório
- ✅ Props de coleta automática (VS Code, Rider compatível)

### 🐧 Systems
- ✅ 100% compatível com Fedora Linux (Atomic, Workstation, COSMIC)
- ✅ Testado em .NET 10 em Ubuntu/Fedora
- ✅ Suporte a Toolbox/Distrobox no Fedora
- ✅ Sem dependências de Windows

---

## Unreleased

### Planejado para v1.1.0
- [ ] Autenticação com ASP.NET Identity
- [ ] Autorização baseada em roles (Admin/User)
- [ ] Classificação de filmes (rating de usuários)
- [ ] Upload de imagens (posters)
- [ ] Favoritos/Watchlist de usuários
- [ ] Paginação avançada (5, 10, 25 itens por página)
- [ ] Dark mode com alternância
- [ ] Busca com ElasticSearch
- [ ] API REST complementar

### Planejado para v1.2.0
- [ ] Cache com Redis (performance)
- [ ] Rate limiting de requisições
- [ ] Testes unitários com xUnit
- [ ] Testes de integração (E2E)
- [ ] Docker/Podman Containerfile
- [ ] GitHub Actions CI/CD automatizado
- [ ] Logging com Serilog
- [ ] Monitoramento com Application Insights

### Planejado para v2.0.0
- [ ] Migração para Blazor Server/WebAssembly (opcional)
- [ ] API GraphQL
- [ ] Real-time updates com SignalR
- [ ] Suporte a múltiplas linguagens (i18n)
- [ ] Backup automático de banco

---

## Notas de Versão

### Ambiente de Desenvolvimento
- **IDE Recomendada:** VS Code + C# DevKit ou Visual Studio 2022
- **Runtime:** .NET 10.0+
- **Banco:** SQLite (padrão, sem instalação necessária)
- **OS:** Windows, macOS, Linux (Fedora recomendado)

### Compatibilidade Garantida
- ✅ .NET 10.0+
- ✅ C# 13+
- ✅ Entity Framework Core 10+
- ✅ ASP.NET Core 10+
- ✅ Bootstrap 5+

---

## Links Úteis

- [Repositório no GitHub](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10)
- [Release Notes Completas](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/releases)
- [Issues Abertas](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/issues)
- [Pull Requests](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/pulls)

---

**Versão:** 1.0.0  
**Data:** 4 de abril de 2026  
**Mantenedor:** Rafael Batista Dev
