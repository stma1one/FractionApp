namespace FractionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Fraction f1= new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);
            Fraction result =(Fraction) f1.Add(f2);
            Fraction result2 = (Fraction) f1.Minus(f2);
            IComparable[] arr=new IComparable[3];
            arr[0] = new Fraction(1, 2);
            arr[1] = 8;
            arr[2] = "Hello";
            string str = "Bamboo";
            Console.WriteLine(str.CompareTo(arr[2]));


        }
    }
}
