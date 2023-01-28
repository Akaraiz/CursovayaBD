
namespace CursovayaBD
{
    partial class Admin_panel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_panel));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.greenSearch = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.PictureBox();
            this.S_filtr = new System.Windows.Forms.Label();
            this.L_filtr = new System.Windows.Forms.Label();
            this.M_filtr = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.AddTea = new System.Windows.Forms.PictureBox();
            this.exportDB = new System.Windows.Forms.PictureBox();
            this.EditTea = new System.Windows.Forms.PictureBox();
            this.DeleteTea = new System.Windows.Forms.PictureBox();
            this.importDB = new System.Windows.Forms.PictureBox();
            this.rollbackDB = new System.Windows.Forms.PictureBox();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.greenSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollbackDB)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(419, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Название";
            this.textBox1.Size = new System.Drawing.Size(246, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(419, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Объем";
            this.textBox2.Size = new System.Drawing.Size(246, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.PaleGreen;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(419, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Цена";
            this.textBox3.Size = new System.Drawing.Size(246, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.PaleGreen;
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox4.Location = new System.Drawing.Point(419, 225);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Рецепт";
            this.textBox4.Size = new System.Drawing.Size(246, 105);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // greenSearch
            // 
            this.greenSearch.Image = global::CursovayaBD.Properties.Resources.greenSearch;
            this.greenSearch.Location = new System.Drawing.Point(419, 29);
            this.greenSearch.Name = "greenSearch";
            this.greenSearch.Size = new System.Drawing.Size(47, 36);
            this.greenSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenSearch.TabIndex = 12;
            this.greenSearch.TabStop = false;
            this.toolTip1.SetToolTip(this.greenSearch, "Поиск по объему");
            this.greenSearch.Click += new System.EventHandler(this.greenSearch_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(737, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 31);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // account
            // 
            this.account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.account.Image = global::CursovayaBD.Properties.Resources._6569365_and_application_applications_authentication_identity_icon;
            this.account.Location = new System.Drawing.Point(58, 12);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(52, 41);
            this.account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.account.TabIndex = 14;
            this.account.TabStop = false;
            this.toolTip3.SetToolTip(this.account, "Вернуться в аккаунт");
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // S_filtr
            // 
            this.S_filtr.AutoSize = true;
            this.S_filtr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S_filtr.Font = new System.Drawing.Font("Stencil", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_filtr.Location = new System.Drawing.Point(495, 32);
            this.S_filtr.Name = "S_filtr";
            this.S_filtr.Size = new System.Drawing.Size(38, 42);
            this.S_filtr.TabIndex = 15;
            this.S_filtr.Text = "S";
            this.S_filtr.Click += new System.EventHandler(this.S_filtr_Click);
            // 
            // L_filtr
            // 
            this.L_filtr.AutoSize = true;
            this.L_filtr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L_filtr.Font = new System.Drawing.Font("Stencil", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_filtr.Location = new System.Drawing.Point(575, 33);
            this.L_filtr.Name = "L_filtr";
            this.L_filtr.Size = new System.Drawing.Size(37, 42);
            this.L_filtr.TabIndex = 16;
            this.L_filtr.Text = "L";
            this.L_filtr.Click += new System.EventHandler(this.L_filtr_Click);
            // 
            // M_filtr
            // 
            this.M_filtr.AutoSize = true;
            this.M_filtr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.M_filtr.Font = new System.Drawing.Font("Stencil", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.M_filtr.Location = new System.Drawing.Point(532, 33);
            this.M_filtr.Name = "M_filtr";
            this.M_filtr.Size = new System.Drawing.Size(45, 42);
            this.M_filtr.TabIndex = 17;
            this.M_filtr.Text = "M";
            this.M_filtr.Click += new System.EventHandler(this.M_filtr_Click);
            // 
            // returnButton
            // 
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.Image = ((System.Drawing.Image)(resources.GetObject("returnButton.Image")));
            this.returnButton.Location = new System.Drawing.Point(622, 32);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(43, 33);
            this.returnButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnButton.TabIndex = 18;
            this.returnButton.TabStop = false;
            this.toolTip2.SetToolTip(this.returnButton, "Сбросить поиск");
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // AddTea
            // 
            this.AddTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTea.Image = ((System.Drawing.Image)(resources.GetObject("AddTea.Image")));
            this.AddTea.Location = new System.Drawing.Point(292, 351);
            this.AddTea.Name = "AddTea";
            this.AddTea.Size = new System.Drawing.Size(135, 144);
            this.AddTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddTea.TabIndex = 20;
            this.AddTea.TabStop = false;
            this.toolTip4.SetToolTip(this.AddTea, "Добавить напиток");
            this.AddTea.Click += new System.EventHandler(this.AddTea_Click);
            // 
            // exportDB
            // 
            this.exportDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportDB.Image = ((System.Drawing.Image)(resources.GetObject("exportDB.Image")));
            this.exportDB.Location = new System.Drawing.Point(301, 539);
            this.exportDB.Name = "exportDB";
            this.exportDB.Size = new System.Drawing.Size(90, 79);
            this.exportDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exportDB.TabIndex = 22;
            this.exportDB.TabStop = false;
            this.toolTip7.SetToolTip(this.exportDB, "Выгрузить базу данных");
            this.exportDB.Click += new System.EventHandler(this.exportDB_Click);
            // 
            // EditTea
            // 
            this.EditTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditTea.Image = ((System.Drawing.Image)(resources.GetObject("EditTea.Image")));
            this.EditTea.Location = new System.Drawing.Point(470, 351);
            this.EditTea.Name = "EditTea";
            this.EditTea.Size = new System.Drawing.Size(135, 144);
            this.EditTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditTea.TabIndex = 25;
            this.EditTea.TabStop = false;
            this.toolTip5.SetToolTip(this.EditTea, "Изменить напиток");
            this.EditTea.Click += new System.EventHandler(this.EditTea_Click);
            // 
            // DeleteTea
            // 
            this.DeleteTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteTea.Image = ((System.Drawing.Image)(resources.GetObject("DeleteTea.Image")));
            this.DeleteTea.Location = new System.Drawing.Point(653, 351);
            this.DeleteTea.Name = "DeleteTea";
            this.DeleteTea.Size = new System.Drawing.Size(135, 144);
            this.DeleteTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteTea.TabIndex = 26;
            this.DeleteTea.TabStop = false;
            this.toolTip6.SetToolTip(this.DeleteTea, "Удалить напиток");
            this.DeleteTea.Click += new System.EventHandler(this.DeleteTea_Click);
            // 
            // importDB
            // 
            this.importDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importDB.Image = ((System.Drawing.Image)(resources.GetObject("importDB.Image")));
            this.importDB.Location = new System.Drawing.Point(479, 539);
            this.importDB.Name = "importDB";
            this.importDB.Size = new System.Drawing.Size(90, 79);
            this.importDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.importDB.TabIndex = 27;
            this.importDB.TabStop = false;
            this.toolTip8.SetToolTip(this.importDB, "Загрузить базу данных");
            this.importDB.Click += new System.EventHandler(this.importDB_Click);
            // 
            // rollbackDB
            // 
            this.rollbackDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollbackDB.Image = ((System.Drawing.Image)(resources.GetObject("rollbackDB.Image")));
            this.rollbackDB.Location = new System.Drawing.Point(653, 539);
            this.rollbackDB.Name = "rollbackDB";
            this.rollbackDB.Size = new System.Drawing.Size(90, 79);
            this.rollbackDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollbackDB.TabIndex = 28;
            this.rollbackDB.TabStop = false;
            this.toolTip9.SetToolTip(this.rollbackDB, "Откатить");
            this.rollbackDB.Click += new System.EventHandler(this.rollbackDB_Click);
            // 
            // Admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.rollbackDB);
            this.Controls.Add(this.importDB);
            this.Controls.Add(this.DeleteTea);
            this.Controls.Add(this.EditTea);
            this.Controls.Add(this.exportDB);
            this.Controls.Add(this.AddTea);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.M_filtr);
            this.Controls.Add(this.L_filtr);
            this.Controls.Add(this.S_filtr);
            this.Controls.Add(this.account);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.greenSearch);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Admin_panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Admin_panel_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.greenSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollbackDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox greenSearch;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.PictureBox account;
        private System.Windows.Forms.Label S_filtr;
        private System.Windows.Forms.Label L_filtr;
        private System.Windows.Forms.Label M_filtr;
        private System.Windows.Forms.PictureBox returnButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.PictureBox AddTea;
        private System.Windows.Forms.PictureBox exportDB;
        private System.Windows.Forms.PictureBox EditTea;
        private System.Windows.Forms.PictureBox DeleteTea;
        private System.Windows.Forms.PictureBox importDB;
        private System.Windows.Forms.PictureBox rollbackDB;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip9;
    }
}