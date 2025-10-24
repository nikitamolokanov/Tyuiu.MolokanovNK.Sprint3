using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolokanovNK.Sprint3.Task4.V24.Lib
{
    public class DataService : ISprint3Task4V24
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1; 

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break; 
                }

                double y = (Math.Sin(x) / x) + 2;
                res = res * y; 
            }
            return Math.Round(res, 3);
        }
    }
}
