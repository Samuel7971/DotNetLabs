# 🚀 DotNetLabs

> **Where .NET Concepts Come to Life**

**Uma plataforma colaborativa para aprender .NET através de laboratórios práticos, documentação de qualidade e demonstrações interativas.**

---

# Git Workflow

| Item | Valor |
|------|-------|
| **Documento** | STD-003 |
| **Versão** | 1.0.0 |
| **Status** | Aprovado |
| **Autor** | Samuel Rodrigues |
| **Criado em** | 03/07/2026 |
| **Última atualização** | 03/07/2026 |

---

# 📖 Objetivo

Este documento define o fluxo de trabalho utilizando Git adotado pelo DotNetLabs.

Nosso objetivo é manter um histórico organizado, facilitar futuras contribuições e tornar a evolução do projeto simples de acompanhar.

---

# 🌱 Estratégia de Branches

Inicialmente o projeto utilizará um fluxo simples.

## main

Contém sempre a versão estável do projeto.

Todo código disponível nesta branch deverá estar funcionando.

---

## feature/*

Cada nova funcionalidade deverá ser desenvolvida em sua própria branch.

Exemplos:

```
feature/cancellation-token-lab

feature/blazor-home

feature/authentication-lab
```

---

## docs/*

Alterações exclusivamente de documentação.

Exemplos:

```
docs/roadmap

docs/coding-standards

docs/lab-template
```

---

# 💬 Padrão de Commits

Os commits devem ser pequenos, objetivos e descrever claramente a alteração realizada.

Exemplos:

```
docs: adiciona documento de visão

docs: adiciona ADR-001

feat: cria projeto DotNetLabs.Api

feat: adiciona primeiro Lab de CancellationToken

refactor: reorganiza estrutura dos Labs

fix: corrige comportamento do Playground
```

---

# 🚀 Pull Requests

Sempre que possível, utilizar Pull Requests para integrar alterações na branch principal.

Todo Pull Request deve:

- Possuir um objetivo claro.
- Estar relacionado a uma única funcionalidade.
- Manter a documentação atualizada quando necessário.

---

# 📚 Versionamento

O projeto seguirá o versionamento semântico (Semantic Versioning).

Formato:

```
MAJOR.MINOR.PATCH
```

Exemplo:

```
1.0.0
```

Onde:

- **MAJOR** → Alterações incompatíveis.
- **MINOR** → Novas funcionalidades.
- **PATCH** → Correções.

---

# 📋 Boas Práticas

- Commits pequenos.
- Commits frequentes.
- Mensagens descritivas.
- Evitar commits contendo múltiplos assuntos.
- Atualizar documentação sempre que necessário.

---

# 💡 Exemplo de Fluxo

```
main

↓

feature/cancellation-token

↓

Desenvolvimento

↓

Commit

↓

Push

↓

Pull Request

↓

Merge

↓

main
```

---

## Informações do Documento

| Item | Valor |
|------|-------|
| **Responsável** | Samuel Rodrigues |
| **Projeto** | DotNetLabs |
| **Tipo** | Git Workflow |
| **Identificador** | STD-003 |
| **Licença** | MIT |

---

**DotNetLabs** — Um bom histórico Git conta a história da evolução do projeto.