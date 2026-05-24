## Explicações gerais
* C# revela o mundo .NET, uma plataforma de código aberto muito poderosa para criar todo tipo de aplicação.
* O Visual Studio Code é um editor de texto multiplataforma, mas não é adaptado ao desenvolvimento .NET como é o Visual Studio.
* Vamos instalar o Unity em outro momento, separado da instalação do Visual Studio (que deve vir junto com .NET Desktop Development e .NET Core Cross-Platform Development)
* É possível rodar no Mac.
* Todo app de console .NET CORE funciona no Windows e no Mac. 
* O IDE (Ambiente de Desenvolvimento Integrado) é um editor de texto, designer visual, gerenciador de arquivos, depurador etc. É como um canivete suíço. 
* O Visual Studio ajuda em:
	* Criar aplicação fácil
	* Desenvolver interface de usuário usando C# com XAML (Extensible Application Markup Language). Para o caso do Mac, usa-se HTML.

## Criando um projeto
* A melhor maneira de aprender C# é escrever código. Vamos no Visual Studio e clicamos em "Create a new project".
* Escolhemos o "Console App (.NET Core)", nomeando-o como *MeuPrimeiroApp* e clicamos em "Create".
* Quando o Visual Studio cria um novo projeto, ele dá um ponto de partida. Quando o projeto aparecer, deve surgir com um arquivo Program.cs
* Podemos executá-lo usando o Play, no topo da tela, e selecionando nosso projeto.
* Nesse momento, a janela de depuração do Microsoft Visual Studio abrirá mostrando a saída do programa, que é um Hello World.*
* Adicionei o "Hello World" nessa pasta.

## Criando o primeiro jogo
* Vamos criar algo um pouco mais complexo. Agora, será um jogo de combinação. Surgem 16 figuras e o objetivo é clicar simultaneamente nos pares no menor tempo possível.
* WPF significa Windows Presentation Foundation, que é uma tecnologia da Microsoft para criar interfaces gráficas ricas para aplicativos de desktop.
* O WPF oferece ferramentas para criar interfaces de usuário modernas e responsivas, com suporte a gráficos vetoriais, animações e estilos personalizados em diversos Windows.
* As versões Mac dos projetos WPF usam o ASP.NET Core, que é uma tecnologia de desenvolvimento web da Microsoft. Ele permite criar aplicativos web modernos e escaláveis usando C# e HTML. Também serve para Windows.
* Passo a Passo para criar o jogo:
	* Criamos um novo projeto WPF App (.NET Core) e nomeamos como *MatchGame*.
  		* Não é possível criar dentro de uma pasta, pois quando crio um WPF App, o Visual Studio já cria com dependências, então não é possível fazer isso dentro de uma pasta.
		* Logo, fechei este projeto aqui e parti para o outro projeto.
	* Usaremos XAML para criar a janela (XAML é uma linguagem de marcação usada para criar interfaces de usuários em apps WPF, baseado em XML)
	* Escreveremos o código C# para adicionar um emoji aleatório à janela
	* O jogo precisa permitir que o usuário clique nos pares para combiná-los
	* Por fim, deixaremos o jogo mais empolgante adicionando um cronômetro

## MatchGame
* Inicialmente, criamos um Aplicativo WPF. Para isso, é necessário ter o Visual Studio bem configurado, caso contrário, tal solução não existe na hora de criar de um projeto (ela não é padrão do Visual Studio).
* Neste ponto, somos apresentados a alguns menus possíveis do Visual Studio:
	* Lista de Erros: aqui, conseguimos visualizar erros que impedem a compilação do projeto (em vermelho), erros que são más práticas (em amarelo, como variáveis declaradas e não usadas) e sugestões de melhorias do código (em azul).
	* Team Explorer: aqui, ocorre o link entre repositórios e a solução local. É possível configurar com o GitHub ou com o AzureOps, por exemplo.
	* Solutions Explorer: aqui, é possível visualizar tudo que há na solução, tendo sido criado pelo usuário ou por padrão, no momento da criação da solução. Tudo que o IDE faz pode se modificado.
	* Toolbox: para projetos WPF, que são focados em Front-End usando XAML, a Toolbox permite um design por arrasto, ou seja, para adicionar um botão, basta arrastar o botão para a solução e o código XAML será gerado automaticamente. Nesse caso, a Toolbox é um estojo de componentes visuais.
