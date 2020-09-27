using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Markup.Localizer;

namespace WpfApp3
{
    public class MessageLOG
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public long id { get; set; }
        public string msg { get; set; }
        public MessageLOG(string Name, string Time, long id, string msg)
        {
            this.Name = Name;
            this.Time = Time;
            this.id = id;
            this.msg = msg;
        }
    }
}
