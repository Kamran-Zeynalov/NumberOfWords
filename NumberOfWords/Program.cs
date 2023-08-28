namespace NumberOfWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Salam eziz insanlar";
            string[] words = sentence.Split(new[] { ' ', '\t', '\n', '\r' });
            Console.WriteLine(words.Length);
        }
    }
}