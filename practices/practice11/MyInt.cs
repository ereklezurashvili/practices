using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace math;

public class MyInt
{
    public static int MinValue = -100000;
    public static int MaxValue = 100000;

    public int _value;
    public MyInt(int value)
    {
        _value = value;
    }

    public bool Equals(int x)
    {
        return _value == x;
    }
    public string ToString(int x)
    {
        string s = "";
        return s + x;
    }
    public static int Parse(string s)
    {
        return Convert.ToInt32(s);
    }
    public static bool TryParse(string s, out int x)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]!='0' && s[i]!='1' && s[i]!='2' && s[i]!='4' && s[i]!='5' && s[i]!='6'
                && s[i]!='7' && s[i]!='8' && s[i] != '9')
            {
                x = 0;
                return false;
            }
        }
        x = Convert.ToInt32(s);
        return true;
    }
    public int CompareTo(int b)
    {
        if (_value == b)
        {
            return 0;
        }
        else if (_value > b)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }

}