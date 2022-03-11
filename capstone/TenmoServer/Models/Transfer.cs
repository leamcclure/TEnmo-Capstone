﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenmoServer.Models
{
    public class Transfer
    {
        public int Id { get; set; }

        public int TransferTo { get; set; }

        public int TransferFrom { get; set; }

        public decimal Amount { get; set; }
        public string OtherUserName { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public Transfer()
        {

        }
        public Transfer(int id, int transferTo, int transferFrom, decimal amount, string username, string type, string status)
        {
            Id = id;
            TransferTo = transferTo;
            TransferFrom = transferFrom;
            Amount = amount;
            OtherUserName = username;
            Type = type;
            Status = status;
        }


    }
}

