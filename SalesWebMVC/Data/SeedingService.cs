using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //se tem algum registro na tabela Department, Seller e SalesRecord
            if (_context.Department.Any() || _context.Seller.Any()|| _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Books");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Eletronics");

            Seller s1 = new Seller(1, "Cali", "Cali@gmail.com", new DateTime(1995,11,19), 1600.00, d1);
            Seller s2 = new Seller(2, "Claudia", "Claudia@gmail.com", new DateTime(1996, 11, 19), 1600.00, d2);
            Seller s3 = new Seller(3, "Josueh", "Josue@gmail.com", new DateTime(1997, 11, 19), 1600.00, d3);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2021,01,15), 800.00, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, DateTime.Now, 850.00, SalesStatus.Billed,  s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3);
            _context.SalesRecord.AddRange(sr1, sr2);

            _context.SaveChanges();
        }
    }
}
