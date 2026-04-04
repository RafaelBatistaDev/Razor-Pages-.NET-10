#!/usr/bin/env bash
# =====================================================================
# Script: Deploy para GitHub
# Descrição: Sincroniza repositório local com GitHub
# =====================================================================

set -euo pipefail

# Cores
G="\e[1;32m" B="\e[1;34m" Y="\e[1;33m" R="\e[1;31m" N="\e[0m"

log()     { echo -e "${B}[INFO]${N}  $*"; }
success() { echo -e "${G}[OK]${N}    $*"; }
warn()    { echo -e "${Y}[WARN]${N}  $*"; }
error()   { echo -e "${R}[ERR]${N}   $*"; exit 1; }

# =====================================================================
# INSTRUÇÕES PARA PUSH
# =====================================================================

log "🚀 Instruções para Sincronizar com GitHub"
echo ""

log "Repositório remoto já está configurado:"
git remote -v

echo ""
log "Status do repositório:"
git log --oneline
echo ""
log "Tags disponíveis:"
git tag -l
echo ""

# =====================================================================
# OPÇÕES DE PUSH
# =====================================================================

echo -e "${B}=== OPÇÃO 1: Push com HTTPS (padrão) ===${N}"
echo "git push origin main"
echo "git push origin v1.0.0"
echo ""

echo -e "${B}=== OPÇÃO 2: Push com SSH (recomendado) ===${N}"
echo "# Primeiro, altere o remote"
echo "git remote set-url origin git@github.com:RafaelBatistaDev/Razor-Pages-.NET-10.git"
echo ""
echo "# Depois, faça o push"
echo "git push -u origin main"
echo "git push -u origin v1.0.0"
echo ""

# =====================================================================
# PRÉ-REQUISITOS
# =====================================================================

echo -e "${B}=== PRÉ-REQUISITOS ===${N}"
echo "✅ Repositório GitHub já deve existir"
echo "   https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10"
echo ""
echo "✅ Autenticação GitHub configurada"
echo "   - HTTPS: Git credencial manager (será solicitado)"
echo "   - SSH: Chave SSH em ~/.ssh/id_rsa"
echo ""

echo -e "${B}=== VERIFICAÇÃO DE CONECTIVIDADE ===${N}"
echo "Testando conexão com GitHub..."
ssh -T git@github.com 2>/dev/null || echo "SSH não está setup (use HTTPS ou configure SSH)"
echo ""

# =====================================================================
# PRÓXIMOS PASSOS
# =====================================================================

success "Repositório local está pronto para push!"
echo ""
echo -e "${B}Próximos passos:${N}"
echo "1. Certifique-se de que o repositório GitHub existe"
echo "2. Escolha HTTPS ou SSH"
echo "3. Execute um dos comandos acima"
echo "4. Verifique em https://github.com/RafaelBatistaDev/Razor-Pages-.NET-10"
echo ""

success "Configuração local completa! ✓"
success "Todos os arquivos profissionais foram criados ✓"
success "Git inicializado com commit e tag v1.0.0 ✓"
