using System;

namespace lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            TourProp tourPool = new TourProp();
            #region INIT
            tourPool.AddTour(new Excursion("Екскурсiя #1", 200, 3, 2));
            tourPool.AddTour(new Cruise("Круiз #2", 3000, 5, 10));
            tourPool.AddTour(new Excursion("Екскурсiя #4", 500, 5, 3));
            tourPool.AddTour(new Excursion("Екскурсiя #3", 150, 0, 1));
            tourPool.AddTour(new Cruise("Круiз #1", 1000, 3, 14));
            tourPool.AddTour(new Treatment("Лiкування #1", 700, 5, 10));
            tourPool.AddTour(new Excursion("Екскурсiя #2", 250, 2, 2));
            tourPool.AddTour(new Cruise("Круiз #3", 1500, 0, 7));
            tourPool.AddTour(new Treatment("Лiкування #2", 500, 3, 14));
            #endregion

            uint toursCnt = (uint)tourPool.Tours.Count;

            Tour sTour;
            uint answer = 1;
            Console.Write("Ви бажаєте вiдсортувати тури за цiною? (y / any key) -> ");
            if (Console.ReadLine().ToLower() == "y")
                tourPool.SortByPrice();
            Console.Write("Ви бажаєте вiдсортувати тури? (y / any key) -> ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.WriteLine("\nОберiть тип транспорту:");
                for (int i = 0; i < Enum.GetNames(typeof(Tour.TransportType)).Length; i++)
                    Console.WriteLine($"{i + 1}: {((Tour.TransportType)i).ToString()}");
                Console.Write("\n -> ");
                uint.TryParse(Console.ReadLine(), out answer);
                if (answer - 1 < Enum.GetNames(typeof(Tour.TransportType)).Length)
                    tourPool.transportType = (Tour.TransportType)answer;

                Console.Write("Введiть максимальну цiну -> ");
                uint.TryParse(Console.ReadLine(), out tourPool.maxPrice);

                Console.Write("Введiть мiнiмум днiв -> ");
                uint.TryParse(Console.ReadLine(), out tourPool.minDays);

                Console.Write("Введiть максимум днiв -> ");
                uint.TryParse(Console.ReadLine(), out tourPool.maxDays);

                Console.Write("Введiть мiнiмум прийомiв їжi -> ");
                uint.TryParse(Console.ReadLine(), out tourPool.minMeals);

                Console.Write("Введiть максимум прийомiв їжi -> ");
                uint.TryParse(Console.ReadLine(), out tourPool.maxMeals);

                tourPool.PrintFilteredTours();

                toursCnt = (uint)tourPool.filteredTours.Count;
            }
            else
                tourPool.PrintAllTours();


            Console.Write("\n\nОберiть тур -> ");
            uint.TryParse(Console.ReadLine(), out answer);
            if (answer - 1 >= toursCnt)
                answer = 1;
            sTour = (toursCnt == tourPool.Tours.Count?
                                    tourPool.Tours:
                                    tourPool.filteredTours)
                                    [(int)(answer - 1)];

            Console.WriteLine($"\nВи обрали тур ( #{answer} )");
            Console.WriteLine(sTour.ToString());
        }
    }
}
