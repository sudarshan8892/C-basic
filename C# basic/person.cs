namespace CSharpBasic
{
    public class person
    {
        public string FirstName;
        public string LastName;

         public void introduce()
        {
            Console.WriteLine("My name is" + FirstName + " " + LastName );
        }
    }
}