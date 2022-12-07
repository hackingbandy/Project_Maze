using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Maze
{
    public class Ecke3 : IEnumerable<Ecke3>, IEnumerator<Ecke3>
    {
        Ecke3()
        {

        }
        //IDEE: Binärbaum
        public int Value {get; set;}
        public bool Right { get; set;}
        public bool Left {get; set;}
        public bool IsStart { get; set;}
        public string? Location { get; set;}
        public bool IsVisited { get; set;}
        public bool IsExit { get; set;}

        public IEnumerator GetEnumerator()
        {
            return Ecke3();
        }
    }
    public class Ecke3 : IEnumerator<Ecke3>
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
