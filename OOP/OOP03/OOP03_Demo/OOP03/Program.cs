namespace OOP03
{
    internal class Program
    {
        // Overloading
        static int Sum(int X,int Y)
        {
            return X+ Y;
        }
        static int Sum(int X,int Y,int Z)
        {
            return X+ Y+ Z;
        }
        static double Sum(double X,double Y)
        {
            return X+ Y;
        }
        static double Sum(int X,double Y)
        {
            return X+ Y;
        }
        static void Main(string[] args)
        {
            #region function overloading
            //dynamic Result = Sum(1, 2);
            //Result = Sum(1, 2, 3);
            //Console.WriteLine($"Result = {Result}"); 
            #endregion


            #region Binary Operators

            //Complex c1 = new Complex() { Real = 1, Imag = 1 }, c2 = null;
            //Console.WriteLine(c1 + c2); 
            #endregion

            #region Unary
            //Complex c1=new Complex() { Real=1,Imag=2 };
            //Complex c2 = ++c1;
            //Console.WriteLine(c2); 
            #endregion

            #region Casting Operators 
            //Complex c1=new Complex() { Real=10,Imag=15 };
            //int x =(int)c1;
            //Console.WriteLine(x);

            //string y = c1;
            //Console.WriteLine(y); 
            #endregion

            #region Casting Operator Overloading - Business need [mapping]
            //User user = new User()
            //{
            //    Id = 10,
            //    FullName = "mina raouf",
            //    Email = "mina@gmail.com",
            //    Password = "1234",
            //};
            //UserViewModel user01 = (UserViewModel)user;
            //Console.WriteLine(user01.FName);
            //Console.WriteLine(user01.LName); 
            #endregion
        }
    }
}
