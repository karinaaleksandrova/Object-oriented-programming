namespace CarExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();
            car myCar2 = new car();
            myCar.AskData();
            myCar2.AskData();
            myCar.ShowCarinfo();
            myCar2.ShowCarinfo();
            myCar.Accelerate(-50);
            myCar.ShowCarinfo();
            myCar.Brake();
            myCar.ShowCarinfo();
        }
    }
}
