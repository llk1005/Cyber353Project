using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyber_353_Project
{
    class NotificationHandler
    {
        // needed information for the notification handler
        private string message;

        NotificationHandler(string message)
        {
            this.message = message;
            
        }

        public bool SendMessage()
        {

            return true;
        }

    }
}
