partial class Program
{
    static int[] ReadNumbers(uint numarVariabile)
    {
        Console.WriteLine($"Introduceti {numarVariabile} numere pentru a le sorta descrescator");
        var numere = new int[numarVariabile];
        var numereRaw = Console.ReadLine()?.Split(" ");
        if (numereRaw?.Length == numarVariabile) { 
            for (int i = 0; i < numereRaw.Length; i++)
                if (!int.TryParse(numereRaw[i], out numere[i]))
                {
                    Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
                    ReadNumbers(numarVariabile);
                } 
        }
        else
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            ReadNumbers(numarVariabile);
        }
        return numere;
    }
    static int[] SortDescending(int[] numere)
    {
        Array.Sort(numere);
        Array.Reverse(numere);
        return numere;
    }
    static void ShowNumbers(int[] numere)
    {
        foreach(var numar in numere)
            Console.Write(numar + " ");
    }
}