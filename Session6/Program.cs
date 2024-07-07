
using Common;

namespace Session6

{
    internal class Program
    {

        static void DoSomeProtectiveCode()
        {
            int X, Y, Z;
            bool Flag;

            // Loop until a valid integer is entered for X
            do
            {
                Console.WriteLine("Enter First Number:");
                Flag = int.TryParse(Console.ReadLine(), out X);
            } while (!Flag);

            // Loop until a valid integer is entered for Y and Y is not zero
            do
            {
                Console.WriteLine("Enter Second Number:");
                Flag = int.TryParse(Console.ReadLine(), out Y);
            } while (!Flag || Y == 0);

            Z = X / Y;

            // Demonstrating System.NullReferenceException
            int[] Numbers = null; // System.NullReferenceException
            if (Numbers?.Length > 10)
            {
                // Numbers = null => Numbers?.Length = null
                // Numbers != null => Numbers?.Length = Length
                Numbers[10] = 100;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                DoSomeProtectiveCode(); // Runtime Errors (Exceptions)
                throw new Exception(); // Throwing a new exception manually
            }
            catch (Exception ex)
            {
                // If any exception happened in the try block
                // CLR will create an object from the class of exception
                // and pass it to the catch block
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("After Try Catch");



            #region Acces Modifiers

            TypeA obj = new TypeA(); //valid
           //TypeB obj2 = new Common.TypeB(); // Invalid [Internal]
                                     // 'TypeB' is inaccessible due to its protection level
            #endregion

        }
    }
}
