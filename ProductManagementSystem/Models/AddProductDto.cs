namespace ProductManagementSystem.Models
{
    public class AddProductDto
    {
        //public Guid Id { get; set; } //Globally Unique Identifier

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Price { get; set; }
        public int StockQuantity { get; set; }

    }
}
