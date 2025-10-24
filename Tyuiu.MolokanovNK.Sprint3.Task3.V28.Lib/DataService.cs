using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolokanovNK.Sprint3.Task3.V28.Lib
{
    public class DataService : ISprint3Task3V28
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            int count = 0;
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    value = value.Replace(c, 'r');
                }
            }
            return value;
        }
    }
}
