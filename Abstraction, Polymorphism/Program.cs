namespace Abstraction__Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition n1 = new Addition();
            Substraction n2 = new Substraction();
            Multiplication n3 = new Multiplication();
            Division n4 = new Division();
            n1.Operate(3, 44);
            n2.Operate(10, 14);
            n3.Operate(17, 9);
            n4.Operate(36, 15);

        }
    }
}
