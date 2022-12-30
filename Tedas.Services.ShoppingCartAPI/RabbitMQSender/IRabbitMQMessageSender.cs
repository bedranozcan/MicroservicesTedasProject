using Tedas.MessageBus;

namespace Tedas.Services.ShoppingCartAPI.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(BaseMessage baseMessage, String queueName);
    }
}
