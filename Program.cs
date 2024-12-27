// See https://aka.ms/new-console-template for more information
// Console.WriteLine{"Hello, World!"},

// public class Dictionary
// {
// Dictionary<char, int> alphabetNumbers = [];

// public void MapAlphabetNumbers{)
// {
//     for {int i = 0; 1 < 26; i++)
//     {
//         char letter = {char){'A' + i},
//         alphabetNumbers.Add{letter,i},
//     }
// } 
// }


class Program
{
    static void Main()
    {
        Dictionary<char, string> alphabetDictionary = new Dictionary<char, string>
        {
            { 'A', "Axe" },
            { 'B', "Bear" },
            { 'C', "Casket" },
            { 'D', "Dog" },
            { 'E', "Elephant" },
            { 'F', "Fish" },
            { 'G', "Giraffe" },
            { 'H', "Hat" },
            { 'I', "Igloo" },
            { 'J', "Jackal" },
            { 'K', "Kite" },
            { 'L', "Lion" },
            { 'M', "Mouse" },
            { 'N', "Nose" },
            { 'O', "Ocean" },
            { 'P', "Penguin" },
            { 'Q', "Queen" },
            { 'R', "Rabbit" },
            { 'S', "Snake" },
            { 'T', "Tiger" },
            { 'U', "Umbrella" },
            { 'V', "Vulture" },
            { 'W', "Wolf" },
            { 'X', "X-ray" },
            { 'Y', "Yak" },
            { 'Z', "Zebra" }
        };
        
        int counter = 1;
        foreach (var pair in alphabetDictionary)
        {
            Console.WriteLine($"{counter}. {pair.Key} for {pair.Value}");
            counter++;
        }

        
        
    }
}