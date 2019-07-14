﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Models
{
    public class TransferViewModel
    {
        public string TranferNotes { get; set; }
        public int FromAccout { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }

    }
}
