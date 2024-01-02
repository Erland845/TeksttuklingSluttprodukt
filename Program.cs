namespace TeksttuklingSluttprodukt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Submit number 1 or 2");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Submit a word");
                    var inputWord = Console.ReadLine();

                    Console.WriteLine("Reversed word");
                    string reversedInput = "";
                    for (int i = inputWord.Length - 1; i >= 0; i--)
                    {
                        reversedInput += inputWord[i];
                    }
                    Console.WriteLine(reversedInput);
                    break;

                    case "2":
                    Console.WriteLine("submit a sentence");
                    string sentence = Console.ReadLine();

                    char[] charArray = sentence.ToCharArray();

                    for (int i = 0; i < charArray.Length; i++)
                    {
                        if (charArray[i] == 'e')
                        {
                            charArray[i] = 'a';
                        }
                    }
                    string modifiedSentence = new string(charArray);
                    Console.WriteLine("Modified sentence: " + modifiedSentence);
                    break;

                    default: 
                    Console.WriteLine("Ugyldig input");
                    break;
                  




            }

        }

    }
}