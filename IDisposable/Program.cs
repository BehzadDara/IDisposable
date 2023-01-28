// class must implement IDisposable inorder to be accessible in using()
using (var instance = new MyClass())
{
    Console.WriteLine(instance.MyFunction());
}




class MyClass : IDisposable
{
    public int MyProperty = new Random().Next(0, 10);
    public int MyFunction()
    {
        return MyProperty;
    }

    public void Dispose()
    {
        Console.WriteLine("Dispose...");
        GC.SuppressFinalize(this);
    }
}