namespace CarGuyGarage_Project
{
    partial class FormCompany
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddres = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddres = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listViewCompany = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.НазваниеФирмы = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Адрес = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Город = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Телефон = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.labelName.Location = new System.Drawing.Point(12, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(148, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название фирмы";
            // 
            // labelAddres
            // 
            this.labelAddres.AutoSize = true;
            this.labelAddres.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.labelAddres.Location = new System.Drawing.Point(12, 80);
            this.labelAddres.Name = "labelAddres";
            this.labelAddres.Size = new System.Drawing.Size(59, 23);
            this.labelAddres.TabIndex = 0;
            this.labelAddres.Text = "Адрес";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(12, 206);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(144, 23);
            this.labelPhoneNumber.TabIndex = 0;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.labelCity.Location = new System.Drawing.Point(12, 142);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 23);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "Город";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxName.Location = new System.Drawing.Point(16, 48);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 24);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAddres
            // 
            this.textBoxAddres.BackColor = System.Drawing.Color.White;
            this.textBoxAddres.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxAddres.Location = new System.Drawing.Point(16, 106);
            this.textBoxAddres.Multiline = true;
            this.textBoxAddres.Name = "textBoxAddres";
            this.textBoxAddres.Size = new System.Drawing.Size(144, 24);
            this.textBoxAddres.TabIndex = 1;
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.Color.White;
            this.textBoxCity.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxCity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCity.Location = new System.Drawing.Point(16, 168);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(144, 24);
            this.textBoxCity.TabIndex = 1;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(16, 232);
            this.textBoxPhoneNumber.Multiline = true;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(144, 24);
            this.textBoxPhoneNumber.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CarGuyGarage_Project.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 363);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(163, 75);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listViewCompany
            // 
            this.listViewCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCompany.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.НазваниеФирмы,
            this.Адрес,
            this.Город,
            this.Телефон});
            this.listViewCompany.Font = new System.Drawing.Font("Calibri", 11F);
            this.listViewCompany.FullRowSelect = true;
            this.listViewCompany.GridLines = true;
            this.listViewCompany.HideSelection = false;
            this.listViewCompany.Location = new System.Drawing.Point(193, 22);
            this.listViewCompany.Name = "listViewCompany";
            this.listViewCompany.Size = new System.Drawing.Size(595, 372);
            this.listViewCompany.TabIndex = 3;
            this.listViewCompany.UseCompatibleStateImageBehavior = false;
            this.listViewCompany.View = System.Windows.Forms.View.Details;
            this.listViewCompany.SelectedIndexChanged += new System.EventHandler(this.listViewCompany_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // НазваниеФирмы
            // 
            this.НазваниеФирмы.Text = "Название фирмы";
            // 
            // Адрес
            // 
            this.Адрес.Text = "Адрес";
            // 
            // Город
            // 
            this.Город.Text = "Город";
            // 
            // Телефон
            // 
            this.Телефон.Text = "Телефон";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(481, 408);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 36);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonEdit.Location = new System.Drawing.Point(589, 408);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(90, 36);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonDel.Location = new System.Drawing.Point(698, 408);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(90, 36);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewCompany);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddres);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelAddres);
            this.Controls.Add(this.labelName);
            this.Name = "FormCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фирмы";
            this.Load += new System.EventHandler(this.FormCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddres;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddres;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewCompany;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader НазваниеФирмы;
        private System.Windows.Forms.ColumnHeader Адрес;
        private System.Windows.Forms.ColumnHeader Город;
        private System.Windows.Forms.ColumnHeader Телефон;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
    }
}