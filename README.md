# Prototype Pac-Man

Projeto de estudo em C# que demonstra o padrão de projeto **Prototype** usando os fantasmas do Pac-Man como exemplo.

## Sobre o padrão

O Prototype permite criar novos objetos copiando um objeto existente, chamado protótipo, em vez de configurar cada instância do zero. O objeto-base define o estado inicial; depois, cada cópia pode ser personalizada sem alterar esse protótipo.

Neste projeto:

- `IFantasmaPrototype` define a operação `Clone()` e as operações de exibição e movimento.
- `FantasmaPacMan` implementa o protótipo. Seu método `Clone()` usa `MemberwiseClone()` para criar uma cópia do objeto.
- `Program.cs` cria um fantasma-base e o clona para produzir Blinky, Pinky, Inky e Clyde, alterando os atributos de cada cópia.
- Ao final, o programa exibe novamente o protótipo original para mostrar que as alterações feitas nos clones não mudaram seus valores.

## Estrutura

```text
PrototypePacman/
├── FantasmaPacMan.cs       # Protótipo concreto e implementação de Clone()
├── IFantasmaPrototype.cs   # Interface do protótipo
├── Program.cs              # Criação, clonagem e personalização dos fantasmas
└── PrototypePacman.csproj  # Configuração do projeto .NET
```

## Executar

É necessário ter o SDK do .NET 10 instalado. Na pasta do projeto, execute:

```bash
dotnet run --project PrototypePacman/PrototypePacman.csproj
```

Ou, estando dentro da pasta `PrototypePacman`:

```bash
dotnet run
```

## Observação sobre a clonagem

`MemberwiseClone()` realiza uma **cópia superficial**: os campos de valor são copiados e campos de referência passam a apontar para os mesmos objetos. Neste exemplo, os atributos são strings e um inteiro; a substituição dos valores nos clones não modifica o protótipo. Se o objeto passar a conter referências mutáveis, como listas ou outros objetos que devam ser independentes, será necessário implementar uma estratégia de cópia profunda adequada.
