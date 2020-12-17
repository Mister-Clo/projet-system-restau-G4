using NUnit.Framework;

namespace TestSalleClients
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private int nbClients;

        public int GetClients()
        {
            return this.nbClients;
        }

        public void SetClients(int clients)
        {
            this.nbClients = clients;
        }
        [Test]
        public void Test1()
        {
            Tests clients = new Tests();
            clients.SetClients(2);
            Assert.AreEqual(2, clients.GetClients());
        }
    }
}