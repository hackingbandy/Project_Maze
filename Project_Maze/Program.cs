using System;
using System.Security.Cryptography.X509Certificates;

namespace Project_Maze // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ecke2> Ecken = new List<Ecke2>();
            Ecken.Add(new Ecke2 { Ecke = 1, Ort = "Ort_1" });
            Ecken.Add(new Ecke2 { Ecke = 2, Ort = "Ort_2" });
            Ecken.Add(new Ecke2 { Ecke = 3, Ort = "Ort_3" });
            Ecken.Add(new Ecke2 { Ecke = 4, Ort = "Ort_4" });
            Ecken.Add(new Ecke2 { Ecke = 5, Ort = "Ort_5", IsExit = true });
            ///
            /// Maze 
            ///  1 --> 3 --> 5 
            ///  |     |
            ///  2     4
            ///
            
        }
        //public int suche()
        //{

        //}
    }
}
