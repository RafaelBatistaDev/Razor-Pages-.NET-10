# 🔨 Guia de Desenvolvimento

Neste documento você encontra tudo o que precisa para configurar o ambiente local e contribuir ao projeto.

---

## 🎯 Objetivos

Este guia cobre:
- ✅ Instalação do .NET 10
- ✅ Setup inicial do projeto
- ✅ Desenvolvimento com VS Code/Visual Studio
- ✅ Banco de dados com Entity Framework
- ✅ Testes e debugging
- ✅ Publicação para produção

---

## 💻 Ambiente Recomendado

### Hardware
- **CPU:** Dual-core (4+ cores recomendado)
- **RAM:** 4GB mínimo, 8GB+ recomendado
- **Disco:** 2GB livre (SDK + dependências)

### IDE/Editor Recomendados

#### Visual Studio Code (Recomendado para Linux/macOS)
```bash
# Instalar a extensão C# Dev Kit
# Abra VS Code → Extensions → Procure "C# Dev Kit"
```

**Extensões Essenciais:**
```json
{
  "recommendations": [
    "ms-dotnettools.csharp",
    "ms-dotnettools.csdevkit",
    "ms-dotnettools.vscode-dotnet-runtime",
    "eamodio.gitlens",
    "EditorConfig.EditorConfig"
  ]
}
```

#### Visual Studio 2022 (Windows)
- Community Edition (Gratuito)
- Professional ou Enterprise (Pago)
- Instalar workload: "ASP.NET e desenvolvimento web"

#### JetBrains Rider (Cross-platform)
- Excelente para .NET
- Versão Community gratuita
- Versão Professional paga (~$150/ano)

### Sistemas Operacionais Suportados

