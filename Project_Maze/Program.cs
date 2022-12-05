using System;


namespace Project_Maze // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ecke2> Ecken = new List<Ecke2>();
            Ecken.Add(new Ecke2 { Ecke = 1, Ort = "Ort_1"});

            Console.WriteLine(Ecken);
        }
    }
}
