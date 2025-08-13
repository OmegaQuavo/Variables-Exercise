namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Myname = "Caleb";
            int age = 23;
            char gender = 'M';
            bool doinggood = true;
            double daystobday = 46;
            decimal temp = new decimal(98.00);

            Console.WriteLine($"My name is {Myname} and i am {age}. My sex is {gender} and i am " +
                              "currently doing good {doinggood}. There are {daystobday} days till my birthday." +
                              "And it was {decimal} degrees fahrenheit outside today.") ;
        }
        }
    }

