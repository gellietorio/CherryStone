using CherryStone.Domain.CustomModels;
using CherryStone.Domain.Infrastructure;
using CherryStone.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.BLL
{
    public static class PostBLL
    {
        private static DataAccess db = new DataAccess();

        public static CompletePost GetPost(Guid? Id)
        {
            CompletePost result = new CompletePost();
            Post post = db.Posts.Include("User").FirstOrDefault(p => p.Id == Id);

            if (post != null)
            {
                result.Id = post.Id;
                result.Content = post.Content;
                result.TimeAgo = StringHelper.TimeAgo(post.Timestamp);
                if (post.Type == Models.Enums.PostType.Image)
                {
                    result.Title = post.Caption;
                }
                else if (post.Type == Models.Enums.PostType.Link)
                {
                    result.Title = post.Content;
                }
                else if (post.Type == Models.Enums.PostType.Text)
                {
                    result.Title = post.Content;
                }
                else if (post.Type == Models.Enums.PostType.Video)
                {
                    result.Title = post.Caption;
                }

                result.Type = post.Type;

                result.User = new MiniProfile()
                {
                    Id = post.UserId,
                    Name = post.User.FirstName + " " + post.User.LastName
                };

                result.Comments = db.PostComments
                                        .Include("User")
                                        .Where(c => c.PostId == post.Id)
                                        .Select(c => new FlatComment()
                                        {
                                            Content = c.Content,
                                            Timestamp = c.Timestamp,
                                            User = new MiniProfile()
                                            {
                                                Id = c.UserId,
                                                Name = c.User.FirstName + " " + c.User.LastName
                                            }
                                        }).ToList();

                result.Hashtags = db.PostHashtags
                                        .Where(h => h.PostId == post.Id)
                                        .Select(h => h.Hashtag).ToList();

                result.Likes = db.PostLikes
                                        .Include("User")
                                        .Where(l => l.PostId == post.Id)
                                        .Select(l => new MiniProfile()
                                        {
                                            Id = l.UserId,
                                            Name = l.User.FirstName + " " + l.User.LastName
                                        }).ToList();

                result.UserTags = db.PostUserTags
                                        .Include("User")
                                        .Where(t => t.PostId == post.Id)
                                        .Select(t => new MiniProfile()
                                        {
                                            Id = t.UserId,
                                            Name = t.User.FirstName + " " + t.User.LastName
                                        }).ToList();
            }

            return result;
        }

        public static Page<CompletePost> Search(int pageIndex = 1, int pageSize = 5, string keyword = "")
        {
            Page<CompletePost> result = new Page<CompletePost>();


            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Post> postQuery = (IQueryable<Post>)db.Posts;

            if (string.IsNullOrEmpty(keyword) == false)
            {
                postQuery = postQuery.Where(u => u.Caption.Contains(keyword)
                                            || u.Content.Contains(keyword));
            }

            long queryCount = postQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Post> posts = new List<Post>();

            posts = postQuery.OrderByDescending(p => p.Timestamp)
                             .Skip(skip)
                             .Take((int)pageSize)
                             .ToList();

            List<CompletePost> resultPosts = new List<CompletePost>();
            foreach (Post post in posts)
            {
                resultPosts.Add(GetPost(post.Id));
            }

            result.Items = resultPosts;
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;

            return result;
        }
    }
}
