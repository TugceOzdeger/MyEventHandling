using MyEventHandling.Data;
using MyEventHandling.Entities;
using System.Collections.ObjectModel;

namespace MyEventHandling
{
    public class SubscriberViewModel
    {
        public SubscriberViewModel()
        {
            DataEngine data = new DataEngine();
            MessageList = data.GetMessages;
        }

        #region Properties
        public ObservableCollection<Message> MessageList { get; set;}
        #endregion

        public void SendMessage(string newText)
        {
            var id = MessageList.Count;
            MessageList.Add(new Message { Id = id+1, Text = newText });
        }
    }
}
