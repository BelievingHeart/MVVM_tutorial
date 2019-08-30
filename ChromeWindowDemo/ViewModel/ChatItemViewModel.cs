namespace ChromeWindowDemo
{
    

    public class ChatItemViewModel : ViewModelBase
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Signature => $"{Firstname[0]}{LastName[0]}";
        public string FullName => $"{Firstname} {LastName}";
        public string IconColorCode { get; set; }
        public string LastMessage { get; set; }
        public string TimeStringRecentChat { get; set; }
        public bool MessageRead { get; set; }
    }
}