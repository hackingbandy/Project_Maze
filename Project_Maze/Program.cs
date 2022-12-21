using System;
using System.Diagnostics;
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
            irrg.Add(new Ecke3{ Value = 18, Location = "Ort_1", IsStart = true});
            irrg.Add(new Ecke3{ Value = 19, Location = "Ort_2"});
            irrg.Add(new Ecke3{ Value = 16, Location = "Ort_3"});
            irrg.Add(new Ecke3{ Value = 17, Location = "Ort_4"});
            irrg.Add(new Ecke3{ Value = 14, Location = "Ort_5"});
            irrg.Add(new Ecke3{ Value = 15, Location = "Ort_6"});
            irrg.Add(new Ecke3{ Value = 12, Location = "Ort_7"});
            irrg.Add(new Ecke3{ Value = 13, Location = "Ort_8"});
            irrg.Add(new Ecke3{ Value = 10, Location = "Ort_9"});
            irrg.Add(new Ecke3{ Value = 11, Location = "Ort_10"});
            irrg.Add(new Ecke3{ Value = 8, Location = "Ort_11"});
            irrg.Add(new Ecke3{ Value = 9, Location = "Ort_12"});
            irrg.Add(new Ecke3{ Value = 6, Location = "Ort_13"});
            irrg.Add(new Ecke3{ Value = 7, Location = "Ort_14"});
            irrg.Add(new Ecke3{ Value = 4, Location = "Ort_15"});
            irrg.Add(new Ecke3{ Value = 5, Location = "Ort_16"});
            irrg.Add(new Ecke3{ Value = 2, Location = "Ort_17"});
            irrg.Add(new Ecke3{ Value = 3, Location = "Ort_18"});
            irrg.Add(new Ecke3{ Value = 1, Location = "Ort_19", IsExit = true});

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

            int tmpint = 0;
            foreach(Ecke3 ecke in irrg){
                ecke.IsVisited = true;
                if(ecke.IsStart == true){
                    Console.WriteLine($"Startpunkt: {ecke.Location}");
                }
                //Console.WriteLine($"Wert: {ecke.Value} Ort: {ecke.Location}");
                //speichere die aktuelle ecke und prüfe mit der folgenden, wenn der wert größer ist dann Right = true sonst Left = true. 
                //var tmp = ecke.GetEnumerator();

               // List<Ecke3> tmpo = new List<Ecke3>();
                Ecke3 tmp = new Ecke3();

                //tmpo.Add(ecke);
                //foreach(Ecke3 tmp in tmpo){
                
                    if(ecke.Value > tmpint) {
                        ecke.Right = true; 
                    }
                    else{
                        ecke.Left = true; 
                    }
                    //Console.WriteLine(tmp.Location);
                    //    Console.WriteLine(ecke.Location);
                //}
                if (ecke.Left == true || ecke.IsStart || ecke.IsExit)
                {
                    Console.WriteLine(ecke.Location);
                }
                if (ecke.IsExit == true)
                {
                    Console.WriteLine($"Endpunkt: {ecke.Location}");
                }
                tmpint = ecke.Value;
            }
        }
    }
}
