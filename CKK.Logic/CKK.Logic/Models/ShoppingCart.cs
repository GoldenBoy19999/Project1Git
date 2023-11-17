using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
                return _product3;
            }
            return null;
        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Invalid quantity");
                return null;
            }
            if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
               int quantity1 = _product1.GetQuantity();
                _product1.SetQuantity(quantity1 + quantity);
                return _product1;

            }
            if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                int quantity2 = _product2.GetQuantity();
                _product2.SetQuantity(quantity2 + quantity);
                return _product2;
            }
            if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                int quantity3 = _product3.GetQuantity();
                _product3.SetQuantity(quantity3 + quantity);
                return _product3;
            }
            if (_product1 == null)
            {
                _product1 = new ShoppingCartItem(prod, quantity);
                return _product1;
            }
            if (_product2 == null)
            {
                _product2 = new ShoppingCartItem(prod, quantity);
                return _product2;
            }
            if (_product3 == null)
            {
                _product3 = new ShoppingCartItem(prod, quantity);
                return _product3;
            }
            return null;
           
            
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Invalid quantity");
                return null;
            }
            if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
                int quantity1 = _product1.GetQuantity();
                _product1.SetQuantity(quantity1 - quantity);
                return _product1;

            }
            if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                int quantity2 = _product2.GetQuantity();
                _product2.SetQuantity(quantity2 - quantity);
                return _product2;
            }
            if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                int quantity3 = _product3.GetQuantity();
                _product3.SetQuantity(quantity3 - quantity);
                return _product3;
            }
            return null;
           
         
        }
        public decimal GetTotal()
        {
            decimal total = 0;
            total += _product1.GetQuantity() * _product1.GetProduct().GetPrice();
            total += _product2.GetQuantity() * _product2.GetProduct().GetPrice();
            total += _product3.GetQuantity() * _product3.GetProduct().GetPrice();
            return total;
        }
        public ShoppingCartItem GetProduct(int prodNum)
        {
            switch (prodNum)
            {
                case 1:
                    return _product1;
                    case 2:
                    return _product2;
                    case 3:
                    return _product3;
                default:
                    Console.WriteLine("Invalid input");
                    return null;
            }
        }

   }
}
