using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.CustomModels
{
    public class FlatComment
    {
        public MiniProfile User { get; set; }

        public DateTime Timestamp { get; set; }

        public string Content { get; set; }
    }
}
