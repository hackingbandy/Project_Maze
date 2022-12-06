using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Project_Maze // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hello");
            ///
            /// Maze 
            ///  1 --> 3 --> 5 
            ///  |     |
            ///  2     4
            ///        
            ///  
           List<Ecke2> ls = new List<Ecke2>();
           Program p = new Program();
            EventArgs e = new EventArgs();

            p.Load_Maze(p, e);            

        }
        public void Load_Maze(object sender, EventArgs e)
        {
            List<Ecke2> maze = new List<Ecke2>();
            Fill(ref maze);
            suche(ref maze);
            
        }
        void Fill(ref List<Ecke2> mazeList)
        {
            mazeList.Add(new Ecke2 { Ecke = 1, Location = "Ort_1", IsStart = true });
            mazeList.Add(new Ecke2 { Ecke = 2, Location = "Ort_2", IsExit = false });
            mazeList.Add(new Ecke2 { Ecke = 3, Location = "Ort_3" });
            mazeList.Add(new Ecke2 { Ecke = 4, Location = "Ort_4", IsExit = false });
            mazeList.Add(new Ecke2 { Ecke = 5, Location = "Ort_5", IsExit = true });
        }
        void suche(ref List<Ecke2> maze)
        {
            Console.WriteLine(maze[0].Location);
        }
        
        


    }
}
