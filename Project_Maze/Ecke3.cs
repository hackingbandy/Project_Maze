using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Maze
{
    internal class Ecke3
    {
        //IDEE: Binärbaum
        public int Value {get; set;}
        public bool Right { get; set;}
        public bool Left {get; set;}
        public bool IsStart { get; set;}
        public string? Location { get; set;}
        public bool IsVisited { get; set;}
        public bool IsExit { get; set;}
    }
}
