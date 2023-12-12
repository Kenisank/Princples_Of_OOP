using OOP_PRINCIPLES.Console.Models;
using Princples_Of_OOP.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PRINCIPLES.Console.DataAccess
{
    public class ProductHistoryRepository : ICrudRepository<ProductHistory>
    {
        private readonly DatabaseManager _context;
        private readonly List<ProductHistory> ListSet;


        public ProductHistoryRepository(DatabaseManager context)
        {
            _context = context;
            ListSet = _context.ProductPriceHistories;
        }

        public void DeleteRecord(int id)
        {
            ListSet.RemoveAt(id);
        }

        public void InsertData(ProductHistory productHistory)
        {
            ListSet.Add(productHistory);
        }

        public IEnumerable<ProductHistory> LoadData()
        {
            return ListSet.ToList();
        }

        public void UpdateRecord(ProductHistory productHistory)
        {
            var existingProductHistory = ListSet.FirstOrDefault(p => p.ProductId == productHistory.ProductId);
            if (existingProductHistory != null)
            {
                existingProductHistory.ListPrice = productHistory.ListPrice;
                existingProductHistory.ModifiedDate = productHistory.ModifiedDate;
            }
        }



    }
}
