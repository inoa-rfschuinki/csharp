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

## Partindo para o código
* Quando adicionamos uma declaração de um método que ainda não existe, o Visual Studio nos oferece a opção de criar esse método automaticamente. Isso é uma funcionalidade muito útil, pois economiza tempo e reduz a chance de erros de digitação ao criar métodos manualmente.
* Se optarmos por seguir este caminho, o método é implementado com um corpo vazio, ou seja, sem nenhuma declaração dentro dele. Isso nos permite preencher o método com as declarações necessárias posteriormente, conforme a lógica do programa se desenvolve.
* Entretanto, é adicionado um throw new NotImplementedException(); dentro do método, o que significa que, se esse método for chamado antes de ser implementado, ele lançará uma exceção indicando que a funcionalidade ainda não foi implementada. Isso é útil para evitar que o programa execute código incompleto e para lembrar os desenvolvedores de que aquele método precisa ser finalizado antes de ser usado.
* Essa prática é comum durante o desenvolvimento de software, especialmente quando se está seguindo uma abordagem de desenvolvimento orientada a testes (TDD), onde os métodos são criados primeiro para passar nos testes, e depois são implementados com a lógica necessária para que os testes sejam bem-sucedidos.
* Em resumo, a funcionalidade de criação automática de métodos no Visual Studio é uma ferramenta valiosa para agilizar o processo de desenvolvimento, permitindo que os desenvolvedores se concentrem na lógica do programa enquanto o ambiente de desenvolvimento cuida da estrutura básica dos métodos.
* Vamos fazer um exemplo: adicionamos um método OperatorExamples(), que é declarado automaticamente como private static void OperatorExamples() { throw new NotImplementedException(); }.
	* Podemos declarar uma variável inteira como int a = 10; e outra como int b = 5;.
		* Sobre o tamanho de uma variável int: em C#, o tipo int é um tipo de valor que ocupa 4 bytes (32 bits) de memória e pode armazenar valores inteiros que variam de -2.147.483.648 a 2.147.483.647. Ele é amplamente utilizado para representar números inteiros em programas, como contadores, índices de arrays, e muito mais. O tipo int é parte dos tipos numéricos primitivos em C# e é otimizado para desempenho em operações matemáticas e aritméticas.
	* Podemos usar o operador ++ para incrementar o valor de a, como a++;, o que fará com que a passe a valer 11.
	* Podemos operar com essas variáveis, como int sum = a + b;, o que resultará em sum valendo 16.
	* Podemos declarar o resultado no console, usando Console.WriteLine($"A soma de a e b é: {sum}");, o que imprimirá "A soma de a e b é: 16" no console.
	* Podemos também usar outros operadores, como -, *, /, %, etc., para realizar diferentes operações matemáticas com as variáveis.
	* Podemos declarar uma variável booleana para verificar se a é maior que b, como bool isAGreaterThanB = a > b;, o que resultará em isAGreaterThanB valendo true, já que 11 é maior que 5.
		* Sobre o tamanho de uma variável booleana: em C#, o tipo bool é um tipo de valor que ocupa 1 byte de memória e pode armazenar apenas dois valores: true (verdadeiro) ou false (falso). Ele é usado para representar condições lógicas e é fundamental para a tomada de decisões em programas, como em declarações condicionais e loops. O tamanho do tipo bool é fixo, independentemente do valor que ele armazena, e é otimizado para eficiência em operações lógicas.
	* Podemos usar essa variável booleana em uma declaração condicional, como if (isAGreaterThanB) { Console.WriteLine("a é maior que b"); }, o que imprimirá "a é maior que b" no console, confirmando a comparação entre as duas variáveis.
	* Por fim, também podemos declarar uma variável string para armazenar uma mensagem, como string message = "Operadores em C# são poderosos!";, e imprimir essa mensagem no console usando Console.WriteLine(message);, o que exibirá "Operadores em C# são poderosos!" no console.
		* Sobre o tamanho das strings: em C#, as strings são objetos imutáveis, o que significa que uma vez criadas, seu conteúdo não pode ser alterado. Quando você modifica uma string, na verdade está criando uma nova string com o novo conteúdo. Portanto, o tamanho de uma string pode variar dependendo do conteúdo que ela armazena, e não há um limite fixo para o tamanho de uma string em C#. No entanto, é importante lembrar que strings muito grandes podem consumir muita memória e afetar o desempenho do programa, então é sempre bom ter cuidado ao lidar com strings extensas.
		* É possível concatenar strings usando o operador +, como string fullMessage = message + " Vamos aprender mais sobre elas!";, o que resultará em fullMessage valendo "Operadores em C# são poderosos! Vamos aprender mais sobre elas!".

