using System.Threading.Channels;

namespace CSharpBasic
{
    public class exercises
    {
        public static void validate(int input)
        {
            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }

    }
}
