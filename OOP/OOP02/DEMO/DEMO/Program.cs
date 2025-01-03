using DEMO.Inheritance;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            // initialze object 

            Point p1 = new Point(5, 3);

            // new ---> for Consturctor Selection only
            // always will be a parameterless consturctor for struct even if you don
            Console.WriteLine(p1);
            #endregion

            #region Properties
            Employee employee = new Employee(111, "Mina Raouf", 10_000);
            PhoneBook note = new PhoneBook(10);
            note["mina"] = 323;
            //Console.WriteLine(note["mina"]);
            note["suii"] = 12124;
            for (int i = 0; i < note.Size; i++)
            {
                Console.WriteLine(note[i]);
            }
            #endregion

            #region Class
            //Car C1;
            //// Reference Type
            //// 4 Bytes in stack for reference and 0 bytes in heap
            //C1 = new Car();
            //// new 
            //// 1.Allocate required bytes for heap 
            //// 2.Initialize date with default value
            //// 3. call user defined contructor (if exist)
            //// 4. return address of allocated object in heap to reference C1 
            #endregion

            #region Inheritance
            //Parent p = new Parent(2, 4);
            //Console.WriteLine(p.Product());
            //
            //Child ch = new Child(20, 40, 60);
            //Console.WriteLine(ch); 
            // Inheritance is a 
            // Association has a 
            // 1. composition mandatory
            // 2. aggregation optional
            #endregion

        }
    }
}
