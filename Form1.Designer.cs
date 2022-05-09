namespace WebsocketTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.ListBox();
            this.send = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.open = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label_msg = new System.Windows.Forms.Label();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(113, 15);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(267, 25);
            this.server.TabIndex = 0;
            this.server.Text = "ws://127.0.0.1:2346";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "websocket:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.send);
            this.panel1.Controls.Add(this.message);
            this.panel1.Controls.Add(this.server);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 450);
            this.panel1.TabIndex = 2;
            // 
            // Data
            // 
            this.Data.FormattingEnabled = true;
            this.Data.ItemHeight = 15;
            this.Data.Location = new System.Drawing.Point(3, 46);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(494, 319);
            this.Data.TabIndex = 5;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(359, 370);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(83, 46);
            this.send.TabIndex = 4;
            this.send.Text = "发送消息";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(26, 369);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(297, 47);
            this.message.TabIndex = 3;
            this.message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_KeyDown);
            this.message.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.message_MouseDoubleClick);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.GreenYellow;
            this.open.Location = new System.Drawing.Point(581, 52);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(123, 72);
            this.open.TabIndex = 2;
            this.open.Text = "websocket连接";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Yellow;
            this.close.Location = new System.Drawing.Point(581, 207);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(123, 72);
            this.close.TabIndex = 3;
            this.close.Text = "关闭连接";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Crimson;
            this.clear.Location = new System.Drawing.Point(581, 333);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(123, 72);
            this.clear.TabIndex = 4;
            this.clear.Text = "清空输入框";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label_msg
            // 
            this.label_msg.AutoSize = true;
            this.label_msg.Location = new System.Drawing.Point(541, 426);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(0, 15);
            this.label_msg.TabIndex = 5;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(WebsocketTool.Program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_msg);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.close);
            this.Controls.Add(this.open);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ws测试工具";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Label label_msg;
        private System.Windows.Forms.ListBox Data;
    }
}

