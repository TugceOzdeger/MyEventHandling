using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyEventHandling;
using MyEventHandling.Data;

namespace MyEventHandlingTest
{
    [TestClass]
    public class ViewModelUnitTests
    {
        [TestMethod]
        public void Test_If_Can_Execute()
        {
            PublisherViewModel p = new PublisherViewModel();
            object o = new object();
            Assert.IsTrue(p.CanExecute(o));
        }

        [TestMethod]
        public void Test_If_Can_Add_Messages()
        {
            PublisherViewModel p = new PublisherViewModel();
            p.MessageText1 = "Msg 5";
            p.SendMessage(p.MessageText1);
            Assert.AreEqual(p.SubscriberViewModel.MessageList.Count, 5);
            p.MessageText2 = "Msg 6";
            p.SendMessage(p.MessageText2);
            Assert.AreEqual(p.SubscriberViewModel.MessageList.Count, 6);
        }

        [TestMethod]
        public void Test_If_Can_Load_Messages()
        {
            PublisherViewModel p = new PublisherViewModel();
            DataEngine data = new DataEngine();
            Assert.AreEqual(p.SubscriberViewModel.MessageList.Count, data.MessageList.Count);
        }
    }
}
