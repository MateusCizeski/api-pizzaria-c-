using pizzaria_api.Model.Category;

namespace pizzaria_api.Repositorio
{
    public class RepCategory : IRepCategory
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void CreateCategory(Category category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
        }

        public List<Category> ListCategorys()
        {
            var categorys = _context.Category.ToList();
            return categorys;
        }
    }
}
