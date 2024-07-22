namespace Domain.Stock.Repositories.Interfaces
{
    public interface IItemDelete
    {
        Task DeleteItemAsync(int id);
    }
}
