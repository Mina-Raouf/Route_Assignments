namespace Assignment_1
{
    enum WeekDays
    {
        Monday, Tuesday, Wednesday,Thursday, Friday,Saturday,Sunday
    }
    enum Season
    {
        Spring,Summer,Autumn,Winter
    }
    [Flags]
    enum Permission
    {
        Read = 1, Wrie = 2, Delete = 4, Execute = 8
    }

    enum Color
    {
        Red, Green, Blue
    }
    struct Point
    {
        public double X, Y;
        static public double GetDistance(Point p1, Point p2)
        {
            double DifX = p1.X - p2.X, DifY = p1.Y - p2.Y;
            return Math.Sqrt(DifX * DifX + DifY * DifY);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //for(int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            #endregion

            #region Q2 : Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //bool flag = true;
            //Season season;
            //do
            //{
            //    flag = Enum.TryParse(Console.ReadLine(), true, out season);
            //} while (!flag);

            //List<string> Ranges = new List<string>()
            //{
            //    "March to May",
            //    "June to August",
            //    "September to November",
            //    "December to February"
            //};
            //Console.WriteLine(Ranges[(int)season]);
            #endregion

            #region Q3 : Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            //Permission permission=(Permission.Wrie|Permission.Read);
            //if ((permission & Permission.Delete)== Permission.Delete)
            //{
            //    Console.WriteLine("Employee has Delete Permission");
            //}
            //else permission |= Permission.Delete;
            //Console.WriteLine(permission);

            #endregion

            #region Q4 : Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //bool IsPrimaryColor = Enum.TryParse(Console.ReadLine(),true, out Color color);
            //if (IsPrimaryColor)
            //    Console.WriteLine("The Color is Primary");
            //else
            //    Console.WriteLine("The Color isn't Primary");

            #endregion

            #region Q5 : Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
                //try
                //{
                //    Point p1 = new Point(), p2 = new Point();
                //    Console.WriteLine("Enter two Points");
                //    p1.X = double.Parse(Console.ReadLine());
                //    p1.Y = double.Parse(Console.ReadLine());
                //    p2.X = double.Parse(Console.ReadLine());
                //    p2.Y = double.Parse(Console.ReadLine());
                //    Console.WriteLine($"Distance = {Point.GetDistance(p1, p2)}");
                //}
                //catch
                //{
                //    Console.WriteLine("Invalid Input");
                //}
            #endregion
        }
    }
}
