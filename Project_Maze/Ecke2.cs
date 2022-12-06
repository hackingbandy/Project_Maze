using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Maze
{
    internal class Ecke2
    {
        //IDEE: Liste von 1-19 sackgasse = 0, Exit = 1, Start = Start.
        public int Ecke {get; set;}
        public bool IsStart { get; set;}
        public string? Location { get; set;}
        public bool IsVisited { get; set;}
        public bool IsExit { get; set;}
    }
}
