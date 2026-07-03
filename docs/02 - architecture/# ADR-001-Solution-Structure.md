# ADR-001-Solution-Structure

> **Where .NET Concepts Come to Life**

**Uma plataforma colaborativa para aprender .NET através de laboratórios práticos, documentação de qualidade e demonstrações interativas.**

---

# ADR-001 — Estrutura da Solução

| Item | Valor |
|------|-------|
| **Documento** | ADR-001 |
| **Versão** | 1.0.0 |
| **Status** | Aprovado |
| **Autor** | Samuel Rodrigues |
| **Criado em** | 03/07/2026 |
| **Última atualização** | 03/07/2026 |

---

# 📖 Contexto

O DotNetLabs foi concebido para ser uma plataforma de aprendizado de longo prazo.

Com o crescimento do projeto, novos Labs, documentação, testes e aplicações serão adicionados continuamente.

Por esse motivo, desde o início precisamos definir uma estrutura que seja organizada, escalável e simples de compreender.

---

# 🎯 Decisão

A solução será organizada da seguinte forma:

```text
DotNetLabs
│
├── docs
├── src
├── tests
├── samples
├── .github
│
├── README.md
├── LICENSE
└── DotNetLabs.sln
```

---

## Responsabilidade de cada diretório

### docs

Contém toda a documentação oficial do projeto.

---

### src

Contém os projetos que compõem a aplicação.

Exemplos:

- DotNetLabs.Api
- DotNetLabs.Blazor
- DotNetLabs.Shared

---

### tests

Contém todos os projetos de testes automatizados.

---

### samples

Espaço reservado para exemplos independentes dos Labs quando necessário.

---

### .github

Arquivos relacionados ao GitHub, como Workflows, Templates e configurações.

---

# ✅ Benefícios

Esta organização proporciona:

- Separação de responsabilidades.
- Facilidade de navegação.
- Escalabilidade.
- Organização consistente.
- Facilidade para novos contribuidores.

---

# 🔄 Consequências

Toda nova funcionalidade deverá respeitar esta estrutura.

Caso seja necessário alterar a organização da solução no futuro, uma nova ADR deverá ser criada documentando a mudança.

---

# 📌 Status

**Aceita**

Esta decisão passa a fazer parte da arquitetura oficial do DotNetLabs.

---

## Informações do Documento

| Item | Valor |
|------|-------|
| **Responsável** | Samuel Rodrigues |
| **Projeto** | DotNetLabs |
| **Tipo** | Architecture Decision Record |
| **Identificador** | ADR-001 |
| **Licença** | MIT |

---

**DotNetLabs** — Boas arquiteturas começam com boas decisões.