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
	* Criamos um novo projeto WPF App (.NET Core) e nomeamos como *MatchGame*. Eu vou criar uma pasta dentro do Chapter1 chamada MatchGame e criar o projeto lá.
		* Por padrão, cria-se um arquivo Main*
	* Usaremos XAML para criar a janela
	* Escreveremos o código C# para adicionar um emoji aleatório à janela
	* O jogo precisa permitir que o usuário clique nos pares para combiná-los
	* Por fim, deixaremos o jogo mais empolgante adicionando um cronômetro*