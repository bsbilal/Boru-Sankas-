using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BoruSankasi
{
   public class DecideString
    {

       public bool TextControl(string testValue)
        {

            var regx = new Regex("[^a-zA-Z0-9_.]");
            if (regx.IsMatch(testValue))
                return false;
            else
                return true;

        }

    }
}
