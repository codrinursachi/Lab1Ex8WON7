using System.Buffers;

partial class Program
{
    static int[] ReadNumbers(in uint NUMAR_VARIABILE)
    {
        Console.WriteLine($"Introduceti {NUMAR_VARIABILE} numere pentru a le sorta descrescator");
        var numere = new int[NUMAR_VARIABILE];
        var numereRaw = Console.ReadLine()?.Split(" ");
        if (numereRaw?.Length == NUMAR_VARIABILE) { 
            for (int i = 0; i < numereRaw.Length; i++)
                if (!int.TryParse(numereRaw[i], out numere[i]))
                {
                    Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
                    ReadNumbers(NUMAR_VARIABILE);
                } 
        }
        else
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            ReadNumbers(NUMAR_VARIABILE);
        }
        return numere;
    }
    static int[] SortDescending(int[] numere)
    {
        numere=numere.OrderDescending().ToArray<int>();
        return numere;
    }
    static void ShowNumbers(int[] numere)
    {
        foreach(var numar in numere)
            Console.Write(numar + " ");
    }
}