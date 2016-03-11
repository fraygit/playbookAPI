﻿using playbook.MongoData.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playbook.MongoData.Model
{
    public class EmailError : MongoEntity
    {
        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string EmailId { get; set; }
        public DateTime ErrorDate { get; set; }
    }
}
