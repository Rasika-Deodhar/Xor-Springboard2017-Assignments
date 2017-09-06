namespace Assignment1
{
    public abstract class Bird
    {
        public abstract void walk();
    }

    public class Bird1 : Bird
    {
        public override void walk()
        {
            System.Console.WriteLine("Bird one can walk.");
        }
        public void fly()
        {
            System.Console.WriteLine("Bird one can fly.");
        }
    }

    public class Bird2 : Bird
    {
        public override void walk()
        {
            System.Console.WriteLine("Bird two can walk.");
        }
        public void sing()
        {
            System.Console.WriteLine("Bird two can sing.");
        }
    }
}
