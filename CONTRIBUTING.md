# 🤝 Guia de Contribuição

Obrigado por se interessar em contribuir para o **Razor Pages Movie Application**! 🚀

Este documento fornece diretrizes e instruções para fazer contribuições significativas.

---

## Código de Conduta

Este projeto segue um Código de Conduta respeitoso:

- ✅ **Respeito:** Trate todos com respeito e dignidade
- ✅ **Crítica Construtiva:** Critique ideias e código, não pessoas
- ✅ **Inclusão:** Valorizamos diversidade de perspectivas
- ✅ **Profissionalismo:** Mantenha conversas produtivas
- ✅ **Segurança:** Reporte comportamentos inadequados

---

## Como Começar

### Tipos de Contribuições Bem-Vindas

- 🐛 **Bug Reports** — Encontrou um erro? Nos avise!
- ✨ **Feature Requests** — Tem uma ideia? Sugira!
- 📖 **Documentação** — Melhorias em README, comentários
- 🧪 **Testes** — Addition de testes automatizados
- 🎨 **UI/UX** — Melhorias visuais e experiência
- 🔧 **Refatoração** — Limpeza e otimização de código
- 🚀 **Performance** — Melhorias de velocidade

---

## Reportando Bugs

### 1. Verifique Se Já Existe uma Issue
```bash
# Procure na aba Issues do GitHub
# https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/issues
```

### 2. Crie uma Issue com Detalhes

Use este template:

```markdown
## 🐛 Descrição do Bug

[Explicar o problema de forma clara e concisa]

## 📋 Contexto

- **O que você estava fazendo?**
- **Qual era o comportamento esperado?**
- **Qual foi o comportamento real?**
- **Como reproduzir?** (passo a passo)

## 📸 Screenshots/Logs

[Se aplicável, adicione logs ou capturas de tela]

## 🔧 Ambiente

```bash
# Versão do .NET
dotnet --version

# Versão do Sistema Operacional
uname -a

# IDE/Editor
Visual Studio Code / Visual Studio / Rider
```

## ⚙️ Solução Tentada

[O que você já tentou para resolver?]
```

---

## Sugerindo Features

### 1. Verifique Discussions

Link: https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/discussions

### 2. Abra uma Discussion ou Issue

```markdown
## ✨ Solicitação de Feature

### Descrição
[Explique a feature desejada]

### Motivação
[Por que seria útil?]

### Contexto de Uso
[Quando e como seria usada?]

### Implementação Proposta
[Se tiver ideias, compartilhe]

### Alternativas Consideradas
[Outras formas de resolver?]
```

---

## Fazendo seu Primeiro Commit

### 1. Fork o Repositório

```bash
# Clique no botão "Fork" no GitHub
# Seu fork será criado em:
# https://github.com/SEU-USUARIO/Razor-Pages-.NET-10
```

### 2. Clone o Fork Localmente

```bash
git clone https://github.com/SEU-USUARIO/Razor-Pages-.NET-10.git
cd Razor-Pages-.NET-10

# Adicionar remoto upstream (repositório original)
git remote add upstream https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10.git
```

### 3. Crie uma Branch Feature

```bash
# Atualize sua cópia local
git fetch upstream
git checkout main
git reset --hard upstream/main

# Crie uma branch descritiva
git checkout -b feature/descricao-curta
```

**Convenção de Nomes:**
- `feature/nova-funcionalidade` — Nova feature
- `bugfix/correcao-de-bug` — Correção de bug
- `docs/atualizacao-readme` — Documentação
-`refactor/nome-refactoring` — Refatoração
- `test/adiciona-testes` — Testes

### 4. Faça suas Mudanças

```bash
# Editar arquivos...

# Build local
dotnet build

# Executar em desenvolvimento
dotnet watch run

# Testes (quando implementados)
dotnet test
```

### 5. Commit com Mensagens Claras

```bash
# Padrão Conventional Commits
git commit -m "feature: adiciona busca por gênero

- Implementa campo de filtro por gênero
- Adiciona validação de entrada
- Atualiza view de listagem

Fixes #123"
```

**Formato recomendado:**
```
tipo(escopo): mensagem curta

Descrição detalhada do que foi feito.
Explique o "por quê", não o "quê".

Fixes #numero-da-issue
```

**Tipos válidos:**
- `feat` — Nova funcionalidade
- `fix` — Correção de bug
- `docs` — Documentação
- `style` — Formatação, espaços, semicolons
- `refactor` — Refatoração sem mudança funcional
- `test` — Adição/atualização de testes
- `chore` — Tarefas de build, deps, etc

### 6. Push para seu Fork

```bash
git push origin feature/descricao-curta
```

### 7. Abra uma Pull Request

```
1. Acesse seu fork no GitHub
2. Clique em "Compare & pull request"
3. Preencha o template de PR
4. Clique em "Create Pull Request"
```

**Template de Pull Request:**

```markdown
## 📋 Descrição

[Descrever as mudanças realizadas]

## 🔗 Links Relacionados

- Fixes #123
- Relacionado a #456

## ✅ Checklist

- [ ] Código segue os padrões do projeto
- [ ] Testes foram adicionados/atualizados
- [ ] Documentação foi atualizada
- [ ] Sem conflitos com a branch `main`
- [ ] Build passa localmente (`dotnet build`)
- [ ] Commits têm mensagens claras

## 🧪 Como Testar

[Instruções para revisor testar as mudanças]

## 📸 Screenshots (se aplicável)

[Adicione screenshots antes/depois]
```

