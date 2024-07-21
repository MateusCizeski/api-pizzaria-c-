namespace pizzaria_api.Model.Products.DTOs
{
    public class CreateProductDTO
    {
        public string name {  get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public string banner { get; set; }
        public string category_id { get; set; }
    }
}
