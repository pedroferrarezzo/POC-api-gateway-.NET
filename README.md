# ⚡ POC API Gateway - .NET

<div align="center">

[![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-Programming-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://docs.microsoft.com/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)](LICENSE)

</div>

Projeto de demonstração (POC) para implementação de um API Gateway simples utilizando .NET, direcionando requisições para duas APIs fictícias. Desenvolvido como parte de estudos práticos de arquitetura de microsserviços e gerenciamento de acessos a múltiplas APIs.

<div align="center">
  <a href="#visao-geral">Visão Geral</a> •
  <a href="#arquitetura">Arquitetura</a> •
  <a href="#tecnologias">Tecnologias</a> •
  <a href="#estrutura-do-projeto">Estrutura do Projeto</a> •
  <a href="#instalacao-e-uso">Instalação e Uso</a> •
  <a href="#configuracao">Configuração</a> •
  <a href="#resolucao-de-problemas">Resolução de Problemas</a> •
  <a href="#contribuicao-e-licenca">Contribuição e Licença</a>
</div>

<h2 id="visao-geral">📋 Visão Geral</h2>

Foi implementado um API Gateway simples usando o .NET e direcionando requisições para duas APIs fictícias. Esta é uma implementação básica para fornecer uma compreensão do papel do API Gateway no gerenciamento de acessos a múltiplas APIs. Em cenários reais, a funcionalidade do API Gateway seria muito mais complexa, incluindo autenticação, limitação de requests e balanceamento de carga, entre muitas outras.

### Principais recursos

- **API Gateway em .NET**: Encaminha requisições para múltiplas APIs
- **APIs Fictícias**: Simulam serviços backend distintos
- **Configuração Simples**: Foco didático para entendimento de roteamento
- **Pronto para Extensão**: Estrutura básica para adicionar autenticação, rate limiting, etc.

<h2 id="arquitetura">🏗️ Arquitetura</h2>

<details>
<summary>Expandir para mais detalhes</summary>

### Diagrama de Arquitetura

```mermaid
graph TD
    Client[Usuário/Cliente] --> Gateway[API Gateway (.NET)]
    Gateway --> API1[API 1 - Fictícia]
    Gateway --> API2[API 2 - Fictícia]
```

### Componentes

- **API Gateway**: Responsável por receber todas as requisições externas e encaminhá-las para a API correta.
- **APIs Fictícias**: Simulam serviços reais, podendo ser substituídas por APIs reais em cenários de produção.

</details>

<h2 id="tecnologias">🔧 Tecnologias</h2>

<details>
<summary>Expandir para mais detalhes</summary>

- **.NET 9.0**: Plataforma principal para desenvolvimento do gateway e das APIs
- **C#**: Linguagem de programação utilizada
- **ASP.NET Core**: Framework para construção de APIs
- **Swagger/OpenAPI**: Documentação interativa das APIs

</details>

<h2 id="estrutura-do-projeto">📁 Estrutura do Projeto</h2>

<details>
<summary>Expandir para mais detalhes</summary>

```
POC-api-gateway-.NET/
│
├── api/                # API fictícia 1
│   ├── Program.cs
│   ├── appsettings.json
│   └── ...
│
├── api-gateway/        # API Gateway principal
│   ├── Program.cs
│   ├── appsettings.json
│   └── ...
│
├── asdasd.sln          # Solution file
├── LICENSE             # Licença do projeto
└── README.md           # Documentação principal
```

</details>

<h2 id="instalacao-e-uso">🚀 Instalação e Uso</h2>

<details>
<summary>Expandir para mais detalhes</summary>

### Pré-requisitos

- **.NET 9.0 SDK**: [Download](https://dotnet.microsoft.com/download)
- **Git**: Para clonar o repositório

### Passos para execução

```powershell
# 1. Clone o repositório
git clone <repository-url>
cd POC-api-gateway-.NET

# 2. Restaure os pacotes
dotnet restore

# 3. Execute as APIs fictícias e o API Gateway (em terminais separados)
cd api
# Porta padrão: 5000
dotnet run --urls http://localhost:5000

# Em outro terminal:
cd ../api-gateway
# Porta padrão: 5001
dotnet run --urls http://localhost:5001
```

### Testando as rotas

- Acesse o API Gateway em: [http://localhost:5001](http://localhost:5001)
- Utilize ferramentas como Postman, Insomnia ou o Swagger para testar as rotas expostas pelo gateway.

</details>

<h2 id="configuracao">⚙️ Configuração</h2>

<details>
<summary>Expandir para mais detalhes</summary>

- As configurações de endpoints das APIs podem ser ajustadas nos arquivos `appsettings.json` de cada projeto.
- Para adicionar autenticação, limitação de requisições ou outras funcionalidades, utilize middlewares do ASP.NET Core.

</details>

<h2 id="resolucao-de-problemas">🔍 Resolução de Problemas</h2>

<details>
<summary>Expandir para mais detalhes</summary>

### Problemas Comuns

#### 1. Porta em uso

Se ao executar `dotnet run` aparecer erro de porta em uso:

```powershell
# Encerre o processo que está usando a porta
Get-Process -Id (Get-NetTCPConnection -LocalPort 5000).OwningProcess | Stop-Process
Get-Process -Id (Get-NetTCPConnection -LocalPort 5001).OwningProcess | Stop-Process
```

#### 2. Erro de dependências

Certifique-se de executar `dotnet restore` antes de rodar o projeto.

#### 3. APIs não respondem

Verifique se ambas as APIs estão rodando nas portas corretas e se o API Gateway está configurado para encaminhar as requisições corretamente.

</details>

<h2 id="contribuicao-e-licenca">🙏 Contribuição e Licença</h2>

### Guia de Contribuição

- Fork este repositório e crie uma branch para sua feature ou correção.
- Siga o padrão de commits [Conventional Commits](https://www.conventionalcommits.org/).
- Abra um Pull Request detalhando as alterações realizadas.

### Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

<div align="center">

**⭐ Se este projeto foi útil, considere dar uma estrela!**

[⬆ Voltar ao topo](#-poc-api-gateway---net)

</div>
