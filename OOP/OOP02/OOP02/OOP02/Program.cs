using OOP02.Models;

namespace OOP02
{

    internal class Program
    {
        // Validators
        static void Read(ref double p)
        {
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("Enter a number :");
                valid = double.TryParse(Console.ReadLine(), out p);
                if (!valid)
                    Console.WriteLine("Invalid Input");
            }
        }
        static void Read(ref int age)
        {
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("Enter an Age :");
                valid = int.TryParse(Console.ReadLine(), out age);
                valid &= (age > 0);
                if (!valid)
                    Console.WriteLine("Invalid Input");
            }
        }
        static void Swap(ref Employee emp1,ref Employee emp2)
        {
            Employee tmp= emp1;
            emp1 = emp2;
            emp2 = tmp;
        }


        static void Main(string[] args)
        {

            // Part 01 
            #region Q1 : Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array
            //Person[] persons =
            //{
            //    new Person("Sanchez",25),
            //    new Person("Casado",30),
            //    new Person("Leva",36)
            //};
            //foreach (var p in persons) {
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Q2 : Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them
            //Point p1 = new Point(), p2 = new Point();
            //Read(ref p1.X);
            //Read(ref p1.Y);
            //Read(ref p2.X);
            //Read(ref p2.Y);
            //Console.WriteLine($"Distance = {Point.Distance(p1,p2)}");
            #endregion

            #region Q3: Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person
            //Person Oldest = new Person();
            //for(int i = 0; i < 3; i++)
            //{
            //    string name="";
            //    int age=0;
            //    Console.WriteLine("Enter your Name");
            //    name = Console.ReadLine();
            //    Read(ref age);
            //    if (Oldest.Age < age)
            //    {
            //        Oldest = new Person(name, age);
            //    }
            //}
            //Console.WriteLine(Oldest);
            #endregion


            // Part 02
            #region Q1.	Design and implement a Class for the employees in a company
            // in Models Folder 
            #endregion

            #region Q2. Develop a Class to represent the Hiring Date Data
            // In Models Folder
            #endregion

            #region Q3. Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //Employee[] employees =
            //{
            //    new Employee(1,"Mina",10_000,Privileges.DBA,Gender.Male,new HiringDate(1,1,2025)),
            //    new Employee(2,"Aulmo",20_000,Privileges.Guest,Gender.Male,new HiringDate(23,12,2024)),
            //    new Employee(3,"Aya",3_000,Privileges.SecurityOfficer,Gender.Female,new HiringDate(15,12,2024))
            //};


            #endregion

            #region Q4 : Sort the employees based on their hire date then Print the sorted array

            //Employee[] employees =
            //{
            //    new Employee(1,"Mina",10_000,Privileges.DBA,Gender.Male,new HiringDate(1,1,2025)),
            //    new Employee(2,"Aulmo",20_000,Privileges.Guest,Gender.Male,new HiringDate(23,12,2024)),
            //    new Employee(3,"Aya",3_000,Privileges.SecurityOfficer,Gender.Female,new HiringDate(15,12,2024))
            //};
            //// Bubble Sort 
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    for(int j = 0; j < employees.Length-1; j++)
            //    {
            //        if (HiringDate.LessThan(employees[j + 1].hiringDate, employees[j].hiringDate))
            //        {
            //            Swap(ref employees[j], ref employees[j + 1]);
            //        }
            //    }
               
            //}
            //foreach(Employee emp in employees) 
            //    Console.WriteLine(emp);


            // Zero Boxing and UnBoxing Process had occured Because there is no use of ( object ) in Bubble sort
            #endregion
        }
    }
}
