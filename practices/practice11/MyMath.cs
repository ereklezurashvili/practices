using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math;

public static class MyMath
{
    public static int Max(int x, int y)
    {
        return x > y ? x : y;
    }
    public static int Min(int x, int y)
    {
        return x < y ? x : y;
    }
    public static int Clamp(int value, int min, int max)
    {
        if (value < min)
        {
            return min;
        }
        if (value > max)
        {
            return max;
        }
        return value;

    }
    public static int Sqrt(int x)
    {
        for (int i = 0; i <= x / 2; i++)
        {
            if (i * i == x) return i;

        }
        return -1;
    }
    public static int Pow(int x, int y)
    {
        int powerd = 1;
        for (int i = 1; i <= y; i++)
        {
            powerd *= x;
        }
        return powerd;
    }
    public static int Round(double x)
    {
        int mteli = (int)x;
        double wiladi = x - (double)mteli;
        if (wiladi >= 0.5)
        {
            return mteli + 1;

        }
        else
        {
            return mteli;
        }
    }
    public static int Floor(double x)
    {
        int mteli= (int)x;
        return mteli;
    }
    public static int Ceiling(double x)
    {
        int mteli = (int)x;
        double wiladi = x - (double)mteli;

        if (wiladi == 0)
        {
            return mteli;
        }
        else
        {
            return mteli+1;
        }

    }
    public static int Abs(int x)
    {
        if (x >= 0)
        {
            return x;
        }
        else
        {
            return -x;
        }
    }


}
