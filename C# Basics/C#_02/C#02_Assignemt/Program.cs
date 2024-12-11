namespace C_02_Assignemt
{
    class Point
    {
        public int X, Y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 :1-	Write a program that allows the user to enter a number then print it

            //Console.WriteLine("Enter your Number :");
            //string Number=Console.ReadLine();
            //Console.Write(Number);
            #endregion

            #region Q2 :2-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 10;
            //int y = x;
            //x++;
            //Console.WriteLine($"X = {x}");
            //Console.WriteLine($"Y = {y}");
            //// y didn't Change because the two Variables are separate
            #endregion

            #region Q3 : 3-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Point P1 = new Point();
            //P1.X = 10; P1.Y = 20;
            //Point P2 = P1;
            //P1.X = 15;
            //P1.Y = 30;
            //Console.WriteLine($"X1 = {P1.X} :: Y1 = {P1.Y}");
            //Console.WriteLine($"X2 = {P2.X} :: Y2 = {P2.Y}");
            //// P2 Changed With P1 Because they have the same reference 
            #endregion
        }
    }
}
