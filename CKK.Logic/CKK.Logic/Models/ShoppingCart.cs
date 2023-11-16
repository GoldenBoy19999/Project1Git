using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class ShoppingCart
   {
      private Customer _customer;
      private ShoppingCartItem _product1;
      private ShoppingCartItem _product2;
      private ShoppingCartItem _product3;
      public ShoppingCart(Customer cust)
      {
         _customer = cust;
      }
      public int GetCustomerId()
      {
         return _customer.GetId();
      }
      public StoreItem GetProductById(int id)
      {
         if (_product1 != null && _product1.GetProduct().GetId() == id)
         {
            return _product1;
         }

         if (_product2 != null && _product2.GetProduct().GetId() == id)
         {
            return _product2;
         }

         if (_product3 != null && _product3.GetProduct().GetId() == id)
         {
            return _product3;
         }

         return null;
      }
   }
}
