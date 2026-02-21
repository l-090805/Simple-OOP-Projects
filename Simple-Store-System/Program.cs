namespace OnlineStoreSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("laptop",1,1200.00m);
            Product product2 = new Product("smartphone", 2, 800.00m);
            Product product3 = new Product("tablet", 3, 500.00m);
            product1.DisplayDetails();
            product2.DisplayDetails();
            product3.DisplayDetails();

            Console.WriteLine();

            Cart cart1 = new Cart();
            cart1.AddProduct(product1);
            cart1.AddProduct(product2);
            cart1.AddProduct(product3);

            Console.WriteLine();

            User user1 = new User("John", cart1);

            FixedAmmountDiscount discountFixed = new FixedAmmountDiscount(100.00m);
            PercentageDiscount discountPercentage = new PercentageDiscount(10.00m);

            decimal total = cart1.CalculateTotal();
            Console.WriteLine($"Total before discount: {total}");

            decimal totalAfterFixed = discountFixed.ApplyDiscount(total);
            decimal totalAfterPercentage = discountPercentage.ApplyDiscount(total);
            Console.WriteLine($"Total after fixed discount: {totalAfterFixed}");
            Console.WriteLine($"Total after percentage discount: {totalAfterPercentage}");

        }
    }
}
