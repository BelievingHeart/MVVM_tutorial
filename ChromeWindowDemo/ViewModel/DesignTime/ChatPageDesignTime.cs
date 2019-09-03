using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeWindowDemo
{
    public class ChatPageDesignTime : ChatPageViewModel
    {
        public static ChatPageDesignTime Instance => new ChatPageDesignTime();

        public ChatPageDesignTime()
        {
            Items = new ObservableCollection<ChatItemViewModel>
            {
                new ChatItemViewModel
                {
                    Firstname = "Jonathan",
                    LastName = "Jostar",
                    LastMessage = "ko ko ko ko ko ko",
                    TimeStringRecentChat = "15:30",
                    IconColorCode = "03e8fc",
                    MessageRead = true
                },
                new ChatItemViewModel
                {
                    Firstname = "Jonathan",
                    LastName = "Jostar",
                    LastMessage = "ko ko ko ko ko ko",
                    TimeStringRecentChat = "15:30",
                    IconColorCode = "03e8fc",
                    MessageRead = true
                },            new ChatItemViewModel
                {
                    Firstname = "Jonathan",
                    LastName = "Jostar",
                    LastMessage = "ko ko ko ko ko ko",
                    TimeStringRecentChat = "15:30",
                    IconColorCode = "03e8fc",
                    MessageRead = false
                },            new ChatItemViewModel
                {
                    Firstname = "Jonathan",
                    LastName = "Jostar",
                    LastMessage = "ko ko ko ko ko ko",
                    TimeStringRecentChat = "15:30",
                    IconColorCode = "03e8fc",
                    MessageRead = true
                },            new ChatItemViewModel
                {
                    Firstname = "Jonathan",
                    LastName = "Jostar",
                    LastMessage = "ko ko ko ko ko ko",
                    TimeStringRecentChat = "15:30",
                    IconColorCode = "dda359",
                    MessageRead = true
                },new ChatItemViewModel
                {
                    Firstname = "Jonathan",
                    LastName = "Jostar",
                    LastMessage = "ko ko ko ko ko ko",
                    TimeStringRecentChat = "15:30",
                    IconColorCode = "dda359",
                    MessageRead = true
                },new ChatItemViewModel
                {
                    Firstname = "Shirakami",
                    LastName = "Hubuki",
                    LastMessage = "ko ko ko ko ko ko",
                    TimeStringRecentChat = "15:30",
                    IconColorCode = "dda359",
                    MessageRead = true
                },new ChatItemViewModel
                {
                    Firstname = "Jonathan",
                    LastName = "Jostar",
                    LastMessage = "ko ko ko ko ko ko",
                    TimeStringRecentChat = "15:30",
                    IconColorCode = "dda359",
                    MessageRead = true
                },

            };
        }
    }
}