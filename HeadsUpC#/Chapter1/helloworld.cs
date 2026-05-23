class Program { // Quando o Visual Studio cria um novo projeto Aplicativo de Console, ele adiciona automaticamente a classe chamada Program
    static void Main() {
        Console.WriteLine("Hello, World!");
        // O método Main é o ponto de entrada do programa, ou seja, é onde a execução do programa começa.
        // O método Main é declarado como static, o que significa que ele pode ser chamado sem criar uma instância da classe Program.
        // Ele é declarado como void, o que significa que ele não retorna nenhum valor.
        // O método WriteLine da classe Console é usado para imprimir a string "Hello, World!" no console.
        // Console é uma classe estática (já vem na linguagem) que fornece métodos para interagir com o console, como ler e escrever texto.
        // WriteLine é um método que escreve a string fornecida seguida por uma nova linha, ou seja, ele move o cursor para a próxima linha após imprimir a mensagem.
        // WriteLine é um método estático, o que significa que ele pode ser chamado diretamente na classe Console sem a necessidade de criar uma instância da classe.
    }
}