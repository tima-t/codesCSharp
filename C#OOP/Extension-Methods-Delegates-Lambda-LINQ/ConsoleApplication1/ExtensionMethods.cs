using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsB
{
   public static class ExtensionMethods
    {
       public static StringBuilder Substring(this StringBuilder str ,int index, int length){
          var result = new StringBuilder();
           for (int i = 0; i < str.Length; i++)
			{
                if (i>=index && i<index+length)
                {
                    result.Append(str[i]);
                }
			}
           return result;

       }
    }
}
