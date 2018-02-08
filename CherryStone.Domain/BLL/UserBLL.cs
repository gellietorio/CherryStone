using CherryStone.Domain.Infrastructure;
using CherryStone.Domain.Models;
using CherryStone.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.BLL
{
    public static class UserBLL
    {
        private static DataAccess db = new DataAccess();

        public static List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public static BLLOperation<User> Register(User model)
        {
            User duplicateUser = db.Users.FirstOrDefault(u => u.EmailAddress.ToLower() == model.EmailAddress.ToLower());

            if (duplicateUser == null)
            {
                db.Users.Add(model);
                db.SaveChanges();

                return new BLLOperation<User>()
                {
                    Status = Models.Enums.OperationStatus.OK,
                    Message = "Success",
                    Item = model
                };
            }
            else
            {
                return new BLLOperation<User>()
                {
                    Status = Models.Enums.OperationStatus.Error,
                    Message = "Email Address already used."
                };
            }
        }

        public static BLLOperation<User> Activate(string emailAddress, string registrationCode)
        {
            User user = db.Users.FirstOrDefault(u => u.EmailAddress.ToLower() == emailAddress.ToLower());

            if (user != null)
            {
                if (user.RegistrationCode == registrationCode)
                {

                    user.Status = LoginStatus.Active;
                    db.SaveChanges();

                    return new BLLOperation<User>()
                    {
                        Status = Models.Enums.OperationStatus.OK,
                        Message = "Success",
                        Item = user
                    };
                }
            }

            return new BLLOperation<User>()
            {
                Status = Models.Enums.OperationStatus.Error,
                Message = "User not found."
            };
        }
    }
}