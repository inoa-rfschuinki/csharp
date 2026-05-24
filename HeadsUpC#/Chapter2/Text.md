## Anatomia de um programa C#
* O código de todo programa C# é estruturado exatamente do mesmo modo. Todos os programas usam namespaces, classes e métodos para tornar o código mais fácil de gerenciar.
* Ao criar classes, define-se namespaces para que essas classes fiquem separadas daquelas que vêm com o .NET.
* Uma classe contém uma parte do programa, embora programas muito pequenos possam ter apenas uma classe.
* Uma classe tem um ou mais métodos, que sempre devem residir dentro dela.
* Os métodos são compostos de declarações, como a declaração Console.WriteLine que o aplicativo HelloWorld.cs usou para escrever uma linha no console.
	* Uma declaração realiza uma única ação. Quando o programa chama um método, ele executa a primeira declaração, depois a próxima e assim por diante.
	* Quando o método fica sem declarações, ou chega na declaração return, ele termina e a execução do programa retoma após a declaração que chamou originalmente o método.
	* Método não é sinônimo de função, mas é um parente muito próximo.
* A ordem dos métodos no arquivo de classe não importa. O método 2 pode vir antes do método 1 sem problemas, ou seja, é apenas uma definição.

## Momento da criação de um projeto no Visual Studio
* Quando se cria um novo projeto no Visual Studio, ele não cria apenas um arquivo de código limpo; ele monta uma estrutura de pastas e arquivos de configuração que servem como infraestrutura para o aplicativo.
* São os mais relevantes:
	* Arquivo da Solução (.sln): contém informações sobre a solução, como quais projetos ela contém e onde estão localizados.
	* Arquivo do Projeto (.csproj): contém informações sobre o projeto, como quais arquivos de código ele inclui, quais dependências ele tem e como ele deve ser compilado.
		* Dentro de uma solução pode haver vários projetos, cada um com seu próprio arquivo .csproj. Por exemplo, uma solução pode conter um projeto para a aplicação principal e outro para testes unitários.
	* Pasta obj (invisível): contém arquivos temporários usados durante o processo de construção do projeto.
	* Pasta bin (invisível): contém os arquivos compilados do projeto, como o executável (.exe) ou a biblioteca (.dll) resultante da construção do projeto.

## Namespace, classes e métodos
* Duas classes podem estar no mesmo namespace, mas não podem ter o mesmo nome. Se isso acontecer, o compilador não saberá a qual classe você está se referindo quando tentar usá-la.
* Dentro de um namespace, caso haja mais de uma classe e seus métodos sejam public, eles podem chamar uns aos outros diretamente, sem precisar usar o nome da classe. Se os métodos forem private, eles só poderão chamar outros métodos dentro da mesma classe.
* Exemplo: se dentro do namespace houver as classes A e B, com B possuindo o método público B1, então o método A1 da classe A pode chamar B1 diretamente, sem precisar usar o nome da classe B. No entanto, se B1 for privado, A1 não poderá chamá-lo diretamente e precisará de um método público em B para acessar B1.
* Caso não estivessem no mesmo namespace, A1 precisaria usar o nome da classe B para chamar B1, mesmo que B1 fosse público. Por exemplo, A1 poderia chamar B.B1() para acessar o método B1 da classe B.
* É possível dividir uma classe em vários arquivos usando a palavra-chave partial. Isso é útil para organizar o código, especialmente em projetos grandes, permitindo que diferentes partes da classe sejam mantidas em arquivos separados. No entanto, todas as partes da classe devem estar no mesmo namespace e ter o mesmo nome de classe para que o compilador as trate como uma única classe.
* A ordem das declarações dentro de um método é importante, pois elas são executadas sequencialmente. Se uma declaração depende de outra, a declaração dependente deve vir depois da declaração da qual ela depende. Por exemplo, se uma declaração A usa uma variável que é declarada na declaração B, então a declaração B deve vir antes da declaração A para que o código funcione corretamente.
* As declarações podem ser de vários tipos, como declarações de variáveis, chamadas de métodos, estruturas de controle (como if, for, while), entre outras. Cada tipo de declaração tem sua própria sintaxe e regras de uso, mas todas elas contribuem para a lógica e o fluxo do programa.
* Em resumo, a estrutura de um programa C# é composta por namespaces, classes e métodos, onde as declarações dentro dos métodos são executadas em ordem sequencial. A organização do código em namespaces e classes ajuda a manter o código limpo e gerenciável, especialmente em projetos maiores.
* Um dos namespaces mais úteis do .NET Core é o System, que contém muitas classes e métodos úteis para tarefas comuns, como manipulação de strings, entrada e saída, e muito mais. Para usar as classes e métodos do namespace System, é necessário incluir a diretiva using System; no início do arquivo de código. Isso permite que você acesse diretamente as classes e métodos do namespace System sem precisar usar o nome completo do namespace a cada vez.

## Declarações e expressões
* Um aplicativo é composto por classes e essas classes contêm métodos que contêm declarações.
* Existem quatro tipos de declarações muito usados:
	* Usamos variáveis e declarações de variáveis para armazenar dados. Por exemplo, int x = 5; é uma declaração de variável que cria uma variável do tipo inteiro chamada x e a inicializa com o valor 5.
	* Usamos operadores matemáticos para realizar cálculos. Por exemplo, int sum = x + 10; é uma declaração que usa o operador de adição para calcular a soma de x e 10, armazenando o resultado na variável sum.
	* Usamos condicionais para tomar decisões com base em certas condições. Por exemplo, if (x > 10) { Console.WriteLine("x é maior que 10"); } é uma declaração condicional que verifica se x é maior que 10 e, se for, imprime uma mensagem no console.
	* Usamos loops para repetir um bloco de código várias vezes. Por exemplo, for (int i = 0; i < 5; i++) { Console.WriteLine(i); } é uma declaração de loop que imprime os números de 0 a 4 no console.
* Variáveis: são usadas para armazenar dados temporariamente durante a execução do programa. Elas têm um tipo específico (como int, string, etc.) e um nome que é usado para referenciá-las no código.
	* Para usar uma variável, é preciso atribuir um valor a ela. Isso pode ser feito no momento da declaração, como int x = 5;, ou posteriormente, como x = 10;.
	* Caso contrário, o programa não irá compilar, pois o C# exige que todas as variáveis sejam inicializadas antes de serem usadas.
	* É importante escolher nomes de variáveis significativos, que descrevam claramente o propósito da variável, para tornar o código mais legível e fácil de entender.
* Os tipos de variáveis serão abordados no capítulo 4, mas os mais importantes são:
	* int: usado para armazenar números inteiros, como 1, 2, 3, etc.
	* string: usado para armazenar sequências de caracteres, como "Olá, mundo!"
	* bool: usado para armazenar valores booleanos, que podem ser true (verdadeiro) ou false (falso).
