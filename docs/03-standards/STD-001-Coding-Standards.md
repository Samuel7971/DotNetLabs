# 🚀 DotNetLabs

> **Where .NET Concepts Come to Life**

**Uma plataforma colaborativa para aprender .NET através de laboratórios práticos, documentação de qualidade e demonstrações interativas.**

---

# Padrões de Código

| Item | Valor |
|------|-------|
| **Documento** | STD-001 |
| **Versão** | 1.0.0 |
| **Status** | Aprovado |
| **Autor** | Samuel Rodrigues |
| **Criado em** | 03/07/2026 |
| **Última atualização** | 03/07/2026 |

---

# 📖 Objetivo

Este documento define os padrões de desenvolvimento utilizados no DotNetLabs.

Seu objetivo é garantir consistência, legibilidade e facilidade de manutenção em todo o projeto.

Sempre que possível, seguimos as convenções oficiais da Microsoft para desenvolvimento em .NET.

---

# 🎯 Princípios

Todo código deve ser:

- Simples
- Legível
- Consistente
- Fácil de manter
- Fácil de testar

Escrevemos código pensando na próxima pessoa que irá lê-lo.

---

# 🏛 Convenções Gerais

## Idioma

- Código sempre em inglês.
- Documentação em português.
- Comentários somente quando realmente agregarem valor.

---

## Nullable Reference Types

Todos os projetos deverão utilizar **Nullable Reference Types** habilitado.

```xml
<Nullable>enable</Nullable>
```

---

## Implicit Usings

Todos os projetos deverão utilizar:

```xml
<ImplicitUsings>enable</ImplicitUsings>
```

---

## Namespaces

Utilizar **File Scoped Namespace**.

**Correto**

```csharp
namespace DotNetLabs.Api.Services;
```

Evitar:

```csharp
namespace DotNetLabs.Api.Services
{
}
```

---

# 📦 Organização dos Arquivos

Cada arquivo deverá conter apenas uma classe principal.

Exemplo:

```
Services
│
└── CancellationTokenService.cs
```

---

# 🏷 Nomeação

Utilizar sempre:

| Elemento | Convenção |
|----------|-----------|
| Classe | PascalCase |
| Interface | Prefixo I |
| Método | PascalCase |
| Propriedade | PascalCase |
| Campo privado | _camelCase |
| Constantes | PascalCase |
| Variáveis locais | camelCase |

---

# 💡 Uso do var

Utilizar `var` quando o tipo for evidente.

**Correto**

```csharp
var usuario = new Usuario();
```

Evitar:

```csharp
Usuario usuario = new Usuario();
```

Quando o tipo não for evidente, declarar explicitamente.

---

# 🔒 Modificadores de acesso

Sempre declarar explicitamente o modificador de acesso.

**Correto**

```csharp
public class UsuarioService
```

Evitar depender do modificador padrão da linguagem.

---

# 🧩 Classes

Cada classe deve possuir uma única responsabilidade.

Sempre que possível seguir o princípio **SRP (Single Responsibility Principle)**.

---

# 📝 Métodos

Métodos devem ser:

- Pequenos
- Objetivos
- Fáceis de testar

Sempre que possível:

- Fazer uma única coisa.
- Possuir nomes que expressem claramente sua intenção.

---

# 🚫 Comentários

Evitar comentários para explicar código.

Prefira escrever código autoexplicativo.

Comentários são recomendados apenas para:

- Explicar decisões arquiteturais.
- Alertar sobre regras de negócio importantes.
- Documentação XML de APIs públicas quando fizer sentido.

---

# ❌ Tratamento de Exceções

Nunca capturar exceções apenas para ignorá-las.

Evitar:

```csharp
catch
{
}
```

Toda exceção tratada deve possuir um propósito claro.

---

# 🧪 Testabilidade

Sempre que possível, escrever código pensando em testes automatizados.

Evitar forte acoplamento.

Preferir injeção de dependências.

---

# 📚 Referências

Os padrões descritos neste documento são baseados em:

- Convenções oficiais da Microsoft para C#
- .NET Coding Conventions
- Clean Code
- Clean Architecture

Quando houver conflito entre padrões, a equipe deverá registrar uma nova ADR para documentar a decisão adotada.

---

## Informações do Documento

| Item | Valor |
|------|-------|
| **Responsável** | Samuel Rodrigues |
| **Projeto** | DotNetLabs |
| **Tipo** | Padrão de Desenvolvimento |
| **Identificador** | STD-001 |
| **Licença** | MIT |

---

**DotNetLabs** — Código limpo é uma forma de comunicação entre desenvolvedores.