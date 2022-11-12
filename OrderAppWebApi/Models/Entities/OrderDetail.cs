namespace OrderAppWebApi.Models.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Decimal UnitPrice { get; set; }
    }
}
