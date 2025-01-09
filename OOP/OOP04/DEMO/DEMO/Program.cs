using DEMO.Built_in_Interfaces;
using DEMO.Interface_Ex01;
using DEMO.Interface_Ex02;
using DEMO.Interface_Ex03;

namespace DEMO
{
    internal class Program
    {
        public static void PrintSeries(Interface_Ex02.ISeries series)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(series.Current);
                series.GetNext();
            }
            series.Reset();

        }

        static void Main(string[] args)
        {
            #region Interface Ex01
            //IType reference;
            //// Declare for Reference of type "IType", Containg Garbag Value
            //// This Reference 'reference' Can Refer to an object of any "Type Implementing IType Interface"
            //// CLR Will Allocate 4 UnInitialized Bytes in STACK for this Reference.
            //// CLW Will Allocate 0 Bytes in HEAP.
            //
            //// reference = /*new IType()*/ --> INVALID ;
            //reference = new TypeA();
            //reference.MyProperty = 10;
            //reference.MyMethod(); // Hello World!
            //reference.Print(); // Default Implemented Method
            //TypeA typeA = new TypeA();
            //typeA.MyProperty = 10;
            //typeA.MyMethod();
            //typeA.Print(); // Can be accessed only by reference of the interface 

            #endregion

            #region Interface Ex02

            //Interface_Ex02.TypeA seriesByTwo = new Interface_Ex02.TypeA();
            //PrintSeries(seriesByTwo);
            //Interface_Ex02.TypeB seriesByThree = new Interface_Ex02.TypeB();
            //PrintSeries(seriesByThree);

            #endregion

            #region Interface Ex03

            //// Interfaces can Inherites other Interfaces
            //Airplane airplane = new Airplane();
            //airplane.Speed = 480;
            //// airplane.Forward();
            //IMoveable moveable = airplane;
            //moveable.Forward();
            //IFlyable flyable =  airplane;
            //flyable.Forward(); 
            #endregion

            #region Shallow vs Deep copy
            //int[] Arr01 = [1, 2, 3];
            //int[] Arr02 = [4, 5, 6];
            //Console.WriteLine($"Arr01.GetHashCode() = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode() = {Arr02.GetHashCode()}");
            //Arr02 = Arr01;
            //// This Object [1, 2, 3] Has 2 References[Arr01, Arr02] (اسمين دلع).
            //// This Object [4, 5, 6] Became UnReachable Object.
            //// shallow copy تأثير سطحى


            //// Deep Copy
            //Arr02 = (int[])Arr01.Clone();
            //// Clone Method: Will Generate NEW Object with NEW and DIFFERENT Identity
            ////
            ////  This Object Will Have The Same State [Data] of the Caller Object


            //string[] Names01 = ["Amr", "Mona"];
            //string[] Names02 = ["Ahmed", "Yassmin"];
            //Console.WriteLine($"Names01.GetHashCode() = {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.GetHashCode() = {Names02.GetHashCode()}");

            //Names02 = (string[])Names01.Clone();
            //// Clone Method: Will Generate New Object with NEW and DIFFERENT Identity
            //// : This Object Will Have the Same State[Data] of the Original Object [shallow copy for the items]

            #endregion

            #region ICloneable
            //Employee employee01 = new Employee() { Id = 10, Name = "Ahmed", Salary = 8_000, department = new Department(){Code =101 ,Title="CS"} };
            //Employee employee02 = new Employee() { Id = 20, Name = "Omnia", Salary = 4_000, department = new Department(){Code=102,Title="IT"} };
            //Console.WriteLine($"employee01.GetHashCode() = {employee01.GetHashCode()}");
            //Console.WriteLine($"employee02.GetHashCode() = {employee02.GetHashCode()}");
            //employee02 = (Employee)employee01.Clone();
            //// Clone Method: This Method Generates NEW Object with NEW and DIFFERENT Identity

            #endregion

            #region IComparable , IComparer
            //Employee[] employees =
            //{
            //    new Employee() {Id = 10, Name = "Ahmed", Salary = 8_000},
            //    new Employee() {Id = 20, Name = "Omnia", Salary = 2_000},
            //    new Employee() {Id = 30, Name = "Nadia", Salary = 10_000},
            //    new Employee() {Id = 40, Name = "Omars", Salary = 6_000},
            //};

            //Array.Sort(employees,(e1,e2)=>e1?.Name?.CompareTo(e2.Name)??(e2 is null?0:-1));
            //Array.Sort(employees,new EmployeeComparer());

            #endregion       



        }
        }

}
