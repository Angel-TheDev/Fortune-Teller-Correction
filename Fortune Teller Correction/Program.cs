using System;

namespace Fortune_Teller_Correction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your first name?");  //prints the question
            string firstName = Console.ReadLine();            // allowing cust. to type(readline) and storing what they type under local veriable 
            Console.WriteLine("What is your last name?");             //prints question
            string lastName = Console.ReadLine();                      //storing what the cust type in local variable(string) I think, idk my head hurts
            Console.WriteLine("What is your age?");             //prints question
            string age = Console.ReadLine();                     //storing cust answers in local variable
            int ageAsnumber = Int32.Parse(age);                //I forgot 
            int retirementAge = 0;                             //IFORGOT
            if (ageAsnumber > 50) {
                 retirementAge = ageAsnumber + 30;
            } else 
            {
                retirementAge = 60;
            }
            Console.WriteLine("What is your birth month as a number?");
            string monthNumber = Console.ReadLine();
            

            Console.WriteLine("What is your favorite ROYGBIV color? Enter Help for list of ROYGBIV colors.");
            string color = Console.ReadLine();
         

                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet");
           
            Console.WriteLine("How many siblings do you have?");
            string siblings = Console.ReadLine();

            Console.WriteLine($"My name is  {firstName}  {lastName}  I will retire at  {retirementAge}");


           
            
            
        


           
          

        }
    }
}
