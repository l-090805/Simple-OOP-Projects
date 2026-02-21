using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreSystem
{
    public class Product
    {
        private string _name;
        private int _id;
        private decimal _price;
        public Product(string name, int id, decimal price)
        {
            _name = name;
            _id = id;
            _price = price;
        }
        public string GetName()
        {
            return _name;
        }
        public decimal GetPrice()
        {
            return _price;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Product ID -> {_id} || Product Name -> {_name} || Product Price -> {_price:C}");
        }
    }        
    public class Cart
    {
        private List<Product> _cart = new List<Product>();
        private decimal _totalPrice = 0;
        public void AddProduct(Product product)
        {
            _cart.Add(product);
            Console.WriteLine($"{product.GetName()} has been added to the cart.");
        }
        public void RemoveProduct(Product product)
        {
            if (_cart.Contains(product))
            {
                _cart.Remove(product);
                Console.WriteLine($"{product.GetName()} has been removed from the cart.");
            }
            else
            {
                Console.WriteLine($"{product.GetName()} is not in the cart.");
            }
        }
        public decimal CalculateTotal()
        {
            foreach(var product in _cart)
            {
                _totalPrice += product.GetPrice();
            }
            return _totalPrice;
        }
        public void GetCart()
        {
            Console.Write("Products in cart: ");
            foreach (var product in _cart)
            {
                Console.Write($"{product.GetName()} ");
            }
            Console.WriteLine();
        }
    }
    public class User
    {
        private string _username;
        private Cart _userCart;

        public User(string username, Cart cart)
        {
            _username = username;
            _userCart = cart;
        }
        public void ViewCart()
        {
            _userCart.GetCart();
            Console.WriteLine($"Total cart price: {_userCart.CalculateTotal():C2}");
        }
    }
    public abstract class DiscountStrategy
    {
        public abstract decimal ApplyDiscount(decimal totalPrice);
    }
    public class PercentageDiscount : DiscountStrategy
    {
        private decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public override decimal ApplyDiscount(decimal totalPrice)
        {
            return totalPrice - (totalPrice * _percentage / 100);
        }
    }
    public class FixedAmmountDiscount : DiscountStrategy
    {
        private decimal _fixedAmount;
        public FixedAmmountDiscount(decimal fixedAmount)
        {
            _fixedAmount = fixedAmount;
        }
        public override decimal ApplyDiscount(decimal totalPrice)
        {
            return totalPrice - _fixedAmount > 0 ? totalPrice - _fixedAmount : 0;
        }

    }
}
