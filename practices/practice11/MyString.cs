using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;
public class MyString
{
    public string _value;
    public int Length;
   
    public MyString(string value)
    {
        _value = value;
        Length = GetLength();
    }
    public MyString(char c, int count)
    {
        _value = "";
        for (int i = 0; i < count; i++) _value += c;
        Length = GetLength();
    }
    public static bool IsNullOrEmpty(string value)
    {
        return value == null || value == "";

    }
    public static bool IsNullOrWhiteSpace(string value)
    {
        if (value == null || value == "")
        {
            return true;
        }
        foreach (char c in value)
        {
            if(c!=' ')
            {
                return false;
                
            }
        }
        return true;
        
    }

    public bool Equals(string s)
    {
        if (s == _value)
        {
            return true;
        }
        return false;

    }
    public static int Compare(string s1, string s2)
    {
        if (s1 == s2)
        {
            return 0;
        }
        for (int i = 0; i < Math.Min(s1.Length, s2.Length); i++)
        {
            if (s1[i] < s2[i])
            {
                return -1;
            }
            else if (s1[i] > s2[i])
            {
                return 1;
            }
        }
        if (s2.Length > s1.Length)
        {
            return -1;
        }
        else
        {
            return 1;
        }

                
    }
    public int CompareTo(string s)
    {
        if (_value == s)
        {
            return 0;
        }
        for (int i = 0; i < Math.Min(s.Length, _value.Length); i++)
        {
            if (_value[i] < s[i])
            {
                return -1;
            }
            else if (_value[i] > s[i])
            {
                return 1;
            }
        }
        if (s.Length > _value.Length)
        {
            return -1;
        }
        else
        {
            return 1;
        }


    }

    public bool StartsWith(string s)
    {
        if (s.Length > _value.Length)
        {
            return false;
        }
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] != _value[i])
            {
                return false;
            }
        }
        return true;
    }

    public bool EndsWith(string s)
    {
        if (s.Length > _value.Length)
        {
            return false;
        }
        int dif=_value.Length - s.Length;
        for (int i = s.Length-1; i >=0; i--)
        {
            if (s[i] != _value[i+dif])
            {
                return false;
            }
        }
        return true;
    }
    public bool Contains(string s)
    {
        bool result = false;
        if (s.Length > _value.Length)
        {
            return false;
        }
        for (int i = 0; i < _value.Length-s.Length+1; i++)
        {
            result = true;
            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] != _value[i+j])
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                return true;
            }

        }
        return false;
    }
    public int IndexOf(string s)
    {
        bool result = false;
        if (s.Length > _value.Length)
        {
            return -1;
        }
        for (int i = 0; i < _value.Length-s.Length+1; i++)
        {
            result = true;
            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] != _value[i + j])
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                return i;
            }

        }
        return -1;
    }

    public int LastIndexOf(string s)
    {
        bool result = false;
        if (s.Length > _value.Length)
        {
            return -1;
        }
        for (int i = _value.Length-1; i>=s.Length-1; i--)
        {
            result = true;
            for (int j = s.Length-1; j>=0; j--)
            {
                if (s[j] != _value[i -(s.Length-j-1)])
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                return i-s.Length+1;
            }

        }
        return -1;
    }

    public string Substring(int startidx)
    {
        string result = "";
        for(int i=startidx; i<_value.Length; i++)
        {
            result += _value[i];
        }
        return result;

    }
    public string Substring(int startidx, int len)
    {
        string result = "";
        for(int i=startidx; i<startidx+len; i++)
        {
            result += _value[i];
            
        }
        return result;

    }
    public string Insert(int startidx, string s)
    {
        string result = "";
        for(int i=0; i<_value.Length; i++)
        {
            if (i == startidx)
            {
                result += s;
            }
            result += _value[i];
        } 
        return result;
    }

    public string Remove(int lastidx)
    {
        string result = "";
        for(int i=0; i<lastidx; i++)
        {
            result+= _value[i];
        }
        return result;
    }

    public string Remove(int startidx, int count)
    {
        string result = "";
        int lastidx=startidx+count - 1;
        for(int i=0; i<startidx; i++)
        {
            result += _value[i];
        }
        for(int i=lastidx+1; i<_value.Length; i++)
        {
            result += _value[i];
        }
        return result;
    }

    public string Trim()
    {
        int idx1 = 0;
        int idx2=0;
        string result = "";
        for(int i=0; i<_value.Length; i++)
        {
            if (' ' != _value[i])
            {
                idx1 = i;
                break;
            }
        }
        for(int i=_value.Length-1; i>=0; i--)
        {
            if (_value[i]!=' ')
            {
                idx2 = i;
                break;
            }
        }
        for(int i=idx1; i<=idx2; i++)
        {
            result += _value[i];
        }
        return result;
    }

    public string TrimStart()
    {
        int idx1 = 0;
        string result = "";
        for (int i = 0; i < _value.Length; i++)
        {
            if (' ' != _value[i])
            {
                idx1 = i;
                break;
            }
        }

        for (int i = idx1; i <_value.Length; i++)
        {
            result += _value[i];
        }
        return result;

    }

    public string TrimEnd()
    {
        int idx2 = 0;
        string result = "";
        for (int i = _value.Length - 1; i >= 0; i--)
        {
            if (_value[i] != ' ')
            {
                idx2 = i;
                break;
            }
        }

        for(int i=0; i<=idx2; i++)
        {
            result += _value[i];
        }
        return result;
    }


    //toupper da tolower dasaweri maq
    //replace dasaweri maq
    private int GetLength()
    {
        int length = 0;
        foreach (char c in _value) length++;
        return length;
    }
}

