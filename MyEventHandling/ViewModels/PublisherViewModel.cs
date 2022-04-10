using MyApplication;
using System.Windows.Input;

namespace MyEventHandling
{
    public class PublisherViewModel
    {
        public PublisherViewModel()
        {
            SubscriberViewModel = new SubscriberViewModel();
        }

        #region Commands
        public ICommand ClickCommand1 => new DelegateCommand(CanExecute, OpenDialogue1);
        public ICommand ClickCommand2 => new DelegateCommand(CanExecute, OpenDialogue2);
        #endregion

        #region Properties       
        public string MessageText1 { get; set; }
        public int NumberOfSubscribers1 { get; set; }
        public string MessageText2 { get; set; }
        public int NumberOfSubscribers2 { get; set; }
        public SubscriberViewModel SubscriberViewModel { get; set; }   
        #endregion

        #region Functions
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void OpenDialogue1(object o)
        {
            SendMessage(MessageText1);
            if (NumberOfSubscribers1 > 0)
            {
                SubscriberView subscriberView = new SubscriberView();
                subscriberView.Show();
                NumberOfSubscribers1--;

                for (var i = 0; i < NumberOfSubscribers1; i++)
                {                    
                    OpenDialogue1(o);                    
                }
            }
        }

        public void OpenDialogue2(object o)
        {
            SendMessage(MessageText2);
            if (NumberOfSubscribers2 > 0)
            {
                SubscriberView subscriberView = new SubscriberView();
                subscriberView.Show();
                NumberOfSubscribers2--;

                for (var i = 0; i < NumberOfSubscribers2; i++)
                {                    
                    OpenDialogue2(o);                    
                }
            }
        }

        public void SendMessage(string message)
        {
            if (message != null)
                SubscriberViewModel.SendMessage(message);
        }
        #endregion
    }
}
