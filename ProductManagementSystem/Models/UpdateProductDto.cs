namespace ProductManagementSystem.Models
{
    public class UpdateProductDto
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Price { get; set; }
        public int StockQuantity { get; set; }

    }
}
