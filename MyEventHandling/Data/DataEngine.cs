using MyEventHandling.Entities;
using System.Collections.ObjectModel;

namespace MyEventHandling.Data
{
    public class DataEngine
    {
        #region Properties
        public ObservableCollection<Message> MessageList => new ObservableCollection<Message>
        {
            new Message
            {
                Id = 0,
                Text = "Msg1"
            },  new Message
            {
                Id = 1,
                Text = "Msg2"
            },  new Message
            {
                Id = 2,
                Text = "Msg3"
            },  new Message
            {
                Id = 3,
                Text = "Msg4"
            }
          //  "rffr", "rfrfr", "frf", "frfr"

        };
        public ObservableCollection<Message> GetMessages => MessageList;
        #endregion

    }
}
