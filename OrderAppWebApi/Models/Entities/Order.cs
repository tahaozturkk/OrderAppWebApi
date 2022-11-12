using System.ComponentModel.DataAnnotations;

namespace OrderAppWebApi.Models.Entities
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerGSM { get; set; }
        public Decimal TotalAmount { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
