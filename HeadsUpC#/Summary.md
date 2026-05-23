# Sumário Detalhado: Use a Cabeça! C# (4ª Edição)

## Introdução: Como usar este livro
* Seu cérebro em C#
* Metodologia visual e multissensorial
* O que você precisa para começar

## Capítulo 1: Comece a programar com C#
* **Construindo algo rapidamente!**
* Configurando o ambiente de desenvolvimento (Visual Studio)
* Como funciona a anatomia de um aplicativo C#
* Código por trás das telas: introdução a interfaces e lógica
* *Projeto prático:* Seu primeiro jogo interativo multiplataforma.

## Capítulo 2: Sob o capô
* **Variáveis, condicionais e loops**
* Como o computador lê o seu código
* O uso de tipos de dados (`int`, `string`, `bool`, etc.)
* Tomando decisões com blocos `if/else` e `switch`
* Repetição de código com loops (`while`, `for`, `foreach`)
* Utilizando o Debugger do Visual Studio para rastrear variáveis em tempo real.

## Unity Lab 1: Introdução ao Unity
* Configurando o ambiente de desenvolvimento de jogos 3D
* Integrando scripts C# com componentes do Unity
* Movimentando objetos na tela.

## Capítulo 3: Orientação a Objetos (Get Oriented!)
* **Fazendo o código fazer sentido no mundo real**
* O que são Classes e Objetos?
* Instanciação e referências em memória (o Heap vs. a Stack)
* Métodos, parâmetros, argumentos e valores de retorno
* Propriedades auto-implementadas e campos de suporte.

## Capítulo 4: Tipos e Referências
* **Gerenciando seus dados**
* Diferença crucial entre Tipos de Referência e Tipos de Valor
* O valor de `null` e como evitar o infame erro `NullReferenceException`
* Modificadores de acesso (`public`, `private`, `protected`, `internal`)
* Arrays de elementos e manipulação básica de matrizes.

## Unity Lab 2: Escrevendo Código do Unity
* Manipulação de vetores 3D (`Vector3`)
* Detecção de inputs do jogador em tempo real
* Física básica com *Rigidbodies*.

## Capítulo 5: Encapsulamento
* **Mantendo seus segredos bem guardados**
* O conceito de ocultação de dados (Data Hiding)
* Protegendo os estados internos de uma classe utilizando propriedades
* O uso correto de construtores de classe
* Evitando bugs de segurança através de encapsulamento bem planejado.

## Capítulo 6: Herança e Polimorfismo
* **A árvore genealógica do seu código**
* Reutilização de código através de classes base (Parent) e classes derivadas (Child)
* Sobrescrita de métodos com `virtual` e `override`
* O conceito de polimorfismo: tratando objetos diferentes pela mesma interface comum
* Classes abstratas (`abstract`) e métodos que não possuem corpo próprio.

## Unity Lab 3: Herança no Unity
* Criação de sistemas de inimigos com propriedades herdadas
* Reaproveitamento de mecânicas de física e colisão.

## Capítulo 7: Interfaces e Classes Abstratas
* **Contratos que o seu código deve cumprir**
* O que são Interfaces e por que elas são tão cruciais na arquitetura de software?
* Implementação de múltiplas interfaces em uma única classe
* Upcasting e Downcasting de referências de objetos
* As interfaces nativas do .NET Framework (como `IComparable` e `IComparer` para ordenação).

## Capítulo 8: Coleções e Enums
* **Organizando seus dados eficientemente**
* Limitações de arrays tradicionais vs. o dinamismo das Coleções
* Trabalhando com Listas Genéricas (`List<T>`)
* O poder das chaves/valores com Dicionários (`Dictionary<TKey, TValue>`)
* Filas (`Queue<T>`) e Pilhas (`Stack<T>`)
* Criação e uso de enumerações (`enum`).

## Unity Lab 4: Instanciando Objetos Dinamicamente
* Prefabs no Unity
* Spawning de projéteis e inimigos através de listas e temporizadores em C#.

## Capítulo 9: LINQ (Language Integrated Query)
* **Assuma o controle dos seus dados**
* Consultando coleções como se fossem bancos de dados
* Sintaxe de consulta (Query Syntax) vs. Sintaxe de método (Method Syntax)
* Operadores comuns: `Where`, `Select`, `OrderBy`, `GroupBy`
* Avaliação adiada (Deferred Evaluation) do LINQ.

## Unity Lab 5: Usando LINQ em Jogos
* Seleção inteligente de alvos ou inimigos baseados em distância ou vida restante usando queries LINQ.

## Capítulo 10: Leitura e Escrita de Arquivos (Streams e I/O)
* **Fazendo os dados persistirem na memória**
* O sistema de arquivos do computador e classes utilitárias (`File`, `Directory`)
* O conceito de Streams e fluxos de dados
* Utilizando as classes `StreamWriter` e `StreamReader`
* Serialização e Desserialização de objetos (JSON e binário)
* A interface `IDisposable` e a importância do bloco `using` para gerenciar recursos.

## Capítulo 11: Tratamento de Exceções
* **Preparando seu código para o pior**
* Como antecipar cenários de falhas com blocos `try`, `catch` e `finally`
* Criando suas próprias exceções customizadas
* Tipos nulos (`Nullable<T>` ou `T?`) e o operador de coalescência nula (`??`).

##  Unity Lab 6: Salvando e Carregando Jogos
* Implementação completa de sistema de Save/Load via serialização persistente em disco.

## Capítulo 12: Recursos Avançados
* **Elevando o nível do seu desenvolvimento**
* Métodos de extensão (Extension Methods) para expandir classes seladas
* Métodos Anônimos e Expressões Lambda (`=>`)