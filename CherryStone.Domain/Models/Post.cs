using CherryStone.Domain.Infrastructure;
using CherryStone.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.Models
{
    public class Post : BaseModel
    {
        public string Content { get; set; }

        public Guid? UserId { get; set; }

        public PostType Type { get; set; }

        public string Caption { get; set; }

        public virtual User User { get; set; }
    }
}

