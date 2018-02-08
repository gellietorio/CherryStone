using CherryStone.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.Models
{
    public class PostComment : BaseModel
    {
        public Guid? PostId { get; set; }

        public Guid? UserId { get; set; }

        public string Content { get; set; }

        public virtual Post Post { get; set; }

        public virtual User User { get; set; }
    }
}
