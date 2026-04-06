using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Record
    {
        public string Text {get; set;}
        public string Status { get; private set; }

        public Record(string text, string status)
        {
            Text = text;
            this.Status = status;
        }

        public void UpdateStatus(string text)
        {
            if (text == "Done" || text == "In Progress" || text == "To Do")
            {
                Status = text;
            }
            else
            {
                throw new ArgumentException("Status must be 'Done', 'In Progress', or 'To Do'.");
            }
        }

    }
}
