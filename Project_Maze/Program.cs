using System;
using System.Security.Cryptography.X509Certificates;

namespace Project_Maze // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            ///
            /// Maze 
            ///  1 --> 3 --> 5 
            ///  |     |
            ///  2     4
            ///
            
        }
        public void Load_Maze(object sender, EventArgs e)
        {
            List<Ecke2> maze = new List<Ecke2>();
            Fill(ref maze);
        }
        void Fill(ref List<Ecke2> mazeList)
        {
            mazeList.Add(new Ecke2 { Ecke = 1, Ort = "Ort_1" });
            mazeList.Add(new Ecke2 { Ecke = 2, Ort = "Ort_2" });
            mazeList.Add(new Ecke2 { Ecke = 3, Ort = "Ort_3" });
            mazeList.Add(new Ecke2 { Ecke = 4, Ort = "Ort_4" });
            mazeList.Add(new Ecke2 { Ecke = 5, Ort = "Ort_5", IsExit = true });
        }
    }
}