## Usando o depurador para entender o fluxo do programa
* O depurador é uma ferramenta essencial para entender o fluxo de execução do programa e identificar possíveis erros. 
* Ele permite que você execute o código passo a passo, inspecione variáveis e veja como o estado do programa muda ao longo do tempo.
* É possível adicionar pontos de interrupção, o que permite pausar a execução do programa em um ponto específico e examinar o estado do programa naquele momento. Isso é especialmente útil para identificar onde um erro está ocorrendo ou para entender como uma determinada parte do código está funcionando.
* A janela Locais mostra as variáveis locais e seus valores atuais, o que é útil para verificar se as variáveis estão armazenando os valores esperados durante a execução do programa.
* A janela Pilha de Chamadas exibe a sequência de chamadas de métodos que levaram ao ponto atual de execução, o que ajuda a entender como o programa chegou a um determinado estado.
* O depurador também permite que você modifique o valor das variáveis em tempo real, o que pode ser útil para testar diferentes cenários ou para corrigir um erro temporariamente para continuar a execução do programa.

## Usando operadores para trabalhar com variáveis
* Na maioria das vezes, deseja-se que o código faça algo com base em um valor de uma variável.
* Para isso, é possível usar operadores. São eles:
	* Operadores de Igualdade: == (igual a), != (diferente de)
		* Um erro comum aqui é confundir com o operador de atribuição =, que é usado para atribuir um valor a uma variável. Por exemplo, int x = 5; é uma declaração de variável que atribui o valor 5 à variável x, enquanto if (x == 5) { ... } é uma declaração condicional que verifica se x é igual a 5.
		* Nesse caso, o erro deve aparecer como um erro de compilação, indicando que o operador de atribuição não pode ser usado em um contexto onde se espera uma expressão booleana. O compilador espera uma expressão que possa ser avaliada como verdadeira ou falsa, e o operador de atribuição não retorna um valor booleano, o que causa o erro.
	* Operadores Relacionais: > (maior que), < (menor que), >= (maior ou igual a), <= (menor ou igual a)
	* Operadores Lógicos: && (E lógico), || (OU lógico), ! (NÃO lógico)
* Há também operadores de atribuição, como +=, -=, *=, /=, etc., que combinam uma operação com a atribuição. Por exemplo, x += 5; é equivalente a x = x + 5; e incrementa o valor de x em 5.
* E, por fim, há operadores de incremento e decremento, como ++ e --, que aumentam ou diminuem o valor de uma variável em 1. Por exemplo, x++; é equivalente a x = x + 1; e incrementa o valor de x em 1.

