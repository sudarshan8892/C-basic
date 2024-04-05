namespace OOPS
{
    public class Person
    {
        public string Name;
        public void interoduce(string to)
        {
            Console.WriteLine("hi {0}, I am {1}", to, Name);
        }

        public  static Person parse(string str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }
/*
        public Person parse(string str)//he parse method is currently an instance method, meaning you need an instance of Person to call it. 
        {
            Person person = new Person();
            person.Name = str;
            return person;

        }
    
*/

}