using Szalloda;

if (File.Exists("szobak.txt"))
{
    foreach (string szoba in File.ReadAllLines("szobak.txt"))
    {

    }

}
else
{
    Console.WriteLine("A szobak.txt fájl nem található.");
}