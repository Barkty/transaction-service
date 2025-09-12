using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionService.Infrastructure.Messaging
{
    public class RabbitMqSettings
    {
        public string HostName { get; set; } = string.Empty;
        public int Port { get; set; } = 5672;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string QueueName { get; set; } = string.Empty;
    }

}