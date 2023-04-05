namespace ManipulaçaoStrings.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Escolha qual vai ser a cifra ");
            int cifra = Convert.ToInt32(Console.ReadLine());

            string frase = "RENAN";

            char[] caracteres = frase.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                caracteres[i] = Convert.ToChar(frase[i] + cifra);
            }
            Console.WriteLine(caracteres);

        }
    }
}