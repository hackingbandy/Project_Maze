using System;


namespace Project_Maze 
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Program p = new Program();            
            p.load_maze();
        }
       
        public void load_maze(){
            List<Ecke> irrg = new List<Ecke>();
            fill_maze(ref irrg);
            search_maze(ref irrg);
        }

        void fill_maze(ref List<Ecke> irrg){
            irrg.Add(new Ecke{ Value = 18, Location = "L", IsStart = true});
            irrg.Add(new Ecke{ Value = 19, Location = "Ort_2"});
            irrg.Add(new Ecke{ Value = 16, Location = "Ö"});
            irrg.Add(new Ecke{ Value = 17, Location = "Ort_4"});
            irrg.Add(new Ecke{ Value = 14, Location = "S"});
            irrg.Add(new Ecke{ Value = 15, Location = "Ort_6"});
            irrg.Add(new Ecke{ Value = 12, Location = "U"});
            irrg.Add(new Ecke{ Value = 13, Location = "Ort_8"});
            irrg.Add(new Ecke{ Value = 10, Location = "N"});
            irrg.Add(new Ecke{ Value = 11, Location = "Ort_10"});
            irrg.Add(new Ecke{ Value = 8, Location = "G"});
            irrg.Add(new Ecke{ Value = 9, Location = "Ort_12"});
            irrg.Add(new Ecke{ Value = 6, Location = "S"});
            irrg.Add(new Ecke{ Value = 7, Location = "Ort_14"});
            irrg.Add(new Ecke{ Value = 4, Location = "W"});
            irrg.Add(new Ecke{ Value = 5, Location = "Ort_16"});
            irrg.Add(new Ecke{ Value = 2, Location = "E"});
            irrg.Add(new Ecke{ Value = 3, Location = "Ort_18"});
            irrg.Add(new Ecke{ Value = 1, Location = "G", IsExit = true});
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
                    if(ecke.IsExit== true)
                    Console.WriteLine(ecke.Location);                  
                    else
                    Console.Write($"{ecke.Location} -> ");
                }
                if (ecke.IsExit == true)
                {
                    Console.WriteLine($"\nEndpunkt: {ecke.Location}");
                }
                tmpint = ecke.Value;
            }
        }
    }
}
