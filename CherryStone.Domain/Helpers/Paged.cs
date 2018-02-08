using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.Helpers
{
    public class Paged<T>
    {
        public List<T> Items { get; set; }
        public long QueryCount { get; set; }
        public long PageCount { get; set; }
        public long PageIndex { get; set; }
        public long PageSize { get; set; }
    }
}
