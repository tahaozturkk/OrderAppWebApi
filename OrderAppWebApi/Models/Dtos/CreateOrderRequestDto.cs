namespace OrderAppWebApi.Models.Dtos
{
    public class CreateOrderRequestDto
    {
        public int CustomerName { get; set; }
        public int CustomerEmail { get; set; }
        public int CustomerGSM { get; set; }
        public List<ProductDetailDto> ProductDetails { get; set; }

    }
}
