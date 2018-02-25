using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListPairs
    {
        public ListPairs(int i, int k,int myPosition)
        {
            rowValue = i;
            colValue = k;
            position = myPosition;
        }

        public int rowValue { get; set; }
        public int colValue { get; set; }
        public int position { get; set; }
    }
}
