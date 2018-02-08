using CherryStone.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.CustomModels
{
    public class CompletePost
    {
        public Guid? Id { get; set; }

        public PostType Type { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public List<FlatComment> Comments { get; set; }

        public List<string> Hashtags { get; set; }

        public List<MiniProfile> Likes { get; set; }

        public List<MiniProfile> UserTags { get; set; }

        public string TimeAgo { get; set; }

        public MiniProfile User { get; set; }
    }

}