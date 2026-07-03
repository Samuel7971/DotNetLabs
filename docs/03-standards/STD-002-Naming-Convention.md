# 🚀 DotNetLabs

> **Where .NET Concepts Come to Life**

**Uma plataforma colaborativa para aprender .NET através de laboratórios práticos, documentação de qualidade e demonstrações interativas.**

---

# Convenção de Nomenclatura

| Item | Valor |
|------|-------|
| **Documento** | STD-002 |
| **Versão** | 1.0.0 |
| **Status** | Aprovado |
| **Autor** | Samuel Rodrigues |
| **Criado em** | 03/07/2026 |
| **Última atualização** | 03/07/2026 |

---

# 📖 Objetivo

Este documento define as convenções de nomenclatura adotadas pelo DotNetLabs.

O objetivo é garantir consistência entre todos os projetos, facilitando a leitura, manutenção e evolução da solução.

---

# 🌍 Idioma

O DotNetLabs busca seguir as boas práticas utilizadas pela plataforma .NET, mas também considera o contexto da equipe que irá utilizá-lo.

Por esse motivo, adotamos as seguintes diretrizes:

- A documentação oficial será escrita em português.
- Os exemplos de código poderão utilizar nomes em português ou inglês, de acordo com o objetivo do Lab.
- Sempre que um exemplo representar um cenário real de mercado ou uma API pública, será dada preferência ao uso do inglês.
- Quando o objetivo for ensinar um conceito de forma mais acessível para a equipe, o uso do português é totalmente aceitável.

Mais importante do que o idioma é manter consistência dentro de cada Lab.

## 📌 Exemplos

O idioma utilizado deve sempre considerar o objetivo do Lab.

### Exemplo 1 — Conceitos de programação

Quando o foco é ensinar um conceito da linguagem, um padrão de projeto ou uma técnica de desenvolvimento, utilizar nomes em português pode facilitar a compreensão da equipe.

**Exemplo**

```csharp
var pedido = new PedidoBuilder()
    .ComCliente(cliente)
    .ComEndereco(endereco)
    .ComPagamento(cartao)
    .Build();
```

Neste caso, o objetivo é ensinar o padrão **Builder**, e não vocabulário em inglês.

---

### Exemplo 2 — Tecnologias e APIs

Quando o Lab reproduzir cenários encontrados na documentação oficial da Microsoft ou em APIs amplamente utilizadas pela comunidade .NET, recomenda-se manter a nomenclatura em inglês.

**Exemplo**

```csharp
var authenticationService = new AuthenticationService();

var request = new LoginRequest();

var response = await authenticationService.LoginAsync(request);
```

Essa abordagem facilita a associação entre o conteúdo do Lab e a documentação oficial.

---

### Regra Geral

Mais importante do que o idioma utilizado é manter consistência dentro do próprio Lab.

Evite misturar português e inglês na mesma implementação.

**Evite**

```csharp
var pedido = new Order();

var usuario = new User();

var authenticationService = new ServicoAutenticacao();
```

**Prefira manter um único padrão dentro do contexto do Lab.**

---

# 📦 Projetos

Os projetos devem seguir o padrão:

```text
DotNetLabs.<Projeto>
```

Exemplos:

- DotNetLabs.Api
- DotNetLabs.Blazor
- DotNetLabs.Shared

---

# 🗂 Namespaces

Os namespaces devem refletir a estrutura de pastas.

Exemplo:

```csharp
namespace DotNetLabs.Api.Services;
```

---

# 📄 Arquivos

O nome do arquivo deve ser o mesmo da classe principal.

Exemplo:

```
CancellationTokenService.cs
```

---

# 🧩 Classes

Utilizar substantivos ou papéis bem definidos.

Exemplos:

- UserService
- AuthenticationService
- LabCatalog
- CancellationProcessor

---

# 🔌 Interfaces

Sempre utilizar o prefixo **I**.

Exemplos:

- IUserRepository
- IAuthenticationService
- ILabProvider

---

# 📥 Requests

Todos os objetos de entrada devem utilizar o sufixo **Request**.

Exemplos:

- LoginRequest
- CancellationRequest

---

# 📤 Responses

Todos os objetos de saída devem utilizar o sufixo **Response**.

Exemplos:

- LoginResponse
- CancellationResponse

---

# ⚙️ Services

Toda classe de serviço deve utilizar o sufixo **Service**.

Exemplos:

- AuthenticationService
- CancellationService

---

# 🧪 Testes

Os projetos e classes de teste devem utilizar o sufixo **Tests**.

Exemplos:

- DotNetLabs.Api.Tests
- AuthenticationServiceTests

---

# ⚠️ Exceções

Toda exceção customizada deve utilizar o sufixo **Exception**.

Exemplos:

- ValidationException
- LabNotFoundException

---

# 🔧 Extensions

Classes de extensão devem utilizar o sufixo **Extensions**.

Exemplo:

- ServiceCollectionExtensions

---

# ⚙️ Options

Classes de configuração devem utilizar o sufixo **Options**.

Exemplo:

- JwtOptions

---

# 📚 Considerações Finais

Manter uma nomenclatura consistente reduz ambiguidades, facilita a navegação no projeto e melhora a experiência de novos contribuidores.

Sempre que surgir uma nova convenção de nomenclatura, este documento deverá ser atualizado.

---

## Informações do Documento

| Item | Valor |
|------|-------|
| **Responsável** | Samuel Rodrigues |
| **Projeto** | DotNetLabs |
| **Tipo** | Convenção de Nomenclatura |
| **Identificador** | STD-002 |
| **Licença** | MIT |

---

**DotNetLabs** — Bons nomes tornam o código mais fácil de compreender.