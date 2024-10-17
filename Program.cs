using Password_Generator.Controller;

namespace Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomethingActionController controller = new SomethingActionController();
            controller.Start();
        }
    }
}