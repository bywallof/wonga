using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace WongaSender
{
    class Messaging
    {
        public Messaging(String senderName)
        {
            var factory = new ConnectionFactory
            {
            //    Uri = new System this has the problem of loading
            };
            
            //using  var  f = factory.CreateConnection();
        }
    }
}
