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
            listBox1 = new ListBox();
            label1 = new Label();
            txtURL = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
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
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(406, 428);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "URL:";
            // 
            // txtURL
            // 
            txtURL.Dock = DockStyle.Fill;
            txtURL.Location = new Point(136, 3);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(243, 23);
            txtURL.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.05155F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.9484558F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtURL, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtThreads, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDelay, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(382, 100);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Threads:";
            // 
            // txtThreads
            // 
            txtThreads.Dock = DockStyle.Fill;
            txtThreads.Location = new Point(136, 32);
            txtThreads.Name = "txtThreads";
            txtThreads.Size = new Size(243, 23);
            txtThreads.TabIndex = 5;
            txtThreads.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Delay:";
            // 
            // txtDelay
            // 
            txtDelay.Dock = DockStyle.Fill;
            txtDelay.Location = new Point(136, 61);
            txtDelay.Name = "txtDelay";
            txtDelay.Size = new Size(243, 23);
            txtDelay.TabIndex = 7;
            txtDelay.Text = "1000";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 450);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(388, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 450);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Log";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(388, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(412, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 17);
            lblStatus.Text = "Welcome";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel1);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(388, 373);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(412, 55);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tools";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnGo);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(406, 33);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(3, 3);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 0;
            btnGo.Text = "&Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(84, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "&Stop";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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

        private ListBox listBox1;
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
        private Button button1;
    }
}
