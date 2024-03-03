/*
 * Author: Diego Carmona
 * Course: COMP003A
 * Purpose: To gain understanding and practice with arrays, lists, and other data structrures and their manipulation
 */

namespace COMP003.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array", "CharacterCounter");
            Console.WriteLine("Please input a single character:");
            string transfer = Console.ReadLine();
            char singleLetter = Convert.ToChar(transfer);
            Console.WriteLine("Input a single word:");
            string inputWord = Console.ReadLine();
            CharacterCounter(singleLetter, inputWord);
            Console.WriteLine($"There are {CharacterCounter(singleLetter, inputWord)} letter {singleLetter} in {inputWord}");
            SectionSeparator("Array", "IsPalindrome");
            Console.WriteLine("Please input possible palindrome:");
            string racecar = Console.ReadLine();
            IsPalindrome(racecar);
            Console.WriteLine($"Is the word {racecar} a palindrome: {IsPalindrome(racecar)}");
            SectionSeparator("List", "Add");
            List<string> names = new List<string>();
            char userInput = default;
            
            do
            {
                Console.WriteLine("Please enter a name");
                names.Add(Console.ReadLine());
                Console.WriteLine("Press any key to add more or (e) to exit.");
                userInput = Convert.ToChar(Console.ReadLine());
            } while (userInput != 'e');

            SectionSeparator("List", "Transversal");
            TraverseList(names);
            SectionSeparator("List", "Reverse Transversal");
            TraverseListReverse(names);
        }

        static void SectionSeparator(string section, string type)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t\t{section} - {type} Section\n" + "".PadRight(50, '*'));
        }
        /// <summary>
        /// Count the number of specified characters within a provided string
        /// </summary>
        /// <param name="charatcerInput">Character Input</param>
        /// <param name="word">String Input</param>
        /// <return>Returns integer count of repeated char appearance</return>

        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();
            string charInput = Convert.ToString(characterInput);
            string[] arrayWord = new string[word.Length];
           for (int i = 0; i < arrayWord.Length; i++)
            {
                
                if (arrayWord[i] == charInput)
                {
                    count++;
                }
            }
           return count;
        }

        /// <summary>
        /// Checkes the status of the inputted string and tests whether it is a palindrome
        /// </summary>
        /// <param name="word"></param>
        /// <return>Boolean</return>
        static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            string[] arrayWord = word.Split(' ');
            Array.Reverse(arrayWord);
            string compareString = Convert.ToString(arrayWord);
            if (word == compareString)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Traverses along an inputted string list
        /// </summary>
        /// <param name="list">String list input</param>
        static void TraverseList(List<string>list)
        {
            foreach (string word in list)
            {
                Console.WriteLine(word);
            }
        }

        /// <summary>
        /// Takes an inputted string and reads it reversed
        /// </summary>
        /// <param name="list"></param>
        static void TraverseListReverse(List<string>list)
        {
            list.Reverse();
            foreach (string word in list)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}