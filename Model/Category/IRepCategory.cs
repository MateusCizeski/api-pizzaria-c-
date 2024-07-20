namespace pizzaria_api.Model.Category
{
    public interface IRepCategory
    {
        public void CreateCategory(Category category);
        public List<Category> ListCategorys();
    }
}
