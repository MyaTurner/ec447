//  Everything in C# is written as a class
public class Demo
{
    public int count;
    public string name = "Mya";
    
    // Method (Note takes no arguments)
    public void Increment()
    {
        ++count;
    }
    public static void Main()
    {
        Demo demo = new Demo();
        demo.Increment();
    }
}
