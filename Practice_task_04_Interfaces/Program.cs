namespace Practice_task_04_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA objA = new ClassA();
            ClassB objB = new ClassB();

            NewMethod(objA);
            NewMethod(objB);

            Console.ReadKey();
        }

        public static void NewMethod(IMyInterface a)
        {
            a.MyMethod();
        }
    }
    public interface IMyInterface
    {
        void MyMethod();
    }

    public class ClassA : IMyInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("My method in class A");
        }
    }

    public class ClassB : IMyInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("My method in class B");
        }
    }
}
