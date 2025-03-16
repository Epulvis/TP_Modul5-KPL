internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string namaPanggilan = "Zuhri";
        halo.SapaUser(namaPanggilan);

        //Jika Menggunakan String
        string nim = "103022300057";
        DataGeneric<string> dataGeneric = new DataGeneric<string>(nim);
        dataGeneric.PrintData();

        //Jika Menggunakan Long
        long angka = 103022300057;
        DataGeneric<long> dataInt = new DataGeneric<long>(angka);
        dataInt.PrintData();

    }
}

class DataGeneric<T>
{
    private T Data { get; set; }
    public DataGeneric(T data)
    {
        Data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}