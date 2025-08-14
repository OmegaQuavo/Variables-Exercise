namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myname = "Caleb";
            int age = 23;
            char gender = 'M';
            bool isFeelingGood = true;  
            if (isFeelingGood) 
            {
                Console.WriteLine("doing fine");
            }
            else
            {
                Console.WriteLine("doing bad");
            }
            
                double daystobday = 44;
                decimal temp = 98.00m;

                Console.WriteLine($"My name is {myname} and i am {age}. My sex is {gender} and i am " +
                                  $"currently {(isFeelingGood ? "doing fine" : "doing bad")}. There are {daystobday} days till my birthday." +
                                  $" And it was {temp} degrees fahrenheit outside today.");
            }
        }
    }

