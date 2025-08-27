namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] department = ["[A] Adult section", "[B] Kids section", "[C] Appliance section", "[D] Toy section"];

            string[] adult = ["[1] LEVIS", "[2] DICKIES"];
            string[] kdis = ["[1] BARBIE", "[2] SPIDERMAN"];
            string[] app = ["[1] AMERICAN HOME", "[2] HANABISHI"];
            string[] toy = ["[1] HOT WHEELS", "[2] LEGO"];


            Console.WriteLine("Enter employee iD: ");
            string id = Console.ReadLine();
            Console.WriteLine($"Hi, {id}! Welcome to mall of asia");
            Console.WriteLine("Enter your designated department: ");
            string dept = Console.ReadLine();
            



            switch (dept)
            {
                case "A":
                    Console.WriteLine($"{id} you are from {department[0]}");
                    Console.WriteLine("(y) Continue (n) Exit");
                    string choose = Console.ReadLine();
                    if (choose == "y")
                    {
                        Console.WriteLine($"The brands under the {department[0]} are the following: ");
                        foreach (var a in adult)
                        {
                            Console.Write(a);
                            Console.WriteLine("Choose the brand you are handling:");
                            int pick = int.Parse(Console.ReadLine());
                            int chosen = pick - 1;
                            Console.WriteLine($"Thank you, {id} of {department[0]}");
                            Console.WriteLine($"You are handling {adult[chosen]}. Let's start your day! Good luck on your sales!");

                        }

                    }

                    break;
            }



        }//Main









    }//class program 




}//namespace program

