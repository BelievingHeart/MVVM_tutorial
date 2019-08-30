using System.Collections.ObjectModel;

namespace ChromeWindowDemo
{
    public class ChatPageViewModel : ViewModelBase
    {
        public ObservableCollection<ChatItemViewModel> Items { get; set; }
    }
}