| OS | Status | Comando |
|----|----|---------|
| **Linux (Fedora)** | ✅ Recomendado | Vejo [Setup Fedora](#-fedora-setup) |
| **Ubuntu/Debian** | ✅ Suportado | `sudo apt install dotnet-sdk-10.0` |
| **macOS** | ✅ Suportado | `brew install dotnet-sdk@10` |
| **Windows 10/11** | ✅ Suportado | [Download MSI](https://dotnet.microsoft.com) |

---

## 🐧 Fedora Setup

### Fedora Imutável (Silverblue/Kinoite/COSMIC)

#### Opção 1: Via rpm-ostree (Recomendado)

```bash
# Instalar .NET 10 em uma camada rpm-ostree
sudo rpm-ostree install dotnet-sdk-10.0 --apply-live

# Verificar
dotnet --version

# Opcional: reiniciar necessário apenas se --apply-live não funcionar
# sudo systemctl reboot
```

#### Opção 2: Via Toolbox (Isolado)

```bash
# Criar toolbox com Fedora 40
toolbox create --distro fedora --release 40 dotnet-dev

# Entrar no toolbox
toolbox enter dotnet-dev

# Dentro do toolbox
sudo dnf install dotnet-sdk-10.0

# Verificar
dotnet --version

# Sair do toolbox
exit
```

#### Opção 3: Via Distrobox (Mais flexível)

```bash
# Criar distrobox
distrobox create --name dotnet-dev --image registry.fedoraproject.org/fedora:40

# Entrar
distrobox enter dotnet-dev

# Instalar
sudo dnf install -y dotnet-sdk-10.0

# Exportar para ~/.local/bin
distrobox-export --bin /usr/bin/dotnet --export-path ~/.local/bin
```

### Fedora Workstation (Mutável)

```bash
# Instalar diretamente via dnf
sudo dnf install dotnet-sdk-10.0

# Verificar
dotnet --version
```

---

## 🚀 Setup Inicial

### 1. Clone o Repositório

```bash
# Via SSH (recomendado)
git clone git@github.com:RafaelBatistaDev/Razor-Pages-.NET-10.git

# Ou via HTTPS
git clone https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10.git

# Entre na pasta
cd Razor-Pages-.NET-10
```

### 2. Restaure Dependências

```bash
dotnet restore
```

Isto fará:
- ✅ Baixar todos os packages NuGet
- ✅ Restaurar dependências do projeto
- ✅ Preparar para build

### 3. Configure o Banco de Dados

```bash
# Aplicar migrações do Entity Framework Core
dotnet ef database update

# Verificar banco criado
ls -la *.db
# Você deve ver: RazorPagesMovie.db
```

### 4. Verificar Build

```bash
# Compilar em Debug (mais rápido)
dotnet build

# Ou compilar em Release (otimizado)
dotnet build -c Release
```

Deve terminar com: `Build succeeded.`

---

## ⚡ Desenvolvimento

### Executar em Watch Mode (Recomendado)

```bash
# Recompila automaticamente ao salvar
dotnet watch run

# Output esperado:
# [18:30:42 INF] Now listening on: http://localhost:5000
# [18:30:42 INF] Application started. Press Ctrl+C to shut down.
```

Agora acesse: **http://localhost:5000**

### Executar Modo Debug

#### VS Code
```
1. Pressione F5 para iniciar debug
2. Breakpoints aparecem automaticamente
3. Use o Debug Console para inspeção
```

#### Visual Studio
```
1. Pressione F5
2. IIS Express inicia automaticamente
3. Debugger pronto
```

#### Linha de Comando
```bash
# Build com símbolos de debug
dotnet build --configuration Debug

# Run com debug attachment
dotnet run --configuration Debug
```

### Compilação

```bash
# ✅ Debug (padrão, rápido, com símbolos)
dotnet build

# ✅ Release (otimizado, sem símbolos)
dotnet build -c Release

# ✅ Limpeza de builds anteriores
dotnet clean

# ✅ Check de estrutura
dotnet list package
dotnet list package --outdated
```

---

## 🗄️ Banco de Dados (Entity Framework Core)

### Criar Nova Migração

```bash
# Após modificar models
dotnet ef migrations add NomeMigração

# Exemplo: adicionar novo campo
# 1. Edite Models/Movie.cs
# 2. dotnet ef migrations add AddDirectorToMovie
# 3. dotnet ef database update
```

### Ver Migrações

```bash
# Listar todas as migrações
dotnet ef migrations list

# Remover última migração (se não aplicada)
dotnet ef migrations remove

# Script SQL de migração específica
dotnet ef migrations script --from 20260208161858_InitialCreate
```

### Gerenciar Banco

```bash
# Aplicar migrações
dotnet ef database update

# Remover banco (CUIDADO: perde dados!)
dotnet ef database drop --force

# Recriar do zero
dotnet ef database drop --force
dotnet ef database update

# Ver status
dotnet ef migrations list
```

### Acessar SQLite Diretamente

```bash
# Instalar ferramenta (se não tiver)
# Opcional: sqlite3 client

# Conectar ao banco
sqlite3 RazorPagesMovie.db

# Dentro do sqlite3
sqlite> SELECT name FROM sqlite_master WHERE type='table';
sqlite> SELECT COUNT(*) FROM Movie;
sqlite> .schema Movie
sqlite> .exit
```

---

## 🧪 Testes (Quando Implementados)

### Usar xUnit
```bash
# Criar novo projeto de testes
dotnet new xunit -n RazorPagesMovie.Tests

# Adicionar referência
cd RazorPagesMovie.Tests
dotnet add reference ../RazorPagesMovie/RazorPagesMovie.csproj

# Executar testes
dotnet test

# Com cobertura
dotnet test /p:CollectCoverage=true

# Modo watch
dotnet watch test
```

### Estrutura de Teste

```csharp
// Tests/Pages/IndexModel_Tests.cs
using Xunit;
using RazorPagesMovie.Pages;

public class IndexModelTests
{
    [Fact]
    public async Task OnGetAsync_LoadsMovies()
    {
        // Arrange
        var context = new TestMovieContext();
        var model = new IndexModel(context);

        // Act
        await model.OnGetAsync();

        // Assert
        Assert.NotNull(model.Movies);
    }
}
```

---

## 🔍 Debugging Avançado

### Breakpoints

```csharp
// Pressione F9 na linha para adicionar breakpoint
public async Task OnGetAsync()
{
    // ● Breakpoint aqui
    Movies = await _context.Movies.ToListAsync();
}
```

### Variáveis Locais

- Abra **Debug Console** (Ctrl+Shift+M em VS Code)
- Inspecione valores durante execução

### Logs com Debug

```csharp
using System.Diagnostics;

Debug.WriteLine($"Movies count: {Movies.Count}");

// Veja em Debug Output window
```

### Entity Framework Core Logging

```csharp
// Modify Program.cs
builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
{
    options.UseSqlite(connectionString);
    
    // Mostrar SQL queries
    options.LogTo(Console.WriteLine, LogLevel.Information);
});
```

Output:
```
Executed DbCommand (5ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT "m"."Id", "m"."Title", "m"."ReleaseDate" 
FROM "Movie" AS "m"
WHERE "m"."Title" = @__title_0
```

---

## 📦 Publicação

### Build para Produção

```bash
# Fazer publish
dotnet publish -c Release -o ./publish

# Arquivos gerados em ./publish/
# Estrutura:
# publish/
# ├── RazorPagesMovie (executável)
# ├── web.config
# ├── appsettings.json
# └── wwwroot/
```

### Self-Contained (Sem depender de .NET instalado)

```bash
# Publicar com runtime incluído
dotnet publish -c Release --self-contained \
  -p:PublishSingleFile=true \
  -p:PublishTrimmed=true \
  -r linux-x64 \
  -o ./publish-standalone

# Arquivo único executável:
./publish-standalone/RazorPagesMovie
```

### Docker/Podman (Opcional)

```dockerfile
# Dockerfile (futuro)
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY publish .
EXPOSE 5000
ENTRYPOINT ["dotnet", "RazorPagesMovie.dll"]
```

```bash
podman build -t razor-movies:latest .
podman run -p 5000:5000 razor-movies:latest
```

---

## 🔒 Desenvolvimento Seguro

### Secrets Management

```bash
# Inicializar user secrets (desenvolvimento)
dotnet user-secrets init

# Adicionar secret
dotnet user-secrets set "DatabasePassword" "senha_local_apenas"

# Usar no código
var dbPassword = configuration["DatabasePassword"];

# Secrets armazenados em
# ~/.microsoft/usersecrets/<project-id>/secrets.json
```

### HTTPS Local

```bash
# Confiar em certificado HTTPS para desenvolvimento
dotnet dev-certs https --trust

# Ver certificado
dotnet dev-certs https --check

# Remover certificado (se necessário)
dotnet dev-certs https --clean
```

---

## 🐛 Troubleshooting

### Problema: "dotnet: command not found"

**Solução:**
```bash
# Verificar se instalado
which dotnet

# Se não encontrado:
# Fedora: sudo rpm-ostree install dotnet-sdk-10.0
# Ubuntu: sudo apt install dotnet-sdk-10.0
# macOS: brew install dotnet-sdk@10

# Se via Toolbox, enter primeiro:
toolbox enter dotnet-dev
dotnet --version
```

### Problema: "Cannot open database file"

**Solução:**
```bash
# Aplicar migrações
dotnet ef database update

# Ou recriar banco
rm -f RazorPagesMovie.db
dotnet ef database update
```

### Problema: "Port 5000 already in use"

**Solução:**
```bash
# Encontrar processo na porta
lsof -i :5000

# Matar processo
kill -9 <PID>

# Ou mudar porta em launchSettings.json
# "applicationUrl": "http://localhost:5001"
```

### Problema: Build falha com "CS0103: The name does not exist"

**Solução:**
```bash
# Restaurar dependências
dotnet restore

# Limpar cache
dotnet clean
rm -rf obj/ bin/

# Rebuild
dotnet build
```

### Problema: Migrations "pending"

```bash
# Ver migrações pendentes
dotnet ef migrations list

# Aplicar todas
dotnet ef database update
```

---

## 📚 Referências

### Documentação Oficial
- [ASP.NET Core Razor Pages](https://learn.microsoft.com/aspnet/core/razor-pages/)
- [Entity Framework Core](https://learn.microsoft.com/ef/core/)
- [.NET CLI](https://learn.microsoft.com/dotnet/core/tools/)
- [C# Documentation](https://learn.microsoft.com/dotnet/csharp/)

### Tutoriais
- [Get started with Razor Pages](https://learn.microsoft.com/aspnet/core/tutorials/razor-pages/)
- [EF Core Migrations](https://learn.microsoft.com/ef/core/managing-schemas/migrations/)

### Comunidade
- [Stack Overflow - .NET tag](https://stackoverflow.com/questions/tagged/.net)
- [GitHub Discussions](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/discussions)

---

## ✅ Checklist Antes de Commitar

```bash
# ✅ Build passa
dotnet build

# ✅ Sem warnings
dotnet build /property:TreatWarningsAsErrors=true

# ✅ Banco está atualizado
dotnet ef database update

# ✅ Código formatado (adicionar depois)
# dotnet format

# ✅ Testes passam (quando implementados)
# dotnet test

# ✅ Git status limpo
git status
```

---

## 🚀 Workflow Típico

```bash
# 1. Atualizar repositório
git pull origin main

# 2. Criar branch
git checkout -b feature/nova-funcao

# 3. Desenvolver
dotnet watch run
# ... editar código ...

# 4. Testar localmente
dotnet build
# ... validar funcionamento ...

# 5. Commit
git add .
git commit -m "feat: adiciona nova funcionalidade"

# 6. Push
git push origin feature/nova-funcao

# 7. Criar Pull Request no GitHub
# ... abrir PR e aguardar review ...

# 8. Merge after approval
git checkout main
git pull origin main
git merge feature/nova-funcao
git push origin main
```

---

## 📞 Suporte

- 💬 **Dúvidas sobre dev?** [GitHub Discussions](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/discussions)
- 🐛 **Bugs encontrados?** [Abra uma Issue](https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10/issues)
- 📧 **Email:** Veja GITHUB-CONFIG.md

---

**Versão:** 1.0.0  
**Data:** 4 de abril de 2026  
**Compatibilidade:** .NET 10.0+
