﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace blazorTest.Server.Models
{
    public class Thread : ICreateAndUpdateDate
    {
        public Guid Id { get; set; }
        public string ApplicationUserId { get; set; }
        public Guid PostId { get; set; }

        [MaxLength(200)]
        public string Text { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}