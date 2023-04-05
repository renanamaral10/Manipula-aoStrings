namespace ManipulaçaoStrings.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Frase em letras maiúsculas: " + frase.ToUpper());
            Console.WriteLine("Frase em letras minúsculas: " + frase.ToLower());
            Console.WriteLine("Quantidade de caracteres da frase: " + frase.Length);

            string[] palavras = frase.Split(' ');
            Console.WriteLine("Primeira palavra da frase: " + palavras[0]);
            Console.WriteLine("Última palavra da frase: " + palavras[palavras.Length - 1]);
        }
    }
}