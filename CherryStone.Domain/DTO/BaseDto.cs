﻿using CherryStone.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.DTO
{
    public class BaseDto
    {
        public Guid Id { get; set; }

        public DateTime Timestamp { get; set; }

        public LoginStatus LoginStatus { get; set; }
    }
}