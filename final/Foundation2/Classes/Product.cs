namespace Foundation2.Classes
{
    public class Product
    {
        private string _name;
        private string _productid;
        private double _price;
        private int _quantity;

        public Product(string name, string productid, double price, int quantity)
        {
            _name = name;
            _productid = productid;
            _price = price;
            _quantity = quantity;
        }

        public string GetProductID()
        {
            return _productid;
        }

        public string GetName()
        {
            return _name;
        }
        public double ReturnTotalPrice()
        {
            double total = _price * _quantity;
            return Math.Round(total, 2);
        }
    }
}