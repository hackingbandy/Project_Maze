using System;
using System.Collections;
using System.Collections.Generic;


namespace Project_Maze
{
    public class Ecke 
    {
        public int Value {get; set;}
        public bool Right { get; set;}
        public bool Left {get; set;}
        public bool IsStart { get; set;}
        public string? Location { get; set;}
        public bool IsVisited { get; set;}
        public bool IsExit { get; set;}

    }
}
