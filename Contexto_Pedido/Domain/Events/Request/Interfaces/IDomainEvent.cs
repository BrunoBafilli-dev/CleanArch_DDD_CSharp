namespace Domain.Request.Events.Request.Interfaces
{
    public interface IDomainEvent
    {
        public DateTime OcurredOn { get; set; }
    }
}
