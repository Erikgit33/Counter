using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal class Counter
    {
        int count;
        //int start;

        public Counter(int startValue)
        {
            //start = startValue;
            count = startValue;
        }

        public void Increment()
        {
            count++;
        }

        public void IncrementBy(int value)
        {
            count += value;
        }

        public void Reset()
        {
            count = 0;
        }

        public string GetCount()
        {
            return count.ToString();
        }
    }
}