---

## Padrões de Código

### C# Conventions

```csharp
// ✅ SIM — Classes públicas em PascalCase
public class MoviePageModel : PageModel
{
    // ✅ SIM — constantes em UPPER_SNAKE_CASE
    private const string ERROR_MESSAGE = "Erro ao salvar filme";
    
    // ✅ SIM — propriedades em PascalCase
    public List<Movie> Movies { get; set; } = [];
    
    // ✅ SIM — métodos privados começam com letra minúscula (padrão)
    private void LoadMovies()
    {
        // ...
    }
    
    // ✅ SIM — async/await obrigatório
    public async Task OnGetAsync()
    {
        Movies = await _context.Movies.ToListAsync();
    }
}

// ❌ NÃO — Abreviações em nomes
public class MoviePM { } // ❌

// ❌ NÃO — Variáveis com _ prefixo público
public class MovieModel { public string _title; } // ❌
```

### Estrutura de Projeto

```csharp
// ✅ Arquivo: Pages/Movies/Index.cshtml.cs
namespace RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        // Dependências no construtor
        public IndexModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        // Propriedades
        public IList<Movie> Movies { get; set; } = [];

        // Métodos async primeiro
        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            // ...
            return RedirectToPage("./Index");
        }
    }
}
```

### Validação e Segurança

```csharp
// ✅ SIM — Data Annotations em modelos
public class Movie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Título é obrigatório")]
    [StringLength(100, MinimumLength = 3)]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
}

// ✅ SIM — Validação no PageModel
public async Task<IActionResult> OnPostAsync()
{
    if (!ModelState.IsValid)
        return Page();

    // Processar dados validados...
}
```

### Documentação no Código

```csharp
/// <summary>
/// Obtém a lista de filmes com paginação.
/// </summary>
/// <param name="pageNumber">Número da página (começando em 1)</param>
/// <param name="pageSize">Quantidade de itens por página</param>
/// <returns>Lista de filmes para a página especificada</returns>
public async Task<IList<Movie>> GetMoviesAsync(int pageNumber = 1, int pageSize = 10)
{
    return await _context.Movies
        .Skip((pageNumber - 1) * pageSize)
        .Take(pageSize)
        .ToListAsync();
}
```

---

## Processo de Review

### O que Acontece Após PR

1. **Automated Checks** — GitHub Actions verifica build
2. **Code Review** — Um mantenedor revisa
3. **Discussão** — Feedback e melhorias propostas
4. **Approval** — Quando aprovado
5. **Merge** — PR é mesclada na main

### Feedback Comum

- ✅ "Adicione testes para este código"
- ✅ "Pode refatorar este método?"
- ✅ "Documente esta função pública"
- ✅ "Use async/await aqui"

**Estamos aqui para ajudar!** Nenhuma pergunta é boba.

---

## Configuração Local

### Setup Completo

```bash
# 1. Clone
git clone https://github.com/SEU-USUARIO/Razor-Pages-.NET-10.git
cd Razor-Pages-.NET-10

# 2. Dependências
dotnet restore

# 3. Banco de dados
dotnet ef database update

# 4. Run
dotnet watch run

# 5. Acesse
# Abra: http://localhost:5000
```

### Verificações Antes de Commitar

```bash
# Build sem erros
dotnet build

# Sem warnings
dotnet build /property:TreatWarningsAsErrors=true

# Testes passam
dotnet test

# Código formatado (future)
dotnet format
```

---

## Dúvidas Frequentes

### P: Como atualizar minha branch com mudanças do upstream?

```bash
git fetch upstream
git rebase upstream/main

# Se tiver conflitos, resolva e:
git add .
git rebase --continue
git push origin feature/nome -f
```

### P: Como adicionar um coautor ao commit?

```bash
git commit -m "mensagem

Co-authored-by: Nome <email@example.com>"
```

### P: Posso fazer pull request ainda em desenvolvimento?

Sim! Use `[WIP]` no título:
```
[WIP] feature: adiciona autenticação (em andamento)
```

### P: Como reverter um commit enviado?

```bash
# Cria um novo commit que desfaz as mudanças
git revert <commit-hash>
git push origin feature/nome
```

---

## Reconhecimento

Todos os contribuidores são reconhecidos em:
- ✅ Contributors page do GitHub
- ✅ Seção "Agradecimentos" no README.md
- ✅ Release notes (quando aplicável)

---

## Suporte

- 💬 **Dúvidas?** Abra uma [Discussion](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/discussions)
- 🐛 **Bugs?** [Abra uma Issue](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/issues)
- 📧 **Email:** check GITHUB-CONFIG.md

---

## Referências Úteis

- [GitHub Flow Guide](https://guides.github.com/introduction/flow/)
- [Conventional Commits](https://www.conventionalcommits.org/)
- [C# Coding Conventions](https://learn.microsoft.com/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [Razor Pages Documentation](https://docs.microsoft.com/aspnet/core/razor-pages/)

---

**Obrigado por contribuir! Sua ajuda é inestimável. 🙏**

---

Versão: 1.0.0  
Última atualização: 4 de abril de 2026
