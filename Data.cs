using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsocketTool
{
    internal class Data
    {
        private int type;
        private string raw_data;
        private DateTime date_time;

        public Data(int type, string raw_data, DateTime date_time)
        {
            this.type = type;
            this.raw_data = raw_data;
            this.date_time = date_time;
        }

        public int Type { get => type; set => type = value; }
        public string Raw_data { get => raw_data; set => raw_data = value; }
        public DateTime Date_time { get => date_time; set => date_time = value; }
    }
}
