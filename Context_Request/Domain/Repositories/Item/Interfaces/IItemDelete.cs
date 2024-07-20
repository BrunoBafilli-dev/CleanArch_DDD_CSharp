namespace Domain.Request.Repositories.Item.Interfaces
{
    public interface IItemDelete
    {
        Task DeleteItemAsync(int id);
    }
}
