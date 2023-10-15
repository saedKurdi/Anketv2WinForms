namespace AnketV2
{
    partial class Form1 : Form
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
            groupBox1 = new GroupBox();
            add_button = new Button();
            change_button = new Button();
            dateTimePicker1 = new DateTimePicker();
            phone_label = new Label();
            label3 = new Label();
            surname_label = new Label();
            mail_label = new Label();
            name_label = new Label();
            phone_txtbox = new TextBox();
            mail_txtbox = new TextBox();
            surname_txtbox = new TextBox();
            name_txtbox = new TextBox();
            workers_listbox = new ListBox();
            filename_txtbox = new TextBox();
            load_button = new Button();
            save_button = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(add_button);
            groupBox1.Controls.Add(change_button);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(phone_label);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(surname_label);
            groupBox1.Controls.Add(mail_label);
            groupBox1.Controls.Add(name_label);
            groupBox1.Controls.Add(phone_txtbox);
            groupBox1.Controls.Add(mail_txtbox);
            groupBox1.Controls.Add(surname_txtbox);
            groupBox1.Controls.Add(name_txtbox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 292);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // add_button
            // 
            add_button.Location = new Point(300, 249);
            add_button.Name = "add_button";
            add_button.Size = new Size(94, 29);
            add_button.TabIndex = 12;
            add_button.Text = "ADD";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // change_button
            // 
            change_button.Location = new Point(300, 214);
            change_button.Name = "change_button";
            change_button.Size = new Size(94, 29);
            change_button.TabIndex = 11;
            change_button.Text = "CHANGE";
            change_button.UseVisualStyleBackColor = true;
            change_button.Click += change_button_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(113, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            phone_label.Location = new Point(53, 125);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(54, 20);
            phone_label.TabIndex = 9;
            phone_label.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 158);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 8;
            label3.Text = "Date";
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            surname_label.Location = new Point(35, 59);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(72, 20);
            surname_label.TabIndex = 7;
            surname_label.Text = "Surname";
            // 
            // mail_label
            // 
            mail_label.AutoSize = true;
            mail_label.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mail_label.Location = new Point(62, 92);
            mail_label.Name = "mail_label";
            mail_label.Size = new Size(45, 20);
            mail_label.TabIndex = 6;
            mail_label.Text = "Mail";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            name_label.Location = new Point(62, 29);
            name_label.Name = "name_label";
            name_label.Size = new Size(45, 20);
            name_label.TabIndex = 5;
            name_label.Text = "Name";
            // 
            // phone_txtbox
            // 
            phone_txtbox.Location = new Point(113, 125);
            phone_txtbox.Name = "phone_txtbox";
            phone_txtbox.Size = new Size(281, 27);
            phone_txtbox.TabIndex = 3;
            // 
            // mail_txtbox
            // 
            mail_txtbox.Location = new Point(113, 92);
            mail_txtbox.Name = "mail_txtbox";
            mail_txtbox.Size = new Size(281, 27);
            mail_txtbox.TabIndex = 2;
            // 
            // surname_txtbox
            // 
            surname_txtbox.Location = new Point(113, 59);
            surname_txtbox.Name = "surname_txtbox";
            surname_txtbox.Size = new Size(281, 27);
            surname_txtbox.TabIndex = 1;
            // 
            // name_txtbox
            // 
            name_txtbox.Location = new Point(113, 26);
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(281, 27);
            name_txtbox.TabIndex = 0;
            // 
            // workers_listbox
            // 
            workers_listbox.FormattingEnabled = true;
            workers_listbox.ItemHeight = 20;
            workers_listbox.Location = new Point(427, 12);
            workers_listbox.Name = "workers_listbox";
            workers_listbox.Size = new Size(290, 224);
            workers_listbox.TabIndex = 1;
            // 
            // filename_txtbox
            // 
            filename_txtbox.Location = new Point(427, 242);
            filename_txtbox.Name = "filename_txtbox";
            filename_txtbox.Size = new Size(290, 27);
            filename_txtbox.TabIndex = 2;
            filename_txtbox.Text = "File Name";
            filename_txtbox.Click += filename_txtbox_Click;
            // 
            // load_button
            // 
            load_button.Location = new Point(427, 275);
            load_button.Name = "load_button";
            load_button.Size = new Size(135, 29);
            load_button.TabIndex = 3;
            load_button.Text = "LOAD";
            load_button.UseVisualStyleBackColor = true;
            load_button.Click += load_button_Click;
            // 
            // save_button
            // 
            save_button.Location = new Point(582, 275);
            save_button.Name = "save_button";
            save_button.Size = new Size(135, 29);
            save_button.TabIndex = 4;
            save_button.Text = "SAVE";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 322);
            Controls.Add(save_button);
            Controls.Add(load_button);
            Controls.Add(filename_txtbox);
            Controls.Add(workers_listbox);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anket";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox name_txtbox;
        private TextBox phone_txtbox;
        private TextBox mail_txtbox;
        private TextBox surname_txtbox;
        private Label name_label;
        private DateTimePicker dateTimePicker1;
        private Label phone_label;
        private Label label3;
        private Label surname_label;
        private Label mail_label;
        private ListBox workers_listbox;
        private TextBox filename_txtbox;
        private Button load_button;
        private Button save_button;
        private Button add_button;
        private Button change_button;
    }
}