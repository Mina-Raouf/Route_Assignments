using System.Threading.Channels;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic Swap
            //int x = 10, y = 20;
            //Helper.SWAP(x,y);
            #endregion
            #region Equals
            //Employee e1 = new Employee();
            //Employee e2 = new Employee();
            //if (e1.Equals(e2))
            //{
            //    Console.WriteLine("=");
            //}
            //else
            //{
            //    Console.WriteLine("!=");
            //} 
            #endregion
            #region Bubble Sort
            //Employee[] emps =
            //{
            //new Employee(){Id=10,Name="Omar",Salary=1000},
            //new Employee(){Id=20,Name="Omnia",Salary=2000},
            //new Employee(){Id=30,Name="Mina",Salary=10000},
            //new Employee(){Id=40,Name="Aya",Salary=3000}
            //};
            //Helper<Employee>.BubbleSort(emps);
            //foreach (Employee emp in emps) Console.WriteLine(emp.Salary); 

            //Helper<Employee>.BubbleSort(emps, new EmployeeComparerById());
            //Helper<Employee>.BubbleSort(emps, delegate (Employee X, Employee Y)
            //{
                //return X.Id.CompareTo(Y.Id) == 1;
            //});
            //Helper<Employee>.BubbleSort(emps, (X, Y) => X.Id.CompareTo(Y.Id) == 1);

            #endregion


        }
    }
}
