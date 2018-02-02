using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStringLib
{
  class MyString
  {
    
    public static string RemoveNullTerminatedFromString(string str)
    {
      if (str == null) return null;

      int pos = str.IndexOf((char)0);
      if (pos != -1)
      {
        str = str.Substring(0, pos);
      }
      return str;
    }


  }
}
