namespace ASPnetlab1
{
    public class Company
    {
        public string Name { get; set; }
        public int StocksCount { get; set; }
        public float StocksPrice { get; set; }
        public Company(string name, int stockscount, float stocksprice)
        {
            this.Name = name;
            this.StocksCount = stockscount;
            this.StocksPrice = stocksprice;
        }
    }
}
