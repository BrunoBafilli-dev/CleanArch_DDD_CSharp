namespace Domain.Request.Entities
{
    public abstract class Entity<TIdentity>
    {
        public TIdentity Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        public Entity()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
