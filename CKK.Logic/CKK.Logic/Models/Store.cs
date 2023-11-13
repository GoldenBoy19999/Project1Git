using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class Store
   {
      private int _id;
      private string _name = " ";
      private Product _product1;
      private Product _product2;
      private Product _product3;
      public int GetId()
      {
         return _id;
      }
      public void SetId(int Id)
      {
         _id = Id;
      }
      public string GetName()
      {
         return _name;
      }
      public void SetName(string Name)
      {
         _name = Name;
      }
      public void AddStoreItem(Product prod)
      {
         if (_product1 == null)
         {
            _product1 = prod;
            Console.WriteLine("Added product to spot 1");
         }
         else if (_product2 == null) 
            {
            _product2 = prod;
            Console.WriteLine("Added product to spot 2");
         }
         else if( _product3 == null)
         {
            _product3 = prod;
            Console.WriteLine("Added product to spot 3");
         }
         else
         {
            Console.WriteLine("No spots available");
         }
      }
      public void RemoveStoreItem(int productNumber) 
      {
         if (productNumber == 1)
         {
            Console.WriteLine("Remove product from spot 1");
            _product1 = null;
         }
         else if (productNumber == 2)
         {
            Console.WriteLine("Remove product from spot 2");
            _product2 = null;
         }
         else if (productNumber == 3)
            {
            Console.WriteLine("Remove product from spot 3");
            _product3 = null;
            }
         else 
         {
            Console.WriteLine("No product in range or empty");
         }
      }
      public Product GetStoreItem(int productNumber)
      {
         if (productNumber == 1)
         {
            return _product1;
         }
         else if (productNumber == 2)
         {
            return _product2;
         }
         else if (productNumber == 3)
         {
            return _product3;
         }
         else
         {
            Console.WriteLine("Invalid product number or item not in the desired spot");
            return null;
         }
      }
      public Product FindStoreItemById(int id)
      {
         Product product1 = _product1;

         if (product1 != null && product1.GetId() == id)
         {
            return product1;
         }

         Product product2 = _product2;

         if (product2 != null && product2.GetId() == id)
         {
            return product2;
         }

         Product product3 = _product3;

         if (product3 != null && product3.GetId() == id)
         {
            return product3;
         }

         return null;
      }
   }
}
