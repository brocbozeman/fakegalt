using System.Collections.Generic;
using api.Models;
namespace api.Interfaces
{
    public interface IStoreDataHandler
    {
         public List<Store> GetAllStores();
         public Store GetStore(int id);
         public void UpdateStore(Store store);
         public void CreateStore(Store store);
         public void DeleteStore(int id);

         
    }
}