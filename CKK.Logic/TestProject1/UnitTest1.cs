using CKK.Logic.Models;
using System.Net.Http.Headers;
using Xunit.Sdk;

namespace CKK.Tests
{
    public class ShoppingCartTest
    {
        [Fact]
        public void ShoppingCartTest1()
        {
            try
            {
                Customer cust1 = new Customer();
                ShoppingCart cart = new ShoppingCart(cust1);
                Product product = new Product();
                ShoppingCartItem shoppingCartItem = new ShoppingCartItem(product, 4);

                product.SetId(4);
                cart.AddProduct(product);

                int actual = cart.GetProduct(1).GetQuantity();


                Assert.Equal(4, cart.GetProduct(1).GetProduct().GetId());

            }
            catch
            {
                throw new XunitException("Invalid product");
            }


        }
        [Fact]
        public void ShoppingCartRemoveProduct()
        {
            try
            {
                Customer customer = new Customer();
                ShoppingCart cart1 = new ShoppingCart(customer);
                Product pro = new Product();
                ShoppingCartItem shoppingcart = new ShoppingCartItem(pro, 2);
                pro.SetId(2);
                cart1.AddProduct(pro, 2);
                cart1.RemoveProduct(pro, 1);


                Assert.Equal(1, cart1.GetProduct(1).GetQuantity());
            }
            catch
            {
                throw new XunitException("Invalid quantity");
            }
        }
        [Fact]
        public void ShoppingCartGetTotal()
        {

            try
            {
                Customer cust1 = new Customer();
                ShoppingCart cart2 = new ShoppingCart(cust1);
                Product pro1 = new Product();
                ShoppingCartItem shoppingcart2 = new ShoppingCartItem(pro1, 2);
                pro1.SetId(2);
                pro1.SetPrice(5.99m);
                cart2.AddProduct(pro1, 2);

                Assert.Equal(11.98m, cart2.GetTotal());
            }
            catch
            {
                throw new XunitException("Invalid input");
            }
            
        }
    }
}