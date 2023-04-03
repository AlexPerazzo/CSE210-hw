namespace Foundation2.Classes
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public string CreateShippingLabel()
        {
            string name = _customer.GetName();
            Address address = _customer.GetAddress();
            string fulladdress = address.GetFullAddress();
            string label = $"{name}; {fulladdress}";

            return label;
        }

        public string CreatePackingLabel()
        {
            List<string> everything = new List<string>();
            foreach (Product product in _products)
            {
                string name = product.GetName();
                string productid = product.GetProductID();

                string item = $"{name}: {productid}";
                everything.Add(item);
            }

            string result = String.Join("\n", everything);
            return result;
        }

        public int DetermineShippingCost()
        {
            if (_customer.IsInUSA())
            {
                return 5;
            }
            else
            {
                return 35;
            }
        }

        public float ReturnTotalCost()
        {
            float shipping;
            float total = 0;
            foreach (Product product in _products)
            {
                total += product.ReturnTotalPrice();
            }

            if (_customer.IsInUSA())
            {
                shipping = 5;
            }
            else
            {
                shipping = 35;
            }

            return total + shipping;

        }


    }

}