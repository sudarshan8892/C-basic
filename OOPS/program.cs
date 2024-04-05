namespace OOPS
{
    

    class Program
     {
        static void Main(string[] arg)
        {
            // var  person= new Person();
            // var p=  person.parse("sudarshan");//he parse method is currently an instance method, meaning you need an instance of Person to call it. 
            // p.interoduce("shetty");//he parse method is currently an instance method, meaning you need an instance of Person to call it.
           
            var p = Person.parse("sudarshan");
            p.interoduce("shetty");
        }
    }

}