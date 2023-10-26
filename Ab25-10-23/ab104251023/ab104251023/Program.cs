class Program
{
    static void Main(string[] args)
    {
        string jsonFilePath = "names.json";
        Name nameManager = new Name(jsonFilePath);
        string name = "Ali";

        //nameManager.Add(name);

        bool found = nameManager.Search(name, n => n == name);
        if (found)
            Console.WriteLine($"{name} burda.");
        else
            Console.WriteLine($"{name} yox.");

        nameManager.Delete($"{name}");

        Console.ReadKey();
    }
}
