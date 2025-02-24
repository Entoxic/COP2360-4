using System,

{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter 1st number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter 2nd number: ");
            string input2 = Console.ReadLine();

            try
            {
                int number1 = Convert.ToInt32(input1);
                int number2 = Convert.ToInt32(input2);


                int result = Divide(number1, number2);
                Console.WriteLine($"The result of {number1} divided by {number2} is: " + {result});
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: One or both of the inputs are not valid integers");
                Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed");
                Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error has occurred.");
                Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The numbers are too large try again.");
                Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            
            
                Console.WriteLine("Press any key to exit program.");
                Console.ReadKey();
            
        }

        
            static int Divide(int a, int b)
        {
                return a / b;
        }    
 
    }   

}
