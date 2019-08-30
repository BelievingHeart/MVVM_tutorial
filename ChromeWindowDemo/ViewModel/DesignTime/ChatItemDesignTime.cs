using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeWindowDemo
{
    public class ChatItemDesignTime : ChatItemViewModel
    {
        public static ChatItemDesignTime Instance = new ChatItemDesignTime();

        public ChatItemDesignTime()
        {
            Firstname = "Jonathan";
            LastName = "Jostar";
            LastMessage = "ko ko ko ko ko ko";
            TimeStringRecentChat = "15:30";
            IconColorCode = "03e8fc";
            MessageRead = false;
        }
    }
}
