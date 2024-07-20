namespace Domain.Request.Repositories.Request.Interfaces
{
    public interface IRequestDelete
    {
        Task DeleteRequestAsync(int id);
    }
}
