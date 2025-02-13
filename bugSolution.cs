public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        int y = 0;
        try
        {
            int z = x / y;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero detected.");
            Console.WriteLine(ex.Message);
        }
    }
}