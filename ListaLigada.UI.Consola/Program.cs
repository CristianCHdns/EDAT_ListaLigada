namespace ListaLigada.Logica;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! lista ligada simples");
        Console.WriteLine("");

        var singleList = new SingleList<string>();

        singleList.Add("Alondra");
        singleList.Add("Karla");
        singleList.Add("Leslye");
        singleList.Add("Luis");
        singleList.Add("Jose");

        Console.WriteLine(singleList);


        Console.ReadKey();
    }
}