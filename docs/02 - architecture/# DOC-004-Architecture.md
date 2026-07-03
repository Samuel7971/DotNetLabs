# DOC-004-Architecture

> **Where .NET Concepts Come to Life**

**Uma plataforma colaborativa para aprender .NET através de laboratórios práticos, documentação de qualidade e demonstrações interativas.**

---

# Arquitetura da Solução

| Item | Valor |
|------|-------|
| **Documento** | DOC-004 |
| **Versão** | 1.0.0 |
| **Status** | Aprovado |
| **Autor** | Samuel Rodrigues |
| **Criado em** | 03/07/2026 |
| **Última atualização** | 03/07/2026 |

---

# 📖 Objetivo

Este documento descreve a arquitetura geral do DotNetLabs, apresentando os projetos que compõem a solução, suas responsabilidades e o relacionamento entre eles.

Nosso objetivo é manter uma arquitetura simples, organizada e preparada para crescer com a adição de novos Labs.

---

# 🏛 Visão Geral da Arquitetura

```text
                    DotNetLabs

                         │
        ┌────────────────┼────────────────┐
        │                                 │
        ▼                                 ▼
DotNetLabs.Blazor               DotNetLabs.Api
        │                                 │
        └──────────────┬──────────────────┘
                       ▼
               DotNetLabs.Shared
```

---

# 📦 Projetos

## DotNetLabs.Blazor

Aplicação responsável pela experiência do usuário.

Será o portal onde os Labs poderão ser explorados de forma interativa.

Responsabilidades:

- Navegação
- Interface dos Labs
- Catálogo de conteúdos
- Demonstrações visuais
- Playground

---

## DotNetLabs.Api

Responsável pelas demonstrações executáveis.

Sempre que um Lab precisar simular processamento, concorrência, autenticação ou qualquer outro comportamento de backend, a API será utilizada.

Responsabilidades:

- Endpoints dos Labs
- Processamentos
- Simulações
- Regras de negócio dos exemplos

---

## DotNetLabs.Shared

Biblioteca compartilhada entre Blazor e API.

Responsabilidades:

- DTOs
- Models
- Enums
- Constantes
- Objetos compartilhados

---

# 🧪 Testes

Todos os testes automatizados serão mantidos em projetos separados dentro da pasta `tests`.

Cada projeto principal poderá possuir seu respectivo projeto de testes.

---

# 📚 Documentação

Toda a documentação do projeto estará centralizada na pasta `docs`.

A documentação evolui junto com o software e faz parte do produto.

---

# 🚀 Evolução

A arquitetura foi concebida para permitir a inclusão de novos Labs sem necessidade de alterar sua estrutura principal.

Cada novo Lab deverá seguir os padrões definidos pelo projeto.

---

# 📌 Princípios Arquiteturais

A arquitetura do DotNetLabs busca seguir os seguintes princípios:

- Separação de responsabilidades.
- Baixo acoplamento.
- Alta coesão.
- Reutilização.
- Simplicidade.
- Escalabilidade.
- Facilidade para novos contribuidores.

---

## Informações do Documento

| Item | Valor |
|------|-------|
| **Responsável** | Samuel Rodrigues |
| **Projeto** | DotNetLabs |
| **Tipo** | Documento de Arquitetura |
| **Identificador** | DOC-004 |
| **Licença** | MIT |

---

**DotNetLabs** — Uma arquitetura simples, organizada e preparada para evoluir.