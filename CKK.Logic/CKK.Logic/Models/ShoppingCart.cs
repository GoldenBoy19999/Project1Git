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

      public StoreItem AddProduct(Product prod, int quantity)
      {
         if (quantity <= 0)
         {
            Console.WriteLine("Quantity must be greater than 0.");
            return null;
         }

         var existingProduct = FindProduct(prod);

         if (existingProduct != null)
         {
            
            existingProduct.SetQuantity(existingProduct.GetQuantity() + quantity);
            return existingProduct;
         }      
         return AddNewProduct(prod, quantity);
      }
      public StoreItem RemoveProduct(Product prod, int quantity)
      {
         if (quantity <= 0)
         {
            Console.WriteLine("Quantity must be greater than 0.");
            return null;
         }
         var existingProduct = FindProduct(prod);

         if (existingProduct != null)
         {
            int currentQuantity = existingProduct.GetQuantity();

            if (quantity < currentQuantity)
            {
               existingProduct.SetQuantity(currentQuantity - quantity);
               return existingProduct;
            }
            else if (quantity == currentQuantity)
            {
               RemoveProduct(existingProduct);
               return existingProduct;
            }
            else
            {
               Console.WriteLine("Cant remove more than the current quantity.");
               return null;
            }
         }

         Console.WriteLine("Product not found.");
         return null;
      }

      public decimal GetTotal()
      {
         decimal total = 0;

         if (_product1 != null)
         {
            total += _product1.GetTotal();
         }

         if (_product2 != null)
         {
            total += _product2.GetTotal();
         }

         if (_product3 != null)
         {
            total += _product3.GetTotal();
         }

         return total;
      }
      public StoreItem GetProduct(int prodNum)
      {
         if (prodNum == 1)
         {
            return _product1;
         }

         if (prodNum == 2)
         {
            return _product2;
         }

         if (prodNum == 3)
         {
            return _product3;
         }

         Console.WriteLine("Invalid product number.");
         return null;
      }
      public StoreItem FindProduct(Product prod)
      {
         if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
         {
            return _product1;
         }

         if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
         {
            return _product2;
         }

         if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
         {
            return _product3;
         }

         return null;
      }

      public void RemoveProduct(StoreItem product)
      {
         if (_product1 == product)
         {
            _product1 = null;
         }
         else if (_product2 == product)
         {
            _product2 = null;
         }
         else if (_product3 == product)
         {
            _product3 = null;
         }
      }

   }
}
