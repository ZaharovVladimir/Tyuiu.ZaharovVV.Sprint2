using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaharovVV.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x == 3 && (y == 6 || y == 11)) || (x == 4 && ((y >= 2 && y <= 8) || (y == 11))) || (x == 5 && (y == 6 || y == 11)) || (x == 6 && (y == 6 || y == 11 || y == 10)) || (x == 7 && (y == 6 || y == 10 || y == 11 || y == 12)) || (x == 8 && (y >= 5 && y <= 12)) || (x == 9 && (y >= 3 && y <= 12)) || (x == 10 && (y >= 3 && y <= 10)) || (x == 11 && (y >= 3 && y <= 10)) || (x == 12 && (y >= 3 && y <= 10)) || (x == 13 && (y >= 6 && y <= 8)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}