using Demo;
using System;
namespace DemoTest
{
    public class ClientAddMock : IPerson
    {
        public Client CreateClient()
        {
            var testID = new Person()
            {
                Name = "Meryem",
                Surname = "Sel",
                ID = "12345"
            };

            var testClient = new Client();
            testClient.Add(testID);

            return testClient;
        }
    }
}
