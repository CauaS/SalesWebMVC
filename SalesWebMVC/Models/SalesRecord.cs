﻿using SalesWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double amount { get; set; }
        public SalesStatus Status { get; set; }

        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }
        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            this.amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
