using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    class TourProp
    {
        public Tour.TransportType transportType = (Tour.TransportType)0;
        public uint maxPrice = uint.MaxValue;
        public uint maxDays = uint.MaxValue;
        public uint maxMeals = uint.MaxValue;
        public uint minDays = 0;
        public uint minMeals = 0;

        public List<Tour> Tours { get; private set; } = new List<Tour>();
        public List<Tour> filteredTours
        {
            get
            {
                return (from t in Tours
                        where t.availableTransport.Contains(transportType) &&
                              t.price <= maxPrice &&
                              (t.dayCnt >= minDays && t.dayCnt <= maxDays) &&
                              (t.mealCnt >= minMeals && t.mealCnt <= maxMeals)
                        select t).ToList();
            }
        }

        public void AddTour(Tour packageTour)
        {
            Tours.Add(packageTour);
        }

        public void PrintAllTours()
        {
            for (int i = 0; i < Tours.Count; i++)
            {
                Console.WriteLine($"\n#{i + 1}\n" + Tours[i].ToString() + "\n");
            }
        }
        public void PrintFilteredTours()
        {
            for (int i = 0; i < filteredTours.Count; i++)
            {
                Console.WriteLine($"\n#{i + 1}\n" + filteredTours[i].ToString() + "\n");
            }
        }


        public void SortByPrice()
        {
            Tours.Sort();
        }
        public void ClearFilters()
        {
            transportType = (Tour.TransportType)0;
            maxPrice = uint.MaxValue;
            maxDays = uint.MaxValue;
            maxMeals = uint.MaxValue;
            minDays = 0;
            minMeals = 0;
        }
    }
}
