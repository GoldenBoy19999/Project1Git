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
            return _customer;
        }
        public ShoppingCartItem GetProductById(int id)
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
                return (_product3);
            }
            return null;
        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            // runs other add product method with quantity 1
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Invalid quantity");
                return null;
            }
            // checks for product and removes quanity if found
           // returns the product changed or null
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Invalid quantity");
                return null;
            }
            // checks for product and removes quantity if found
            // returns the product changed or null
        }
        public decimal GetTotal()
        {
            //returns total of all products
        }
        public ShoppingCartItem GetProduct(int prodNum)
        {
            //returns the product in the position of prodNumor null
        }

   }
}
