using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Project_Maze // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[]args)
        {
            //Console.WriteLine("Hello");
            ///
            /// Maze 
            ///  1(4)--> 3(2) --> 5(1) 
            ///  |        |
            ///  2(5)   4(3)
            /// Irrgarten (Ecke3)
            ///       4
            ///     2   5
            ///   1   3
            ///weiterer Lösungsweg: Left und Right deklarieren mit werten versehen und dann Binär durchgehen     
            ///  
           List<Ecke2> ls = new List<Ecke2>();
           List<Ecke3> irrgarten = new List<Ecke3>();
           Program p = new Program();
            EventArgs e = new EventArgs();

            //p.Load_Maze(p, e);  
            p.Load_Maze2(p, e);          

        }
        public void Load_Maze(object sender, EventArgs e)
        {
            List<Ecke2> maze = new List<Ecke2>();
            
            Fill(ref maze);
            suche(ref maze);
        }
        public void Load_Maze2(object sender, EventArgs e){
            List<Ecke3> irrg = new List<Ecke3>();
            Fill2(ref irrg);
            suche2(ref irrg);
        }

        void Fill(ref List<Ecke2> mazeList)
        {
            mazeList.Add(new Ecke2 { Ecke = 1, Location = "Ort_1", IsStart = true });
            mazeList.Add(new Ecke2 { Ecke = 2, Location = "Ort_2", IsExit = false });
            mazeList.Add(new Ecke2 { Ecke = 3, Location = "Ort_3" });
            mazeList.Add(new Ecke2 { Ecke = 4, Location = "Ort_4", IsExit = false });
            mazeList.Add(new Ecke2 { Ecke = 5, Location = "Ort_5", IsExit = true });
        }
        void Fill2(ref List<Ecke3> irrg){
            irrg.Add(new Ecke3{ Value = 4, Location = "Ort_1", IsStart = true});
            irrg.Add(new Ecke3{ Value = 5, Location = "Ort_2"});
            irrg.Add(new Ecke3{ Value = 2, Location = "Ort_3"});
            irrg.Add(new Ecke3{ Value = 3, Location = "Ort_4"});
            irrg.Add(new Ecke3{ Value = 1, Location = "Ort_5", IsExit = true});

        }
        void suche(ref List<Ecke2> maze)
        {
            //Console.WriteLine(maze[0].Location);
            foreach(Ecke2 ecke in maze){
                ecke.IsVisited = true;

                if(ecke.IsExit == true || ecke.IsStart == true){
                Console.WriteLine(ecke.Location);
                }
                //else if(ecke.IsVisited == true )
                
            }    
        }
        void suche2(ref List<Ecke3> irrg){
            //Logic ...
            foreach(Ecke3 ecke in irrg){
                ecke.IsVisited = true;
                if(ecke.IsStart == true){
                    Console.WriteLine(ecke.Location);
                }
                //speichere die aktuelle ecke und prüfe mit der folgenden, wenn der wert größer ist dann Right = true sonst Left = true. 
                
            }
        }
    }
}
