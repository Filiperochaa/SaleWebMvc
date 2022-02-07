using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed() 
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any()) 
            {
                return;
            }

            Department d1 = new Department (1, "LOJA 1");
            Department d2 = new Department(2, "LOJA 2");
            Department d3 = new Department(3, "LOJA 3");
            Department d4 = new Department(4, "LOJA 4");
            Department d5 = new Department(5, "LOJA 5");


            Seller s1 = new Seller(1, "Maria", "maria@email.com", new DateTime(1997, 4, 20), 2000.00, d1);
            Seller s2 = new Seller(2, "Joao", "joao@email.com", new DateTime(2000, 10, 30), 10000.00, d2);
            Seller s3 = new Seller(3, "Renato", "renato@email.com", new DateTime(1982, 6, 16), 3000.00, d3);
            Seller s4 = new Seller(4, "Marcio", "marcio@email.com", new DateTime(1990, 9, 09), 1500.00, d4);
            Seller s5 = new Seller(5, "Jose", "jose@email.com", new DateTime(1987, 1, 10), 5000.00, d5);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022, 01, 24), 1750.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2022, 01, 4), 4750.0, SaleStatus.Pending, s3);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 02, 4), 850.0, SaleStatus.Pending, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2022, 01, 12), 50.0, SaleStatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2022, 01, 18), 450.0, SaleStatus.Billed, s4);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2022, 01, 24), 550.0, SaleStatus.Billed, s5);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2022, 01, 24), 1750.0, SaleStatus.Canceled, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2022, 01, 19), 1750.0, SaleStatus.Canceled, s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2022, 01, 02), 1750.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2022, 01, 10), 2750.0, SaleStatus.Billed, s3);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2022, 01, 24), 3950.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2022, 01, 25), 5750.0, SaleStatus.Billed, s2);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2022, 01, 26), 3600.0, SaleStatus.Canceled, s5);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2022, 02, 01), 750.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2022, 02, 02), 150.0, SaleStatus.Billed, s5);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2022, 02, 04), 130.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2022, 02, 04), 50.0, SaleStatus.Pending, s4);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2022, 02, 06), 3240.0, SaleStatus.Pending, s2);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2022, 02, 07), 120.0, SaleStatus.Pending, s2);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2022, 01, 19), 6340.0, SaleStatus.Pending, s4);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2022, 01, 13), 2340.0, SaleStatus.Pending, s5);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2022, 01, 22), 5640.0, SaleStatus.Pending, s3);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2022, 01, 27), 3750.0, SaleStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, 
                                          r11, r12, r13, r14, r15, r16, r17, 
                                          r18, r19, r20, r21, r22, r23);

            _context.SaveChanges(); 

        }

    }
}