## Fluxos condicionais e loops
* Usa-se declarações if para executar um bloco de código apenas se uma condição for verdadeira. Por exemplo, if (x > 10) { Console.WriteLine("x é maior que 10"); } executará o bloco de código dentro das chaves apenas se x for maior que 10.
* Usa-se declarações else para executar um bloco de código se a condição do if for falsa. Por exemplo, if (x > 10) { Console.WriteLine("x é maior que 10"); } else { Console.WriteLine("x é menor ou igual a 10"); } executará o primeiro bloco de código se x for maior que 10 e o segundo bloco se x for menor ou igual a 10.
* Usa-se declarações else if para verificar múltiplas condições. Por exemplo, if (x > 10) { Console.WriteLine("x é maior que 10"); } else if (x == 10) { Console.WriteLine("x é igual a 10"); } else { Console.WriteLine("x é menor que 10"); } verificará se x é maior que 10, igual a 10 ou menor que 10 e executará o bloco de código correspondente.
* Usa-se loops for para repetir um bloco de código um número específico de vezes. Por exemplo, for (int i = 0; i < 5; i++) { Console.WriteLine(i); } imprimirá os números de 0 a 4 no console.
* Usa-se loops while para repetir um bloco de código enquanto uma condição for verdadeira. Por exemplo, int i = 0; while (i < 5) { Console.WriteLine(i); i++; } também imprimirá os números de 0 a 4 no console, mas usando um loop while em vez de um loop for.
* Usa-se loops do-while para garantir que um bloco de código seja executado pelo menos uma vez, mesmo que a condição seja falsa. Por exemplo, int i = 0; do { Console.WriteLine(i); i++; } while (i < 5); também imprimirá os números de 0 a 4 no console, mas garantirá que o bloco de código seja executado pelo menos uma vez, mesmo que i já seja maior ou igual a 5 no início do loop.
* É importante usar loops e declarações condicionais de forma adequada para evitar loops infinitos ou condições que nunca sejam atendidas, o que pode levar a um programa que não termina ou que não se comporta como esperado. Sempre verifique as condições de saída dos loops e as condições dos if para garantir que o código funcione corretamente.

## Snippets de Código
* O Visual Studio oferece uma funcionalidade chamada snippets de código, que são trechos de código pré-definidos que podem ser inseridos rapidamente no editor. Isso é especialmente útil para economizar tempo e evitar erros de digitação ao escrever código comum, como loops, declarações condicionais, métodos, etc.
* Um exemplo de snippet de código é o for, que pode ser inserido digitando "for" e pressionando a tecla Tab. Isso gerará um loop for básico com a estrutura correta, onde você pode preencher os detalhes do loop, como a variável de controle, a condição de término e o incremento.
* Outro exemplo é o if, que pode ser inserido digitando "if" e pressionando Tab. Isso criará uma estrutura de declaração condicional básica, onde você pode preencher a condição e o bloco de código a ser executado se a condição for verdadeira.
* Além disso, existem snippets para outros tipos de código, como while, do-while, switch, try-catch, entre outros. Esses snippets ajudam a acelerar o processo de escrita de código e garantem que a sintaxe esteja correta desde o início.
* É possível personalizar os snippets de código ou criar seus próprios snippets para atender às necessidades específicas do seu projeto. O Visual Studio permite que você gerencie e edite os snippets de código através das opções de configuração, tornando essa ferramenta ainda mais flexível e útil para os desenvolvedores.
* Em resumo, os snippets de código são uma funcionalidade valiosa do Visual Studio que ajuda a economizar tempo e reduzir erros ao escrever código comum. Eles fornecem uma maneira rápida e fácil de inserir estruturas de código pré-definidas, permitindo que os desenvolvedores se concentrem na lógica do programa em vez de se preocupar com a sintaxe básica.

## Revisão parcial
* Toda declaração precisa terminar com ponto e vírgula (;).
* Comentários são usados para explicar o código e não são executados pelo programa. Eles podem ser de linha única (//) ou de múltiplas linhas (/* */).
* As variáveis são declaradas com um tipo específico e um nome, e devem ser inicializadas antes de serem usadas.
* Condicionais são bons para tomar decisões com base em certas condições, usando if, else if e else.
* Loops são usados para repetir um bloco de código várias vezes, usando for, while ou do-while. Pode ser infinito.

## Aplicativo
* No restante do capítulo, vamos criar um aplicativo chamado ExperimentWithControls, em outro repositório.