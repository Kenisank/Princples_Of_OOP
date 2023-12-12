using OOP_PRINCIPLES.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princples_Of_OOP.DataAccess.Interfaces
{
    public interface ICrudRepository<T> where T : class
    {

        //R
        IEnumerable<T> LoadData();


        //C
        void InsertData(T entity);

        //U
        void UpdateRecord(T entity);


        //D
        void DeleteRecord(int id);




    }
}
