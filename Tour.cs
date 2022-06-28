using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    abstract class Tour : IComparable<Tour>
    {
        public enum TransportType
        {
            Train,
            Airplane,
            Bus,
            Ship
        }
        public virtual TransportType[] availableTransport
        {
            get
            {
                return new[] { TransportType.Airplane, TransportType.Bus, TransportType.Ship, TransportType.Train };
            }
        }
        private TransportType _transportType;

        public string name { get; set; }
        public uint price { get; protected set; }
        public TransportType transportType
        {
            get
            {
                return _transportType;
            }
            set
            {
                if (availableTransport.Contains(value))
                    _transportType = value;
            }
        }
        public uint mealCnt { get; set; }
        public uint dayCnt { get; set; }

        public override string ToString()
        {
            string aTrans = "";
            for (int i = 0; i < availableTransport.Length; i++)
                aTrans += "\t\t - " + availableTransport[i].ToString() + "\n";
            return $"{this.name}:\n\tцiна: {this.price}$\n\tдоступний транспорт: \n{aTrans}\tприйоми їжi: {mealCnt}\n\tднi: {this.dayCnt}";
        }

        public int CompareTo(Tour other)
        {
            if (this.price > other.price) return 1;
            else if (this.price < other.price) return -1;
            else return 0;
        }
    }
}
