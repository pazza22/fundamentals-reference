using System.Collections;
using System.Collections.Generic;

namespace Iterator.Blueprint.DaysInMonth
{
    internal class DaysInMonthCollection : IEnumerable<MonthWithDays>
    {
        public IEnumerator<MonthWithDays> GetEnumerator()
        {
            return new DaysInMonthEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