* Ao modificar a Window, a IDE altera o XAML e vice-versa. É algo instantâneo. 
* O primeiro uso disso é para adicionar colunas e linhas no Grid. Clicando na borda no Editor XAML, automaticamente surgem linhas e colunas, que se refletem no código com ColumnDefinition e RowDefinition, que são propriedades de Grid. As colunas usam tamanhos proporcionais e remover qualquer informação de tamanho torna-as igualmente espaçadas.
* É possível alterar as propriedades no código ou simplesmente usando a tela de Propriedades do Visual Studio. Ela aparece, normalmente como uma "lâmpada" acima do objeto WPF. Ela permite, graficamente, mudar fonte, espaçamento, margem, centralização etc.
* O WPF usa pixels independentes do dispositivo. Isso permite que o projeto seja adaptável aos dispositivos.
* O projeto em si será adicionado em outro repositório, pois não é possível adicioná-lo aqui. 
	* O procedimento geral foi: iniciamos com a construção do XAML. Uma vez que o Grid estava estabelecido, com divisórias e com os TextBlock, fomos para o código C#. Lá, adicionamos um gerador aleatório de números que substituia cada TextBlock, aleatoriamente, por um emoji dentro de uma lista.
	* Em determinado ponto do projeto, apresenta-se o controle de versão via Git, notavelmente o GitHub (que é um provedor de Git). Apresenta-se a utilização do Team Explorer, tela própria do Visual Studio, que permite o controle de versão via botões, sem necessidade de digitar comandos.
	* Uma vez adicionado o projeto no GitHub, com o esboço da tela pronto, adicionamos um manipulador de eventos, que é o nome do método chamado quando certas ações são realizadas (exemplo: clique).
	* Um comentário de várias linhas no C# é feito com /* */, enquanto um comentário de uma linha é feito com //
	* Para adicionar um manipulador de eventos, voltamos na tela do XAML, clicamos em Propriedades e adicionamos um Evento, notavelmente em MouseDown. Quando colocarmos o nome, ele irá gerar automaticamente um novo método no arquivo C#, que precisa ser construído. A lógica é simples.
	* Depois de adicionar o manipulador de eventos, que já terá toda a lógica do jogo, vamos adicionar um cronômetro, que começa quando o jogador inicia o jogo e pausa quando o último animal é combinado.
  	* Para adicionar o cronômetro, vamos adicionar um novo TextBlock e associá-lo a um novo evento. Quando o clique for efetuado, caso seja o primeiro clique, o temporizador começará a contar. Caso os oito pares sejam encontrados, o temporizador irá pausar e o jogo irá reiniciar.
	* Neste ponto, é apresentado o uso do depurador para descobrir bugs. É útil quando uma exceção surge no código. É de se destacar que exceções são boas práticas, pois garantem que bugs foram identificados. Cada exceção possui um tipo: nesse caso, é uma exceção ArgumentOutOfRangeException.
	* A exceção, nesse caso, aconteceu porque estávamos fazendo um loop foreach em TextBlock, mas quando adicionamos um novo TextBlock, ficamos com mais blocos do que emojis, gerando um ArgumentOutOfRangeException.
	* Apresenta-se, também, a aba Depurar >> Janelas >> Locais, que permite visualizar os valores das variáveis durante a depuração.
	* Como o erro surgiu em uma instrução foreach, é o caso aprofundar o conhecimento nela:
		* Loop é um modo de executar um bloco de código repetidamente. Eles serão aprofundados no capítulo 2.
	* Corrigindo os últimos bugs, chegamos ao ponto onde usamos o Team Explorer para gerar um commit no nosso repositório. O link do repositório é: https://github.com/inoa-rfschuinki/MatchGame

## Considerações Finais
* Sempre que surge um projeto grande, é uma boa ideia dividi-lo em partes menores.

## Resumo Final do Capítulo
* O Visual Studio controla o número de vezes que um método é referenciado em outro lugar no código C# ou XAML.
* O IDE facilita adicionar e gerenciar os métodos do manipulador de eventos.
* Um manipulador de eventos é um método que sua aplicação chama quando ocorre um evento específico, como um clique no mouse, uma tecla pressionada ou o redimensionamento da janela.
* A janela Lista de Erros do IDE mostra qualquer erro que impede a criação do código.
* Os cronômetros executam os métodos do manipulador de eventos Tick repetidamente em um intervalo específico.
* Foreach é um tipo de loop que percorre uma coleção de itens.
* Quando o programa gerar uma exceção, é possível depurar. As exceções são mais fáceis de corrigir quando reproduzidas.
* O Visual Studio facilita usar o controle de versão para fazer backup do código e controlar todas as alterações feitas, usando Git.
