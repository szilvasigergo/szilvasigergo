using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class GrafObj
    {
        protected int x;
        protected int y;

        public abstract void Kirajzol();
        public void Letorol()
        {
            Console.Clear();
        }

        public void Athelyez(int eltolasX, int eltolasY)
        {
            Letorol();
            x += eltolasX;
            y += eltolasY;
            Kirajzol();
        }
    }

    class kor : GrafObj
    {

        public override void Kirajzol()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            kor k = new kor();
            k.Athelyez(3, 4);
            Console.ReadKey();
            k.Letorol();
            Console.ReadKey();
            k.Athelyez(4, 6);
            Console.ReadKey();
            k.Letorol();
            Console.ReadKey();
            k.Athelyez(10, 3);
            Console.ReadKey();
            k.Letorol();
            Console.ReadKey();
        }
    }
}
