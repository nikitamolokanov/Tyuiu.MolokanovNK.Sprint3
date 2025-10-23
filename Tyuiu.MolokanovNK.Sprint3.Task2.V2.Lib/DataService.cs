using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolokanovNK.Sprint3.Task2.V2.Lib
{
    public class DataService : ISprint3Task2V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            do
            {
                MultiplySeries = MultiplySeries * (Math.Sin(0.1) + startValue);
                startValue++;
            } while ( startValue > stopValue );
            return Math.Round(MultiplySeries, 3);
        }   
    }
}
