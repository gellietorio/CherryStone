using CherryStone.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.Infrastructure
{
    public class DataInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<DataAccess>
    {
        protected override void Seed(DataAccess db)
        {
            #region Users
            db.Users.Add(
                new User()
                {
                    Id = Guid.Parse("c190f840-320a-4cca-a373-56763ba0b0c4"),
                    EmailAddress = "mxiao@yahoo.com",
                    FirstName = "Mia",
                    LastName = "Xiao",
                    Status = Models.Enums.LoginStatus.Active,
                    Gender = Models.Enums.Gender.Female,
                    LoginAttempts = 0,
                    Password = "cQtynfHcLB",
                    RegistrationCode = "XW4RLN7"
                });
            db.SaveChanges();

            db.Users.Add(new User()
            {
                Id = Guid.Parse("a07168c2-25e4-4fcc-9afe-480b98ebb82b"),
                EmailAddress = "kayvonf@comcast.net",
                FirstName = "Kaye",
                LastName = "Von",
                Status = Models.Enums.LoginStatus.Locked,
                Gender = Models.Enums.Gender.Female,
                LoginAttempts = 0,
                Password = "cz9uSTymUU",
                RegistrationCode = "M0FXI0N"
            });
            db.SaveChanges();

            db.Users.Add(new User()
            {
                Id = Guid.Parse("2efe1076-374e-409a-8a03-9613c32842fc"),
                EmailAddress = "conteb@mac.com",
                FirstName = "Conte",
                LastName = "Big",
                Status = Models.Enums.LoginStatus.Unconfirmed,
                Gender = Models.Enums.Gender.Male,
                LoginAttempts = 0,
                Password = "APhfE3RKEK",
                RegistrationCode = "2JH9HF3"
            });
            db.SaveChanges();

            db.Users.Add(new User()
            {
                Id = Guid.Parse("5dfae342-2d2a-41ab-aec3-c43a6d8d6ffd"),
                EmailAddress = "kdawson@sbcglobal.net",
                FirstName = "Keida",
                LastName = "Dawson",
                Status = Models.Enums.LoginStatus.Active,
                Gender = Models.Enums.Gender.Male,
                LoginAttempts = 0,
                Password = "NsBr3Q8Mzc",
                RegistrationCode = "90FJ53B"
            });
            db.SaveChanges();

            db.Users.Add(new User()
            {
                Id = Guid.Parse("98755819-0220-441e-94c6-60b08be98e47"),
                EmailAddress = "dcoppit@optonline.net",
                FirstName = "Diego",
                LastName = "Coppit",
                Status = Models.Enums.LoginStatus.Unconfirmed,
                Gender = Models.Enums.Gender.Male,
                LoginAttempts = 0,
                Password = "qs34EW5SrC",
                RegistrationCode = "9OAG0MR"
            });
            db.SaveChanges();

            db.Users.Add(new User()
            {
                Id = Guid.Parse("4a9c4a74-82df-46aa-83ab-9c9e3b539c15"),
                EmailAddress = "lridener@comcast.net",
                FirstName = "Lei",
                LastName = "Ridener",
                Status = Models.Enums.LoginStatus.Active,
                Gender = Models.Enums.Gender.Female,
                LoginAttempts = 0,
                Password = "msW9h8QeqS",
                RegistrationCode = "M8E0K2F"
            });
            db.SaveChanges();

            db.Users.Add(new User()
            {
                Id = Guid.Parse("ed54f04a-612d-428f-b39f-9a4e4bcf5c5b"),
                EmailAddress = "rjones@optonline.net",
                FirstName = "Red",
                LastName = "Jones",
                Status = Models.Enums.LoginStatus.Active,
                Gender = Models.Enums.Gender.Female,
                LoginAttempts = 0,
                Password = "hQGmjHCVCC",
                RegistrationCode = "IZQG137"
            });
            db.SaveChanges();

            db.Users.Add(new User()
            {
                Id = Guid.Parse("d325d5bc-5360-4e47-b958-197191840f82"),
                EmailAddress = "mobyo@sbcglobal.net",
                FirstName = "Moby",
                LastName = "Oishi",
                Status = Models.Enums.LoginStatus.Unconfirmed,
                Gender = Models.Enums.Gender.Male,
                LoginAttempts = 0,
                Password = "Lvk69vYUUp",
                RegistrationCode = "5WY39KW"
            });
            db.SaveChanges();

            db.Users.Add(new User()
            {
                Id = Guid.Parse("049a8666-3416-4c41-a32c-1d6b2995e1ca"),
                EmailAddress = "kingjoshi@att.net",
                FirstName = "King",
                LastName = "Joshi",
                Status = Models.Enums.LoginStatus.Locked,
                Gender = Models.Enums.Gender.Male,
                LoginAttempts = 0,
                Password = "q4RMkSLtgE",
                RegistrationCode = "1LTSI8Y"
            });
            db.SaveChanges();

            db.Users.Add(new User()
            {
                Id = Guid.Parse("ad1674a1-7468-4b4d-8246-dcfa30e8aa3a"),
                EmailAddress = "geoffr@verizon.net",
                FirstName = "Geoff",
                LastName = "Reid",
                Status = Models.Enums.LoginStatus.Active,
                Gender = Models.Enums.Gender.Male,
                LoginAttempts = 0,
                Password = "mQvcEr8nUf",
                RegistrationCode = "6UCADI8"
            });
            db.SaveChanges();

            #endregion

            #region Posts
            #region Post
            db.Posts.Add(
                new Post()
                {
                    Id = Guid.Parse("1a7c2a8c-8500-4863-8e3e-e409b8e397b8"),
                    Type = Models.Enums.PostType.Image,
                    Caption = "how i met your mother",
                    Content = "wp1816631-how-i-met-your-mother-wallpapers_1024x1024.jpg",
                    UserId = Guid.Parse("c190f840-320a-4cca-a373-56763ba0b0c4")
                }
            );

            db.PostComments.Add(new PostComment()
            {
                Id = Guid.Parse("304b3bb7-ab92-4b31-9273-e24954df9775"),
                Content = "I miss them!!",
                PostId = Guid.Parse("1a7c2a8c-8500-4863-8e3e-e409b8e397b8"),
                UserId = Guid.Parse("a07168c2-25e4-4fcc-9afe-480b98ebb82b")
            });

            db.PostComments.Add(new PostComment()
            {
                Id = Guid.Parse("cd1f7f68-18c4-42e9-901c-5d49f62ebd72"),
                Content = "Me too!",
                PostId = Guid.Parse("1a7c2a8c-8500-4863-8e3e-e409b8e397b8"),
                UserId = Guid.Parse("2efe1076-374e-409a-8a03-9613c32842fc")
            });

            db.PostComments.Add(new PostComment()
            {
                Id = Guid.Parse("09d8c962-3f7a-40be-9c9d-fcd31d0c7a72"),
                Content = "Me three! Lol",
                PostId = Guid.Parse("1a7c2a8c-8500-4863-8e3e-e409b8e397b8"),
                UserId = Guid.Parse("5dfae342-2d2a-41ab-aec3-c43a6d8d6ffd")
            });

            db.PostHashtags.Add(new PostHashtag()
            {
                Id = Guid.Parse("ff49abf9-cf38-4178-b16c-2f2eb0d58b24"),
                PostId = Guid.Parse("1a7c2a8c-8500-4863-8e3e-e409b8e397b8"),
                Hashtag = "himym"
            });

            db.PostHashtags.Add(new PostHashtag()
            {
                Id = Guid.Parse("c3297615-55b5-4005-b59f-467288df6b24"),
                PostId = Guid.Parse("1a7c2a8c-8500-4863-8e3e-e409b8e397b8"),
                Hashtag = "lilypad"
            });

            db.PostHashtags.Add(new PostHashtag()
            {
                Id = Guid.Parse("2e2d8339-6e5e-46c4-a912-85ef0a3f8bb2"),
                PostId = Guid.Parse("1a7c2a8c-8500-4863-8e3e-e409b8e397b8"),
                Hashtag = "Legendary!"
            });

            db.PostLikes.Add(new PostLike()
            {
                Id = Guid.Parse("ddc8ef22-021f-4465-b672-864293af00c2"),
                PostId = Guid.Parse("1a7c2a8c-8500-4863-8e3e-e409b8e397b8"),
                UserId = Guid.Parse("98755819-0220-441e-94c6-60b08be98e47")
            });

            db.PostLikes.Add(new PostLike()
            {
                Id = Guid.Parse("ddc8ef22-021f-4465-b672-864293af00c3"),
                PostId = Guid.Parse("1a7c2a8c-8500-4863-8e3e-e409b8e397b8"),
                UserId = Guid.Parse("2efe1076-374e-409a-8a03-9613c32842fc")
            });

            db.PostLikes.Add(new PostLike()
            {
                Id = Guid.Parse("ddc8ef22-021f-4465-b672-864293af00c4"),
                PostId = Guid.Parse("1a7c2a8c-8500-4863-8e3e-e409b8e397b8"),
                UserId = Guid.Parse("c190f840-320a-4cca-a373-56763ba0b0c4")
            });

            db.SaveChanges();
            #endregion

            #region Post
            db.Posts.Add(
                new Post()
                {
                    Id = Guid.Parse("e54f05da-f3e8-49b8-8b0b-edba48822a2d"),
                    Type = Models.Enums.PostType.Text,
                    Caption = "",
                    Content = "When I'm sad, I stop being sad and be awesome instead.",
                    UserId = Guid.Parse("ed54f04a-612d-428f-b39f-9a4e4bcf5c5b")
                }
            );

            db.PostComments.Add(new PostComment()
            {
                Id = Guid.Parse("a2984ec0-3419-40a1-882e-5015a560d533"),
                Content = "True story.",
                PostId = Guid.Parse("e54f05da-f3e8-49b8-8b0b-edba48822a2d"),
                UserId = Guid.Parse("d325d5bc-5360-4e47-b958-197191840f82")
            });

            db.PostComments.Add(new PostComment()
            {
                Id = Guid.Parse("a2984ec0-3419-40a1-882e-5015a560d534"),
                Content = "The Barnacle! Lol",
                PostId = Guid.Parse("e54f05da-f3e8-49b8-8b0b-edba48822a2d"),
                UserId = Guid.Parse("049a8666-3416-4c41-a32c-1d6b2995e1ca")
            });

            db.PostHashtags.Add(new PostHashtag()
            {
                Id = Guid.Parse("a2984ec0-3419-40a1-882e-5015a560d535"),
                PostId = Guid.Parse("e54f05da-f3e8-49b8-8b0b-edba48822a2d"),
                Hashtag = "LOL"
            });

            db.PostLikes.Add(new PostLike()
            {
                Id = Guid.Parse("a2984ec0-3419-40a1-882e-5015a560d536"),
                PostId = Guid.Parse("e54f05da-f3e8-49b8-8b0b-edba48822a2d"),
                UserId = Guid.Parse("ad1674a1-7468-4b4d-8246-dcfa30e8aa3a")
            });

            db.PostLikes.Add(new PostLike()
            {
                Id = Guid.Parse("a2984ec0-3419-40a1-882e-5015a560d537"),
                PostId = Guid.Parse("e54f05da-f3e8-49b8-8b0b-edba48822a2d"),
                UserId = Guid.Parse("d325d5bc-5360-4e47-b958-197191840f82")
            });

            db.PostLikes.Add(new PostLike()
            {
                Id = Guid.Parse("a2984ec0-3419-40a1-882e-5015a560d538"),
                PostId = Guid.Parse("e54f05da-f3e8-49b8-8b0b-edba48822a2d"),
                UserId = Guid.Parse("ed54f04a-612d-428f-b39f-9a4e4bcf5c5b")
            });

            db.SaveChanges();
            #endregion

            #region Post
            db.Posts.Add(
                new Post()
                {
                    Id = Guid.Parse("96f1d8f4-55c5-41db-8a73-a156f4b2b053"),
                    Type = Models.Enums.PostType.Video,
                    Caption = "It's just too beautiful.﻿",
                    Content = "<iframe src=\"https://www.youtube.com/watch?v=h6gdF8ynJDo\" width=\"560\" height=\"315\" style=\"border:none;overflow:hidden\" scrolling=\"no\" frameborder=\"0\" allowTransparency=\"true\" allowFullScreen=\"true\"></iframe>",
                    UserId = Guid.Parse("049a8666-3416-4c41-a32c-1d6b2995e1ca")
                }
            );

            db.PostComments.Add(new PostComment()
            {
                Id = Guid.Parse("4f3529d8-0aa8-4482-ba9a-a3962047ff42"),
                Content = "yet heartbreaking...",
                PostId = Guid.Parse("96f1d8f4-55c5-41db-8a73-a156f4b2b053"),
                UserId = Guid.Parse("4a9c4a74-82df-46aa-83ab-9c9e3b539c15")
            });

            db.PostComments.Add(new PostComment()
            {
                Id = Guid.Parse("4f3529d8-0aa8-4482-ba9a-a3962047ff43"),
                Content = "beautiful song",
                PostId = Guid.Parse("96f1d8f4-55c5-41db-8a73-a156f4b2b053"),
                UserId = Guid.Parse("2efe1076-374e-409a-8a03-9613c32842fc")
            });

            db.PostComments.Add(new PostComment()
            {
                Id = Guid.Parse("4f3529d8-0aa8-4482-ba9a-a3962047ff44"),
                Content = "SML",
                PostId = Guid.Parse("96f1d8f4-55c5-41db-8a73-a156f4b2b053"),
                UserId = Guid.Parse("a07168c2-25e4-4fcc-9afe-480b98ebb82b")
            });

            db.PostHashtags.Add(new PostHashtag()
            {
                Id = Guid.Parse("4f3529d8-0aa8-4482-ba9a-a3962047ff45"),
                PostId = Guid.Parse("96f1d8f4-55c5-41db-8a73-a156f4b2b053"),
                Hashtag = "TheMother"
            });

            db.PostHashtags.Add(new PostHashtag()
            {
                Id = Guid.Parse("4f3529d8-0aa8-4482-ba9a-a3962047ff46"),
                PostId = Guid.Parse("96f1d8f4-55c5-41db-8a73-a156f4b2b053"),
                Hashtag = "LaVieEnRose"
            });

            db.PostLikes.Add(new PostLike()
            {
                Id = Guid.Parse("4f3529d8-0aa8-4482-ba9a-a3962047ff47"),
                PostId = Guid.Parse("96f1d8f4-55c5-41db-8a73-a156f4b2b053"),
                UserId = Guid.Parse("c190f840-320a-4cca-a373-56763ba0b0c4")
            });

            db.PostLikes.Add(new PostLike()
            {
                Id = Guid.Parse("4f3529d8-0aa8-4482-ba9a-a3962047ff48"),
                PostId = Guid.Parse("96f1d8f4-55c5-41db-8a73-a156f4b2b053"),
                UserId = Guid.Parse("5dfae342-2d2a-41ab-aec3-c43a6d8d6ffd")
            });

            db.PostLikes.Add(new PostLike()
            {
                Id = Guid.Parse("4f3529d8-0aa8-4482-ba9a-a3962047ff49"),
                PostId = Guid.Parse("96f1d8f4-55c5-41db-8a73-a156f4b2b053"),
                UserId = Guid.Parse("98755819-0220-441e-94c6-60b08be98e47")
            });

            db.SaveChanges();
            #endregion
            #endregion
        }
    }
}

