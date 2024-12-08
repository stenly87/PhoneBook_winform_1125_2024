namespace PhoneBook
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textLastName = new TextBox();
            textFirstName = new TextBox();
            label2 = new Label();
            textPatronymic = new TextBox();
            label3 = new Label();
            listBox1 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textPhone = new TextBox();
            label6 = new Label();
            radioHouse = new RadioButton();
            radioMobile = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            textAddress = new TextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // textLastName
            // 
            textLastName.Location = new Point(105, 6);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(274, 23);
            textLastName.TabIndex = 1;
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(105, 35);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(274, 23);
            textFirstName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Имя";
            // 
            // textPatronymic
            // 
            textPatronymic.Location = new Point(105, 64);
            textPatronymic.Name = "textPatronymic";
            textPatronymic.Size = new Size(274, 23);
            textPatronymic.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Отчество";
            // 
            // listBox1
            // 
            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 123);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(189, 169);
            listBox1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(121, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(120, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textPhone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radioHouse);
            groupBox1.Controls.Add(radioMobile);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(211, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 172);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление телефона";
            // 
            // button1
            // 
            button1.Location = new Point(87, 141);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(10, 112);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(152, 23);
            textPhone.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 94);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 3;
            label6.Text = "Номер телефона";
            // 
            // radioHouse
            // 
            radioHouse.AutoSize = true;
            radioHouse.Location = new Point(6, 62);
            radioHouse.Name = "radioHouse";
            radioHouse.Size = new Size(89, 19);
            radioHouse.TabIndex = 2;
            radioHouse.TabStop = true;
            radioHouse.Text = "Домашний";
            radioHouse.UseVisualStyleBackColor = true;
            // 
            // radioMobile
            // 
            radioMobile.AutoSize = true;
            radioMobile.Location = new Point(6, 37);
            radioMobile.Name = "radioMobile";
            radioMobile.Size = new Size(97, 19);
            radioMobile.TabIndex = 1;
            radioMobile.TabStop = true;
            radioMobile.Text = "Мобильный";
            radioMobile.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Тип телефона";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 105);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "Телефоны:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 306);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 10;
            label7.Text = "Адрес";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(12, 324);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(367, 23);
            textAddress.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 372);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 12;
            label8.Text = "Изображение";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 390);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(47, 546);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Выбрать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(221, 603);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 15;
            button3.Text = "Сохранить и закрыть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 638);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(textAddress);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(textPatronymic);
            Controls.Add(label3);
            Controls.Add(textFirstName);
            Controls.Add(label2);
            Controls.Add(textLastName);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "Редактор";
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textLastName;
        private TextBox textFirstName;
        private Label label2;
        private TextBox textPatronymic;
        private Label label3;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textPhone;
        private Label label6;
        private RadioButton radioHouse;
        private RadioButton radioMobile;
        private Label label5;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private Label label7;
        private TextBox textAddress;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
    }
}