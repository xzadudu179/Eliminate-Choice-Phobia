namespace Eliminate_Choice_Phobia
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
            panel1 = new Panel();
            clearButton = new Button();
            deleteButton = new Button();
            ToDoList = new ListBox();
            addButton = new Button();
            generate = new Button();
            addToListText = new TextBox();
            outPutLabel = new Label();
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem1 = new ToolStripMenuItem();
            LoadToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(ToDoList);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(generate);
            panel1.Controls.Add(addToListText);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 262);
            panel1.TabIndex = 4;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.MediumSlateBlue;
            clearButton.Enabled = false;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("等线", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = SystemColors.ButtonHighlight;
            clearButton.Location = new Point(175, 71);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 28);
            clearButton.TabIndex = 13;
            clearButton.Text = "清空";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.MediumSlateBlue;
            deleteButton.Enabled = false;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("等线", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(175, 37);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 28);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "移除";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // ToDoList
            // 
            ToDoList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ToDoList.BackColor = Color.WhiteSmoke;
            ToDoList.BorderStyle = BorderStyle.FixedSingle;
            ToDoList.Font = new Font("等线", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToDoList.FormattingEnabled = true;
            ToDoList.HorizontalScrollbar = true;
            ToDoList.ItemHeight = 17;
            ToDoList.Location = new Point(3, 34);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(166, 223);
            ToDoList.TabIndex = 11;
            ToDoList.SelectedIndexChanged += ToDoList_SelectedIndexChanged_1;
            ToDoList.KeyDown += ToListText_KeyDown;
            // 
            // addButton
            // 
            addButton.BackColor = Color.MediumSlateBlue;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("等线", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(175, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 28);
            addButton.TabIndex = 10;
            addButton.Text = "添加";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // generate
            // 
            generate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            generate.BackColor = Color.MediumSlateBlue;
            generate.Enabled = false;
            generate.FlatStyle = FlatStyle.Flat;
            generate.Font = new Font("等线", 12F, FontStyle.Bold, GraphicsUnit.Point);
            generate.ForeColor = SystemColors.ButtonHighlight;
            generate.Location = new Point(175, 206);
            generate.Name = "generate";
            generate.Size = new Size(100, 51);
            generate.TabIndex = 8;
            generate.Text = "生成";
            generate.UseVisualStyleBackColor = false;
            generate.Click += generate_Click;
            // 
            // addToListText
            // 
            addToListText.BackColor = Color.White;
            addToListText.Font = new Font("等线", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addToListText.ForeColor = Color.SlateBlue;
            addToListText.Location = new Point(3, 4);
            addToListText.MaxLength = 30;
            addToListText.Name = "addToListText";
            addToListText.Size = new Size(166, 24);
            addToListText.TabIndex = 9;
            addToListText.KeyDown += addToListText_KeyDown;
            // 
            // outPutLabel
            // 
            outPutLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outPutLabel.Font = new Font("等线", 15F, FontStyle.Bold, GraphicsUnit.Point);
            outPutLabel.Location = new Point(299, 107);
            outPutLabel.Name = "outPutLabel";
            outPutLabel.Size = new Size(214, 89);
            outPutLabel.TabIndex = 6;
            outPutLabel.Text = "-";
            outPutLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MediumSlateBlue;
            menuStrip1.Font = new Font("等线", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(525, 25);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveToolStripMenuItem1, LoadToolStripMenuItem });
            FileToolStripMenuItem.Font = new Font("等线", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FileToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(52, 21);
            FileToolStripMenuItem.Text = "文件";
            // 
            // SaveToolStripMenuItem1
            // 
            SaveToolStripMenuItem1.Font = new Font("等线", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1";
            SaveToolStripMenuItem1.Size = new Size(108, 22);
            SaveToolStripMenuItem1.Text = "保存";
            SaveToolStripMenuItem1.Click += SaveToolStripMenuItem1_Click;
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.Font = new Font("等线", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.Size = new Size(108, 22);
            LoadToolStripMenuItem.Text = "加载";
            LoadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("等线", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(299, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 63);
            textBox1.TabIndex = 8;
            textBox1.Text = "你现在要做的事情是:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(525, 301);
            Controls.Add(textBox1);
            Controls.Add(outPutLabel);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "选择困难症消除器";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label outPutLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem1;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private Button generate;
        private Button addButton;
        private TextBox addToListText;
        private ListBox ToDoList;
        private Button deleteButton;
        private Button clearButton;
        private TextBox textBox1;
    }
}