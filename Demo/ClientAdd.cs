using System.Collections.Generic;

namespace Demo
{
    public class ClientAdd : IPerson
    {
        public Client CreateClient()
        {
            var client1 = new Person()
            {
                Name = "Meryem",
                Surname = "Sel",
                ID = "12345"
            };
            var client2 = new Person()
            {
                Name = "Zeynep",
                Surname = "Sel",
                ID = "67890"
            };
            var client3 = new Person()
            {
                Name = "Betul",
                Surname = "Sel",
                ID = "12567"
            };
            var client = new Client();
            client.Add(client1);
            client.Add(client2);
            client.Add(client3);

            return client;
        }
    }
}