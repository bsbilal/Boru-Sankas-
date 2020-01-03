using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoruSankasi
{
   public class GetDataDifference
    {
     public TimeSpan getDateDifference(DateTime date1, DateTime date2)
        {

            TimeSpan ts = date1 - date2;

            if (date1 < date2)
                return -ts;
            return ts;
        }
    }
}
