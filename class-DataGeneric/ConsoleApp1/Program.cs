// See https://aka.ms/new-console-template for more information
public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> dataString = new DataGeneric<string>("1302220104");
        dataString.PrintData();

        DataGeneric<int> dataInteger = new DataGeneric<int>(1302220104);
        dataInteger.PrintData();

        DataGeneric<double> dataDouble = new DataGeneric<double>(1302220104);
        dataDouble.PrintData();
    }
}
