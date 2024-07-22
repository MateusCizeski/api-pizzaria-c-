using pizzaria_api.Model.Items;

namespace pizzaria_api.Repositorio
{
    public class RepItem : IRepItems
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void CreateItem(Item item)
        {
            _context.Item.Add(item);
            _context.SaveChanges();
        }
    }
}
