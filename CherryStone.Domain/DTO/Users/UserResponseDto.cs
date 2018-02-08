using CherryStone.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.DTO.Users
{
    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public LoginStatus Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Gender { get; set; }
    }
}
