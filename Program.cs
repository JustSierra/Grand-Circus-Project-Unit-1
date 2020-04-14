using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            String vacationType;
            int groupSize;
            string result;

            Console.WriteLine("What kind of vaction would you like to go on? Select one of the following");
            Console.WriteLine("(A) Musical ");
            Console.WriteLine("(B) Tropical ");
            Console.WriteLine("(C) Adventurous");

            Console.WriteLine("What is your selection?");
           
           
            Console.ReadLine();

            Console.WriteLine("How many people are going?");
            Console.WriteLine("(D) 1-2" );
            Console.WriteLine("(E) 3-5");
            Console.WriteLine("(F) 6+");

            char selection = Console.ReadKey().KeyChar;
            groupSize = int.Parse(Console.ReadLine());

          

            switch (selection)
            {
                case 'A':
                case 'D':
                    Console.WriteLine("Since you chose a musical trip with 1-2 people, you should fly first class to New Orleans.");
                    break;
                case 'a':
                case 'E':
                    Console.WriteLine("Since you chose a musical trip with 3-5 people, you should fly first class to New Orleans.");
                    break;
                           
                default:
                    Console.WriteLine("Since you chose a musical trip with probably 6+ people, you should fly first class to New Orleans.");
                    break;                
            }

            switch (selection)
            {
                case 'B':
                case 'D':
                    Console.WriteLine("Since you chose a tropical trip with 1-2 people, you should get a charter flight for a beach vaction in Mexico");
                     break;
                case 'b':
                case 'E':
                    Console.WriteLine("Since you chose a tropical trip with 3-5 people, you should get a charter flight for a beach vaction in Mexico");
                    break;
                default:
                    Console.WriteLine("Since you chose a tropical trip with probably 6+ people, you should get a charter flight for a beach vaction in Mexico");
                    break;
                    
            }


            switch (selection)
            {
                case'C':
                case'D':
                    Console.WriteLine("Since you chose an adventurous trip with 1-2 people, you should take a helicopter for whitewater rafting in the grand canyon");
                    break;
                case 'c':
                case 'E':
                    Console.WriteLine("Since you chose an adventurous trip with 3-5 people, you should take a helicopter for whitewater rafting in the grand canyon");
                    break;
              
                default:
                    Console.WriteLine("Since you chose an adventurous trip with probably 6+ people, you should take a helicopter for whitewater rafting in the grand canyon");
                    break;

                   
            }




        }
    }
}
