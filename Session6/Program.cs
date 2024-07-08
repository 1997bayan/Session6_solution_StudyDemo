

using System.Reflection;
using System.Security;

namespace Session6

{     public enum Grades
    {
        A, B, C, D, E, F
     }
    enum Roles
    {
        Admin = 10,
        Editor = 20,
        Viewer = 30
    }

    class Employee
    {
       public string Name; // Varchar
       public int Age; // int
       public double Salary; // double
       public gender Gender; // int 0-1
       //public //Roles Role; // Admin – Editor – Viewer
       public premission permissions;
    }

    enum branches :byte // 8bites => 0:255
    {
        Dokki , NaseCity , Maddi , ALex , SmartVillage , cairo 
    }

    enum gender
    {
        Male=1 , Female=2
    }

    [Flags]
    public enum  premission
    {
        Delete=1 , Execute=2,Read=4,Write=8
    }




    internal class Program
    {

        //static void DoSomeProtectiveCode()
        //{
        //    int X, Y, Z;
        //    bool Flag;

        //    // Loop until a valid integer is entered for X
        //    do
        //    {
        //        Console.WriteLine("Enter First Number:");
        //        Flag = int.TryParse(Console.ReadLine(), out X);
        //    } while (!Flag);

        //    // Loop until a valid integer is entered for Y and Y is not zero
        //    do
        //    {
        //        Console.WriteLine("Enter Second Number:");
        //        Flag = int.TryParse(Console.ReadLine(), out Y);
        //    } while (!Flag || Y == 0);

        //    Z = X / Y;

        //    // Demonstrating System.NullReferenceException
        //    int[] Numbers = null; // System.NullReferenceException
        //    if (Numbers?.Length > 10)
        //    {
        //        // Numbers = null => Numbers?.Length = null
        //        // Numbers != null => Numbers?.Length = Length
        //        Numbers[10] = 100;
        //    }
        //}
        static void Main(string[] args)
        {
            //try
            //{
            //    DoSomeProtectiveCode(); // Runtime Errors (Exceptions)
            //    throw new Exception(); // Throwing a new exception manually
            //}
            //catch (Exception ex)
            //{
            //    // If any exception happened in the try block
            //    // CLR will create an object from the class of exception
            //    // and pass it to the catch block
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("After `Try Catch");



            #region Acces Modifiers

            //TypeA obj = new TypeA(); //valid
            //TypeB obj2 = new Common.TypeB(); // Invalid [Internal]
            // 'TypeB' is inaccessible due to its protection level
            #endregion

            #region Enum 
            #region Ex01

            //Grades x = Grades.A;
            //Grades y = (Grades)2;
            //Grades z = (Grades)10;

            //Console.WriteLine(y); // Explicit casting 
            //Console.WriteLine(z); // Explicit casting // there is no lable match 10



            //if (x == Grades.A)
            //{
            //    Console.WriteLine(":)");
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}

            #region Ex 02
            // Console.WriteLine("Please Enter Your Grade");
            // //Grades k = (Grades) Enum.Parse(typeof(Grades) , Console.ReadLine()); //worst way beacuse there is alot of boxing and unboxing and it is not safe way to use parse so we will use try parse.
            //bool result = Enum.TryParse(typeof(Grades), Console.ReadLine(), out object k); //Tryparse issues :1- there is alot of boxing and unboxing  2-when it is false it will return value which is null
            // Console.WriteLine($"Your result is {result}");
            // Console.WriteLine(k);


            #endregion

            #region E03

            // string Gender = "male";

            // // gender G =(gender) Gender; 
            // //Enum.TryParse(typeof(gender), Gender, out object result2);
            //bool flag = Enum.TryParse<gender>(Gender, out gender result2); // this is a best way // C# 1.0
            // Console.WriteLine(flag); // false

            // Console.WriteLine(result2); //0 for that we prefare to dont use 0 in enum lable beacuse it is the defult value
            // // so we will use genaric try pasrse like below :
            // bool flag2 = Enum.TryParse<gender>(Gender, true, out gender result3); //ingore Casw => ingore casesenstivate //  C# 2.0
            // Console.WriteLine(flag2); // True
            // Console.WriteLine(result3);

            // // Defalut value for enum = 0 
            // gender v = new gender(); // here new is used to give the v the defalut value 
            // Console.WriteLine(v);


            #endregion


            #region Ex04

            Employee employee = new Employee();
            employee.Name = "Bayan";
            employee.Gender = gender.Female;
            employee.permissions=(premission)3; //Delete, Execute

            Console.WriteLine(employee.permissions);
            //if you want to add a new permission (Read) => Use XOR operation
            employee.permissions = employee.permissions ^ premission.Read; //Delete, Execute, Read
            Console.WriteLine(employee.permissions);


            //if you want to deny permission (Read)  => Use XOR operation
            employee.permissions = employee.permissions ^ premission.Read;
            Console.WriteLine(employee.permissions); //Delete, Execute //we need to use ^ carfully



            // If you Want To Check If Delete is Existed Or Not
            // Do And Operation
            // &
            // employee.Permissions & Permission.Delete;
            // If Delete is Existed => return Delete
            // If Delete is not Existed => Return Random Value

            //if ((employee.permissions & premission.Delete) == premission.Delete)
            //{
            //    Console.WriteLine("Delete Is Existed");
            //}
            //else {
            //    employee.permissions = employee.permissions ^ premission.Read;
            //}








            #endregion

            #region Struct

            Point p1;

            //p1.x = 10;
            p1 = new Point(4,4);

          
            Console.WriteLine(p1.x);

            Console.WriteLine (p1);
            Console.WriteLine(p1.ToString());



            #endregion

            #endregion




            #endregion









        }
    }
}
