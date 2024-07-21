namespace pizzaria_api.Model.Products
{
    public interface IRepProduct
    {
        public void CreateProduct(Product product);
        public List<Product> ListProducts(string category_id);
    }
}
