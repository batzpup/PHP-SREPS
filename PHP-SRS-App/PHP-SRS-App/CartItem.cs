namespace PHP_SRS_App
{
    internal class CartItem
    {
        public string _name;
        public int _id;
        public int _quantity;
        public CartItem(string name, int id, int quantity)
        {
            _name = name;
            _id = id;
            _quantity = quantity;
        }
    }
}