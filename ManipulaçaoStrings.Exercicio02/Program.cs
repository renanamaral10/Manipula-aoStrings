namespace ManipulaçaoStrings.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] palavras = frase.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?', '-', '(', ')', '[', ']', '{', '}', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int numeroPalavras = palavras.Length;

            Console.WriteLine($"A frase digitada contém {numeroPalavras} palavras.");
        
    }
    }
}