namespace CursovayaBD
{
    partial class RegisterForm
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
            this.closeButton = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatronim = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.AuthoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(415, -3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 31);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonRegister.Location = new System.Drawing.Point(70, 635);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(296, 61);
            this.buttonRegister.TabIndex = 18;
            this.buttonRegister.Text = "Войти";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhone.Location = new System.Drawing.Point(72, 235);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PlaceholderText = "Введите номер телефона";
            this.textBoxPhone.Size = new System.Drawing.Size(294, 49);
            this.textBoxPhone.TabIndex = 16;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 121);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(80, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация\r\nклиента";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(72, 336);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Введите имя";
            this.textBoxName.Size = new System.Drawing.Size(294, 49);
            this.textBoxName.TabIndex = 22;
            // 
            // textBoxPatronim
            // 
            this.textBoxPatronim.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxPatronim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPatronim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPatronim.Location = new System.Drawing.Point(71, 535);
            this.textBoxPatronim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPatronim.Multiline = true;
            this.textBoxPatronim.Name = "textBoxPatronim";
            this.textBoxPatronim.PlaceholderText = "Введите отчество*";
            this.textBoxPatronim.Size = new System.Drawing.Size(294, 49);
            this.textBoxPatronim.TabIndex = 23;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSecondName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSecondName.Location = new System.Drawing.Point(71, 435);
            this.textBoxSecondName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSecondName.Multiline = true;
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.PlaceholderText = "Введите фамилию*";
            this.textBoxSecondName.Size = new System.Drawing.Size(294, 49);
            this.textBoxSecondName.TabIndex = 24;
            // 
            // AuthoLabel
            // 
            this.AuthoLabel.AutoSize = true;
            this.AuthoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthoLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthoLabel.Location = new System.Drawing.Point(137, 713);
            this.AuthoLabel.Name = "AuthoLabel";
            this.AuthoLabel.Size = new System.Drawing.Size(170, 21);
            this.AuthoLabel.TabIndex = 25;
            this.AuthoLabel.Text = "Авторизация клиента";
            this.AuthoLabel.Click += new System.EventHandler(this.AuthoLabel_Click);
            this.AuthoLabel.MouseEnter += new System.EventHandler(this.AuthoLabel_MouseEnter);
            this.AuthoLabel.MouseLeave += new System.EventHandler(this.AuthoLabel_MouseLeave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 759);
            this.Controls.Add(this.AuthoLabel);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxPatronim);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterForm";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatronim;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label AuthoLabel;
    }
}