using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Project_Maze 
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Program p = new Program();
            EventArgs e = new EventArgs();

            p.load_maze(p, e);
        }
       
        public void load_maze(object sender, EventArgs e){
            List<Ecke> irrg = new List<Ecke>();
            fill_maze(ref irrg);
            search_maze(ref irrg);
        }
        void fill_maze(ref List<Ecke> irrg){
            irrg.Add(new Ecke{ Value = 18, Location = "Ort_1", IsStart = true});
            irrg.Add(new Ecke{ Value = 19, Location = "Ort_2"});
            irrg.Add(new Ecke{ Value = 16, Location = "Ort_3"});
            irrg.Add(new Ecke{ Value = 17, Location = "Ort_4"});
            irrg.Add(new Ecke{ Value = 14, Location = "Ort_5"});
            irrg.Add(new Ecke{ Value = 15, Location = "Ort_6"});
            irrg.Add(new Ecke{ Value = 12, Location = "Ort_7"});
            irrg.Add(new Ecke{ Value = 13, Location = "Ort_8"});
            irrg.Add(new Ecke{ Value = 10, Location = "Ort_9"});
            irrg.Add(new Ecke{ Value = 11, Location = "Ort_10"});
            irrg.Add(new Ecke{ Value = 8, Location = "Ort_11"});
            irrg.Add(new Ecke{ Value = 9, Location = "Ort_12"});
            irrg.Add(new Ecke{ Value = 6, Location = "Ort_13"});
            irrg.Add(new Ecke{ Value = 7, Location = "Ort_14"});
            irrg.Add(new Ecke{ Value = 4, Location = "Ort_15"});
            irrg.Add(new Ecke{ Value = 5, Location = "Ort_16"});
            irrg.Add(new Ecke{ Value = 2, Location = "Ort_17"});
            irrg.Add(new Ecke{ Value = 3, Location = "Ort_18"});
            irrg.Add(new Ecke{ Value = 1, Location = "Ort_19", IsExit = true});
        }
        void search_maze(ref List<Ecke> irrg){

            int tmpint = 0;

            foreach(Ecke ecke in irrg){
                ecke.IsVisited = true;
                
                if(ecke.Value > tmpint) {
                    ecke.Right = true; 
                }
                else{
                    ecke.Left = true; 
                }
                
                //Print in Terminal
                if(ecke.IsStart == true){
                    Console.WriteLine($"Startpunkt: {ecke.Location}");
                }                                         
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
