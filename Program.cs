class Program
{
    public static void Main(string[] args)
    {    
        int day;
        Console.WriteLine("Please enter a number between 1 and 7");
        try //tries the code but if an error exists it will catch it
        {
            day = Convert.ToInt32(Console.ReadLine());
            //Case Statements
            switch(day)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("I said 1 to 7");
                    break;
                
            }
        }
        catch
        {
            Console.WriteLine("Incorrect Input");
            Main(null);
        }
        Console.ReadKey();
    }
}