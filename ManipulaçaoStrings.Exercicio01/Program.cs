namespace ManipulaçaoStrings.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] palavras = frase.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                if (palavras[i].Length > 0)
                {
                    char primeiraLetra = char.ToUpper(palavras[i][0]);
                    string restoDaPalavra = palavras[i].Substring(1).ToLower();
                    palavras[i] = primeiraLetra + restoDaPalavra;
                }
            }

            string novaFrase = string.Join(" ", palavras);

            Console.WriteLine(novaFrase);
        }
    }
}