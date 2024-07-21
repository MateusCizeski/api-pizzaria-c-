using pizzaria_api.Model.Products;

namespace pizzaria_api.Repositorio
{
    public class RepProduct : IRepProduct
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void CreateProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public List<Product> ListProducts(string category_id)
        {
            var findByCategory = _context.Product.Where(p => p.category_id == category_id).ToList();

            return findByCategory;
        }
    }
}
