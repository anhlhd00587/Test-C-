namespace Test_C_sharp
{
    public class Product
    {
        private string _ProductId;
        private string _name;
        private string _price;

        public Product()
        {
        }

        public Product(string productId, string name, string price)
        {
            _ProductId = productId;
            _name = name;
            _price = price;
        }

        public string ProductId
        {
            get => _ProductId;
            set => _ProductId = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Price
        {
            get => _price;
            set => _price = value;
        }
    }
}