using System;

namespace About_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionBank();
            Console.Read();
        }

        static void QuestionBank()
        {
            int answersCorrect = 0;
            int answersIncorrect = 0;
            Console.WriteLine("Did Miya come to Seattle from Chicage 4 years ago? (Y/N)");
            string firstAnswer = Console.ReadLine();

            if (firstAnswer == "Y")
            {
                Console.WriteLine("Nope, I'm actually from Florida and I've been here for 3 years.");
                answersIncorrect++;
            }
            else
            {
                Console.WriteLine("You're right! I am not from Chicago. Good job.");
                answersCorrect++;
            }
            Console.WriteLine("Does Miya have a cat or a dog? (Enter Y/N or specify the type of animal.)");
            string secondAnswer = Console.ReadLine();

            if ((secondAnswer == "Y") || (secondAnswer == "cat"))
            {
                Console.WriteLine("Yep. I guess that makes me a cat lady?");
                answersCorrect++;
            }
            else
            {
                Console.WriteLine("Either you said I don't have any pets or that I have a dog and you're wrong either way.");
                answersIncorrect++;
            }
            Console.WriteLine("Does Miya have a great love for all things food-related?");
            string thirdAnswer = Console.ReadLine();

            if (thirdAnswer == "Y")
            {
                Console.WriteLine("Very true. What gave me away??");
                answersCorrect++;
            }
            else
            {
                Console.WriteLine("Yeah, I actually like starving myself. Builds character. (Please note: this is sarcasm.)");
                answersIncorrect++;
            }
            Console.WriteLine("Name a country I've visited.");
            string countriesAnswer = Console.ReadLine();
            string result = MyCountries(countriesAnswer);
            Console.WriteLine(result);

            if (result == "You got it!")
            {
                answersCorrect++;
            }
            else if (result == "No, I haven't been there YET.")
            {
                answersIncorrect++;
            }
            Console.WriteLine($"You got {answersCorrect} answer(s) right.");
            Console.WriteLine($"You got {answersIncorrect} answer(s) wrong.");

        }
        static string MyCountries(string input)
        {
            string[] countries = new string[8];
            countries[0] = "Canada";
            countries[1] = "China";
            countries[2] = "Spain";
            countries[3] = "Scotland";
            countries[4] = "Ireland";
            countries[5] = "France";
            countries[6] = "England";
            countries[7] = "Italy";

            string successMessage = "You got it!";
            string failureMessage = "No, I haven't been there YET.";

            foreach (string country in countries)
            {
                if (input == country)
                {
                    return successMessage;
                }
            }
            return failureMessage;
        }
    }
}