# 🔧 Configuração do Repositório GitHub

Neste documento está a configuração recomendada e metadados do repositório no GitHub.

---

## 📋 Informações do Repositório

### Nome
```
Razor-Pages-.NET-10
```

### URL Oficial
```
https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10
```

### Descrição (para GitHub)

Copie e cole na seção "About" do repositório:

```
🎬 Aplicação web profissional com ASP.NET Core Razor Pages e .NET 10. 
Gerenciamento completo de filmes (CRUD), validação robusta, Entity Framework Core, 
SQLite e design responsivo. Desenvolvida 100% em Linux (Fedora). 
MIT License — código aberto e livre para usar.
```

**Máximo:** 70 caracteres/linha

### Website (opcional)

Se houver deploy:
```
https://seu-dominio.com (WIP)
```

---

## 🏷️ Topics/Tags

Adicione estes topics no repositório para melhor **descoberta** e **SEO**:

Na aba "About" → Clique em "Add topics":

```
✅ dotnet
✅ aspnetcore
✅ csharp
✅ razorpages
✅ entity-framework-core
✅ sqlite
✅ linux
✅ fedora
✅ bootstrap5
✅ web-development
✅ mvc
✅ open-source
✅ educational
✅ mit-license
```

---

## ⚙️ Configurações Recomendadas

### General

| Opção | Valor | Motivo |
|-------|-------|--------|
| **Repository type** | Public | Visibilidade máxima |
| **Template repository** | ❌ Não | Não é template |
| **Default branch** | `main` | Convenção moderna |
| **Description** | ✅ Adicionada | Melhor SEO |

### Code and automation

#### Issues
- ✅ **Enable Issues**: Sim
- ✅ **Templates**: Adicionar (Bug Report + Feature Request)

#### Pull Requests
- ✅ **Enable Pull Requests**: Sim
- ✅ **Allow merge commits**: Sim
- ✅ **Allow squash merging**: Sim
- ✅ **Allow rebase merging**: Sim
- ✅ **Suggest updating PR branches**: Sim

#### Discussions (Futuro)
```
Categoria: General
Polled: Yes
```

### Branch protection rules

#### Para a branch `main`

```
Require a pull request before merging
  ✅ Require approvals: 1
  ✅ Require status checks to pass: Sim (GitHub Actions)
  ✅ Require branches to be up to date: Sim
  ✅ Include administrators: Sim
  ✅ Restrict who can push to matching branches: Não (ainda)
  ✅ Allow force pushes: Apenas admins
  ✅ Allow deletions: Não
```

---

## 📄 Templates para Issues e PRs

### Bug Report Template

Criar arquivo: `.github/ISSUE_TEMPLATE/01_bug_report.md`

```markdown
---
name: 🐛 Bug Report
about: Reportar um bug encontrado
title: "[BUG] Descrição curta do problema"
assignees: RafaelBatistaDev
labels: bug, triage-needed
---

## 🐛 Descrição do Bug

[Descrição clara e concisa do problema]

## 📋 Passos para Reproduzir

1. Faça isto...
2. Depois aquilo...
3. Ver resultado...

## 📸 Comportamento Esperado

[O que deveria acontecer]

## 📸 Comportamento Atual

[O que está acontecendo]

## 🖥️ Ambiente

```
.NET Version: [dotnet --version]
OS: [Windows/macOS/Linux]
Browser: [se aplicável]
IDE: [VS Code/Visual Studio/Rider]
```

## 📎 Prints/Logs

[Adicione screenshots ou logs de erro]

## 🔗 Contexto Adicional

[Qualquer informação relevante]
```

### Feature Request Template

Criar arquivo: `.github/ISSUE_TEMPLATE/02_feature_request.md`

```markdown
---
name: ✨ Feature Request
about: Sugerir uma nova funcionalidade
title: "[FEATURE] Descrição breve da solicitação"
labels: enhancement, triage-needed
---

## 📋 Descrição da Feature

[Explique a funcionalidade desejada]

## 💡 Motivation / Use Case

Por que seria útil? Quando seria usada?

## 🎯 Implementação Proposta

[Se tiver ideias, compartilhe]

## 🔄 Alternativas Consideradas

[Outras formas de resolver?]

## 📚 Recursos Relacionados

- Link 1
- Link 2
```

### Pull Request Template

Criar arquivo: `.github/pull_request_template.md`

```markdown
# 📋 Descrição

[Descrever as mudanças realizadas]

## 🔗 Relacionado

- Closes #123
- References #456

## ✅ Checklist

- [ ] Código segue padrões do projeto
- [ ] Testes adicionados/atualizados (quando aplicável)
- [ ] Documentação atualizada
- [ ] Nenhum conflito com `main`
- [ ] Build passa (`dotnet build`)
- [ ] Commit messages seguem Convention Commits

## 🧪 Como Testar

[Instruções para revisor testar as mudanças]

## 📸 Screenshots (se UI)

[Antes/depois, se houver mudanças visuais]
```

---

## 🔄 Workflows GitHub Actions (Futuro)

### Estrutura Recomendada

Criar arquivo: `.github/workflows/ci.yml`

```yaml
name: CI (Futuro)

on:
  push:
    branches: [main, develop]
  pull_request:
    branches: [main]

jobs:
  build-and-test:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: actions/setup-dotnet@v4
        with:
          dotnet-version: '10.0.x'
      - run: dotnet restore
      - run: dotnet build -c Release
      - run: dotnet test --no-build
```

