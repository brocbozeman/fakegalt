using api.Models;
using api.Interfaces;
using System.Collections.Generic;
namespace api.DataAccess
{
    public class StoreDataHandlerTest : IStoreDataHandler
    {
        public List<Store> GetAllStores(){
            List<Store> myStores = new List<Store>();
            myStores.Add(new Store(){Id = 1, AddressLineOne = "123 Dirt Road", 
            City = "Severna Park",
            State = "Maryland",
            Zip = 21146});
            myStores.Add(new Store(){Id = 1, AddressLineOne = "456 Dirt Road", 
            City = "Key Largo",
            State = "Florida",
            Zip = 33037});
            myStores.Add(new Store(){Id = 1, AddressLineOne = "144 Green Drive", 
            AddressLineTwo = "10 Box",
            City = "Severna Park",
            State = "Maryland",
            Zip = 21146});

            return myStores;
        }
         public Store GetStore(int id){
             return new Store();
         }
         public void UpdateStore(Store store){

         }
         public void CreateStore(Store store){

         }
         public void DeleteStore(int id){

         }
    }
}