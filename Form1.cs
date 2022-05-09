using System;
using System.Net.WebSockets;
using System.Windows.Forms;
using WebSocketSharp;


namespace WebsocketTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        public WebSocketSharp.WebSocket ws = null;

        private void open_Click(object sender, EventArgs e)
        {
            var server_uri = server.Text;
            insert_data("websocket地址:"+server_uri);
            if (this.ws != null)
            {
                this.ws.Close();
            }
            this.ws = new WebSocketSharp.WebSocket(server_uri);

            this.ws.OnOpen += Ws_OnOpen;
            this.ws.OnClose += Ws_OnClose;
            this.ws.OnError += Ws_OnError;
            this.ws.OnMessage += Ws_OnMessage;
            this.ws.Connect();


        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            insert_data(e.Data.ToString(), 1);
        }

        private void Ws_OnError(object sender, ErrorEventArgs e)
        {
            insert_data("发生错误:" + e.ToString());
        }

        private void Ws_OnClose(object sender, CloseEventArgs e)
        {
            insert_data("与服务端断开连接", 1);
        }

        private void Ws_OnOpen(object sender, EventArgs e)
        {
            insert_data("连接成功",1);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Data.Items.Clear();
        }

        private void insert_data(string data,int type=0)
        {
            string dateTime = DateTime.Now.ToLongDateString();
            string er;
             if (type != 0)
            {
                 er = "服务端";
            }
            else
            {
                 er = "客户端";
            };

            Data.Items.Add(er + ">>>"+dateTime+":"+data);
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (this.ws == null)
            {
                MessageBox.Show("websocket未连接");
                return;
            }
            insert_data(message.Text);
            this.ws.Send(message.Text);
        }

        private void message_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send_Click(sender, e);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (this.ws != null)
            {
                this.ws.Close();
            }
            else
            {
                insert_data("websocket未处于连接状态");
            }
        }
    }
}