---

## 📝 Arquivos No Repositório

### Obrigatórios (já criados)
```
✅ README.md              — Documentação principal
✅ LICENSE               — MIT License
✅ .gitignore            — Arquivos ignorados
✅ CONTRIBUTING.md       — Guia de contribuição
✅ DEVELOPMENT.md        — Guia de desenvolvimento
✅ CHANGELOG.md          — Histórico de versões
✅ GITHUB-CONFIG.md      — Este arquivo
```

### Opcionais (recomendados)
```
⏳ .github/ISSUE_TEMPLATE/    — Templates para issues
⏳ .github/workflows/          — CI/CD automático
⏳ SECURITY.md                 — Política de segurança
⏳ CODE_OF_CONDUCT.md          — Código de conduta
```

---

## 🌐 Social e SEO

### GitHub Profile

Adicione ao perfil `README.md` pessoal:

```markdown
### 🔗 Meus Projetos Destacados

- [Razor-Pages-.NET-10](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10) 
  — Aplicação web com ASP.NET Core (⭐ novidades!)
- [ASP.NET-Core-Web-API-Bitcoin](https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-API-Bitcoin-USD-BRL-Live)
  — API RESTful com .NET 8
```

### Badges para README

```markdown
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10.0-blue)](https://dotnet.microsoft.com)
[![GitHub](https://img.shields.io/badge/GitHub-stars-informational?style=flat&logoColor=white&logo=github)](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/stargazers)
```

### Social Links

Adicione na seção "About":
- 🌐 Website (quando houver)
- 💼 LinkedIn (pessoal)
- 🐦 Twitter/X (se aplicável)

---

## 🚀 Publicação de Release

### Versioning

Seguir [Semantic Versioning](https://semver.org/):

```
MAJOR.MINOR.PATCH
  ↓      ↓      ↓
  1.     0.     0

1.0.0 → Primeira release estável
1.1.0 → Nova feature
1.1.1 → Bug fix
2.0.0 → Breaking changes
```

### Release Checklist

```bash
# 1. Atualizar CHANGELOG.md com histórico de mudanças

# 2. Tag Git
git tag -a v1.0.0 -m "Release v1.0.0"
git push origin v1.0.0

# 3. GitHub Release
# - Título: Release v1.0.0
# - Descrição: Copiar de CHANGELOG.md
# - Anexos: arquivo .zip do código (opcional)

# 4. Anunciar nas redes
# - Twitter/LinkedIn
# - 🎉 Use emojis!
```

---

## 📊 Métricas e Analytics

### GitHub Insights

Acompanhando regularmente:

- **Traffic:** Visitantes únicos, clones
- **Forks:** Quantas vezes foi forkado
- **Stars:** ⭐ Favoritos (objetivo: 50+)
- **Contributors:** Pessoas que contribuíram
- **Network:** Relação com forks

### Metas

```
v1.0.0: 10 stars ⭐
v1.5.0: 50 stars ⭐
v2.0.0: 100+ stars ⭐
```

---

## 🔐 Segurança do Repositório

### Proteger a Branch Main

✅ **Já configurado em branch protection rules:**
- Require pull request reviews
- Require status checks
- Prevent force push

### Secrets Management

```bash
# NUNCA commitar:
#   ❌ Database passwords
#   ❌ API keys
#   ❌ Credentials

# USAR:
#   ✅ User Secrets (desenvolvimento)
#   ✅ GitHub Secrets (CI/CD)
#   ✅ Azure Key Vault (produção)
```

### Verificar Dependências

```bash
# Verificar pacotes vulneráveis
dotnet list package --vulnerable

# Atualizando regulamente
dotnet list package --outdated
```

---

## 📞 Contato e Suporte

### Como Contribuir

1. Abra uma [Issue](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/issues)
2. Participe de [Discussions](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/discussions)
3. Envie um [Pull Request](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/pulls)

### Encontre-me

```
👤 GitHub: github.com/RafaelBatistaDev
📧 Email: seu-email@example.com (quando adicionar)
💼 LinkedIn: linkedin.com/in/seu-perfil (opcional)
```

---

## 🎓 Licença e Termos

**MIT License** — Veja [LICENSE](LICENSE)

```
✅ Uso comercial
✅ Modificação
✅ Distribuição
✅ Apenas inclua copyright notice

❌ Sem garantia
❌ Sem suporte obrigatório
```

---

## ✅ Checklist de Configuração

- [ ] Nome do repositório correto
- [ ] Descrição adicionada no GitHub
- [ ] Topics/tags adicionados (14 tags)
- [ ] Repository set to Public
- [ ] Branch protection ativada para `main`
- [ ] Default branch é `main`
- [ ] .gitignore contém padrões .NET
- [ ] LICENSE arquivo incluído
- [ ] README.md completo
- [ ] CONTRIBUTING.md presente
- [ ] DEVELOPMENT.md presente
- [ ] CHANGELOG.md presente
- [ ] Issue templates criados (futuro)
- [ ] GitHub Actions setado (futuro)

---

## 🔄 Processo de Atualização

**Toda vez que atualizar configuração:**

```bash
# 1. Documentar mudanças aqui
# 2. Commitar
git add GITHUB-CONFIG.md
git commit -m "docs: atualiza configuração do GitHub"
git push origin main

# 3. Sincronizar com repositório
```

---

**Versão:** 1.0.0  
**Data:** 4 de abril de 2026  
**Referência:** GitHub Config Best Practices
