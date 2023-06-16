namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Winnie";
            int dogAge = 2;
            char dogTag = 'W';
            bool dogWalk = true;
            double dogSpeed = 2.3;
            decimal dogDistance = 0.8333m;

            Console.WriteLine($"My daughter has a wiener dog named {dogName} and she is {dogAge} years old.");
            Console.WriteLine($"{dogName} is so cute when she wears her favorite sweater with the letter \"{dogTag}\" on it.");
            Console.WriteLine($"It is {dogWalk} that {dogName} loves to go on dog walks.");
            Console.WriteLine($"{dogName}'s walks usually average {dogDistance} miles with an average speed of {dogSpeed} MPH.");
        }
    }
}
