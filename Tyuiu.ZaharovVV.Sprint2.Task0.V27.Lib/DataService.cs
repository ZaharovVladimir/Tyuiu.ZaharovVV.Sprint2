using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaharovVV.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] q = new bool[6];
            q[0] = x == x;
            q[1] = x != x;
            q[2] = y < x;
            q[3] = y > x;
            q[4] = x <= y;
            q[5] = x >= y;

            return q;
        }
    }
}