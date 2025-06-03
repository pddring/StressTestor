namespace StressTestor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstLog = new ListBox();
            label1 = new Label();
            txtURL = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtCount = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtThreads = new TextBox();
            label3 = new Label();
            txtDelay = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            groupBox3 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnGo = new Button();
            btnStop = new Button();
            btnClear = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstLog
            // 
            lstLog.Dock = DockStyle.Fill;
            lstLog.FormattingEnabled = true;
            lstLog.Location = new Point(3, 23);
            lstLog.Margin = new Padding(3, 4, 3, 4);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(465, 543);
            lstLog.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 19);
            label1.TabIndex = 2;
            label1.Text = "URL:";
            // 
            // txtURL
            // 
            txtURL.Dock = DockStyle.Fill;
            txtURL.Location = new Point(156, 4);
            txtURL.Margin = new Padding(3, 4, 3, 4);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(278, 26);
            txtURL.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.05155F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.9484558F));
            tableLayoutPanel1.Controls.Add(txtCount, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtURL, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtThreads, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDelay, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(437, 127);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // txtCount
            // 
            txtCount.Dock = DockStyle.Fill;
            txtCount.Location = new Point(156, 97);
            txtCount.Margin = new Padding(3, 4, 3, 4);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(278, 26);
            txtCount.TabIndex = 9;
            txtCount.Text = "10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 93);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 8;
            label4.Text = "Count:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 4;
            label2.Text = "Threads:";
            // 
            // txtThreads
            // 
            txtThreads.Dock = DockStyle.Fill;
            txtThreads.Location = new Point(156, 38);
            txtThreads.Margin = new Padding(3, 4, 3, 4);
            txtThreads.Name = "txtThreads";
            txtThreads.Size = new Size(278, 26);
            txtThreads.TabIndex = 5;
            txtThreads.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 68);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 6;
            label3.Text = "Delay:";
            // 
            // txtDelay
            // 
            txtDelay.Dock = DockStyle.Fill;
            txtDelay.Location = new Point(156, 72);
            txtDelay.Margin = new Padding(3, 4, 3, 4);
            txtDelay.Name = "txtDelay";
            txtDelay.Size = new Size(278, 26);
            txtDelay.TabIndex = 7;
            txtDelay.Text = "1000";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(443, 570);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstLog);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(443, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(471, 570);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Log";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(443, 546);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(471, 24);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 19);
            lblStatus.Text = "Welcome";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel1);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(443, 476);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(471, 70);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tools";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnGo);
            flowLayoutPanel1.Controls.Add(btnStop);
            flowLayoutPanel1.Controls.Add(btnClear);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 23);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(465, 43);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(3, 4);
            btnGo.Margin = new Padding(3, 4, 3, 4);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(86, 29);
            btnGo.TabIndex = 0;
            btnGo.Text = "&Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(95, 4);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(86, 29);
            btnStop.TabIndex = 1;
            btnStop.Text = "&Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(187, 4);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(groupBox3);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Web Stress Testor";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLog;
        private Label label1;
        private TextBox txtURL;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private StatusStrip statusStrip1;
        private Label label2;
        private TextBox txtThreads;
        private Label label3;
        private TextBox txtDelay;
        private ToolStripStatusLabel lblStatus;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnGo;
        private Button btnStop;
        private Label label4;
        private TextBox txtCount;
        private Button btnClear;
    }
}
