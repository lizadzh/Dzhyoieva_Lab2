using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1
{
    class Avto
    {
        public string marka { get; private set; } // марка авто
        public Color color { get; private set; } // колір
        public uint gruzp { get; private set; } // грузопідйомність


        public Avto(string marka, Color color, uint gruzp)
        {
            this.marka = marka;
            this.color = color;
            this.gruzp = gruzp;
        }

        public void ChangeColor(Color newColor) // метод зміни кольору
        {
            this.color = newColor;
        }
        public void ChangeMarka(string newMarka) // метод зміни марки
        {
            this.marka = newMarka;
        }
        public void ChangeGruzp(uint newGruzp) // метод зміни грузопідйомності
        {
            this.gruzp = newGruzp;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Avto tmp = (Avto)obj;
            return this.marka == tmp.marka && this.color == tmp.color && this.gruzp == tmp.gruzp;
        }
        public override int GetHashCode() => (marka, color, gruzp).GetHashCode();
        public override string ToString()
        {
            return string.Format("Марка: <{0}>\tКолiр: <{1}>\tГрузопiдйомнiсть: <{2}>", marka, color.ToString().Split("[")[1].Split("]")[0], gruzp);
        }
    }
}
