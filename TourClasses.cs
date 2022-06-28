using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    class Excursion : Tour
    {
        public override TransportType[] availableTransport
        {
            get
            {
                return new[] { TransportType.Bus, TransportType.Train };
            }
        }

        public Excursion(string name, uint price, uint mealCnt, uint dayCnt)
        {
            this.name = name;
            this.price = price;
            this.mealCnt = mealCnt;
            this.dayCnt = dayCnt;
        }
    }

    class Treatment : Tour
    {
        public override TransportType[] availableTransport
        {
            get
            {
                return new[] { TransportType.Airplane, TransportType.Train };
            }
        }

        public Treatment(string name, uint price, uint mealCnt, uint dayCnt)
        {
            this.name = name;
            this.price = price;
            this.mealCnt = mealCnt;
            this.dayCnt = dayCnt;
        }
    }

    class Cruise : Tour
    {
        public override TransportType[] availableTransport
        {
            get
            {
                return new[] { TransportType.Ship };
            }
        }

        public Cruise(string name, uint price, uint mealCnt, uint dayCnt)
        {
            this.name = name;
            this.price = price;
            this.mealCnt = mealCnt;
            this.dayCnt = dayCnt;
        }
    }
}
