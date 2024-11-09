# Projeto Pokémon 🐉

![Badge](https://img.shields.io/badge/Status-Em%20Desenvolvimento-blue)
![GitHub issues](https://img.shields.io/github/issues/MatheusAV/ProjetoPokemon)
![GitHub stars](https://img.shields.io/github/stars/MatheusAV/ProjetoPokemon)
![GitHub forks](https://img.shields.io/github/forks/MatheusAV/ProjetoPokemon)

## 📝 Descrição

A **Projeto Pokémon** é uma API que consome dados da [PokeAPI](https://pokeapi.co/) para fornecer informações sobre Pokémon, incluindo espécies, tipos e habilidades. A API permite aos usuários consultar detalhes completos sobre os Pokémon.

## 🚀 Funcionalidades

- **Consulta de Pokémon**: Retorna detalhes sobre Pokémon específicos pelo nome.
- **Consulta de Espécies**: Fornece informações detalhadas sobre as espécies dos Pokémon.
- **Consulta de Tipos**: Permite visualizar os tipos de Pokémon e suas interações.
- **Consulta de Habilidades**: Fornece uma descrição das habilidades e como elas afetam os Pokémon.
- **Listagem Completa**: Retorna uma lista com todos os Pokémon disponíveis.

## 📋 Pré-requisitos

- [.NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

## 🛠️ Configuração do Projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/MatheusAV/ProjetoPokemon.git
   cd ProjetoPokemon



2. Restaure os pacotes do projeto:
```bash
 dotnet restore

```

3. Configure a URL base da PokeAPI no arquivo appsettings.json:
```bash
 {
  "PokemonApi": {
    "BaseUrl": "https://pokeapi.co/api/v2"
  }
}


```
4. Execute o projeto:
```bash
 dotnet run

```

    
# 📂 Estrutura do Projeto    

```plaintext
ProjetoPokemon/
├── projetoPokemon.Tests/       # Testes unitários
├── projetoPokemon/
│   ├── Aplication/             # Camada de aplicação com lógica de negócios
│   ├── Controllers/            # Controllers da API
│   ├── Domain/                 # Entidades de domínio
│   ├── Helper/                 # Configurações auxiliares da API
│   ├── Program.cs              # Configuração principal da API
│   ├── appsettings.json        # Configurações da aplicação
└── README.md                   # Documentação do projeto

```


