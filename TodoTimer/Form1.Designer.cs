namespace TodoTimer
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
            components = new System.ComponentModel.Container();
            btn_timer = new Button();
            btn_refresh = new Button();
            list_Tag = new ListBox();
            cms_tag = new ContextMenuStrip(components);
            itemAddToolStripMenuItem = new ToolStripMenuItem();
            itemDeleteToolStripMenuItem = new ToolStripMenuItem();
            listView_Todo = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txt_totalWorkTime = new Label();
            txt_nowTimer = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            timer = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            cms_tag.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_timer
            // 
            btn_timer.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn_timer.Location = new Point(342, 322);
            btn_timer.Name = "btn_timer";
            btn_timer.Size = new Size(81, 73);
            btn_timer.TabIndex = 0;
            btn_timer.Text = "Start";
            btn_timer.UseVisualStyleBackColor = true;
            btn_timer.Click += btn_timer_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn_refresh.Location = new Point(429, 322);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(81, 73);
            btn_refresh.TabIndex = 1;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // list_Tag
            // 
            list_Tag.ContextMenuStrip = cms_tag;
            list_Tag.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            list_Tag.FormattingEnabled = true;
            list_Tag.ItemHeight = 20;
            list_Tag.Location = new Point(5, 43);
            list_Tag.Name = "list_Tag";
            list_Tag.Size = new Size(132, 244);
            list_Tag.TabIndex = 2;
            // 
            // cms_tag
            // 
            cms_tag.Items.AddRange(new ToolStripItem[] { itemAddToolStripMenuItem, itemDeleteToolStripMenuItem });
            cms_tag.Name = "cms_tag";
            cms_tag.Size = new Size(135, 48);
            // 
            // itemAddToolStripMenuItem
            // 
            itemAddToolStripMenuItem.Name = "itemAddToolStripMenuItem";
            itemAddToolStripMenuItem.Size = new Size(134, 22);
            itemAddToolStripMenuItem.Text = "add Item";
            itemAddToolStripMenuItem.Click += itemAddToolStripMenuItem_Click;
            // 
            // itemDeleteToolStripMenuItem
            // 
            itemDeleteToolStripMenuItem.Name = "itemDeleteToolStripMenuItem";
            itemDeleteToolStripMenuItem.Size = new Size(134, 22);
            itemDeleteToolStripMenuItem.Text = "delete Item";
            itemDeleteToolStripMenuItem.Click += itemDeleteToolStripMenuItem_Click;
            // 
            // listView_Todo
            // 
            listView_Todo.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView_Todo.Location = new Point(143, 43);
            listView_Todo.Name = "listView_Todo";
            listView_Todo.Size = new Size(694, 244);
            listView_Todo.TabIndex = 3;
            listView_Todo.UseCompatibleStateImageBehavior = false;
            listView_Todo.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tag";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Start Time";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "End Time";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Work Time";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(851, 429);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(txt_totalWorkTime);
            tabPage1.Controls.Add(txt_nowTimer);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btn_refresh);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btn_timer);
            tabPage1.Controls.Add(listView_Todo);
            tabPage1.Controls.Add(list_Tag);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(843, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Timer";
            // 
            // txt_totalWorkTime
            // 
            txt_totalWorkTime.AutoSize = true;
            txt_totalWorkTime.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txt_totalWorkTime.Location = new Point(4, 373);
            txt_totalWorkTime.Name = "txt_totalWorkTime";
            txt_totalWorkTime.Size = new Size(233, 25);
            txt_totalWorkTime.TabIndex = 6;
            txt_totalWorkTime.Text = "Total Worktime : 00:00:00";
            // 
            // txt_nowTimer
            // 
            txt_nowTimer.AutoSize = true;
            txt_nowTimer.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txt_nowTimer.Location = new Point(388, 293);
            txt_nowTimer.Name = "txt_nowTimer";
            txt_nowTimer.Size = new Size(80, 25);
            txt_nowTimer.TabIndex = 5;
            txt_nowTimer.Text = "00:00:00";
            txt_nowTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(143, 15);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 4;
            label2.Text = "Log";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 3;
            label1.Text = "Tag";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(listView1);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(843, 401);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Statistics";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8 });
            listView1.Location = new Point(6, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(254, 389);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "";
            columnHeader6.Width = 25;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tag";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Time";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(861, 433);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Todo Timer";
            Load += Form1_Load;
            cms_tag.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_timer;
        private Button btn_refresh;
        private ListBox list_Tag;
        private ListView listView_Todo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private Label txt_nowTimer;
        private ContextMenuStrip cms_tag;
        private ToolStripMenuItem itemAddToolStripMenuItem;
        private ToolStripMenuItem itemDeleteToolStripMenuItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label txt_totalWorkTime;
        private System.Windows.Forms.Timer timer;
        private ListView listView1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}
