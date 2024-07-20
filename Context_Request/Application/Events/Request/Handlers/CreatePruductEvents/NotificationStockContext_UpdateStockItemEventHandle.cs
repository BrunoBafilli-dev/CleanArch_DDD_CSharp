using System.Text;
using Domain.Request.Events.Request.Events;
using MediatR;
using RabbitMQ.Client;

namespace Application.Request.Events.Request.Handlers.CreatePruductEvents
{
    public class NotificationStockContext_UpdateStockItemEventHandler : INotificationHandler<CreatedRequestDomainEvent>
    {
        private readonly IMediator _mediator;

        public NotificationStockContext_UpdateStockItemEventHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Handle(CreatedRequestDomainEvent notification, CancellationToken cancellationToken)
        {
            List<object> itemsEntities = new List<object>(notification.RequestItensEntities);

            SendMessage("Item added to stock.");

            // Implementação condicional para ativar o consumidor apenas quando necessário
            if (NeedToReceiveMessages())
            {
                
                //Receiver receiver = new Receiver();
                // Passando o cancellationToken para que o processo de recebimento possa ser cancelado externamente

              
                //await receiver.ReceiveMessagesAsync(cancellationToken);// disparar evento
            }

            // Suponha que isso é o comando para atualizar o estoque
            //await _mediator.Send(new ItemStockReduceUpdateCommand(itemsEntities));
        }

        private void SendMessage(string message)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "stock_updates",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: "",
                                     routingKey: "stock_updates",
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }
        }

        private bool NeedToReceiveMessages()
        {
            // Lógica para decidir se o consumidor deve ser ativado
            return true;
        }
    }
}
