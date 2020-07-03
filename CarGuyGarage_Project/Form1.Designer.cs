namespace CarGuyGarage_Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonOpenCompany = new System.Windows.Forms.Button();
            this.buttonOpenCars = new System.Windows.Forms.Button();
            this.buttonOpenAvailability = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CarGuyGarage_Project.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(255, 85);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonOpenCompany
            // 
            this.buttonOpenCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonOpenCompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenCompany.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenCompany.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenCompany.Location = new System.Drawing.Point(12, 121);
            this.buttonOpenCompany.Name = "buttonOpenCompany";
            this.buttonOpenCompany.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenCompany.TabIndex = 1;
            this.buttonOpenCompany.Text = "Фирмы";
            this.buttonOpenCompany.UseVisualStyleBackColor = false;
            this.buttonOpenCompany.Click += new System.EventHandler(this.buttonOpenCompany_Click);
            // 
            // buttonOpenCars
            // 
            this.buttonOpenCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonOpenCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenCars.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenCars.Location = new System.Drawing.Point(12, 195);
            this.buttonOpenCars.Name = "buttonOpenCars";
            this.buttonOpenCars.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenCars.TabIndex = 2;
            this.buttonOpenCars.Text = "Автомобили";
            this.buttonOpenCars.UseVisualStyleBackColor = false;
            this.buttonOpenCars.Click += new System.EventHandler(this.buttonOpenCars_Click);
            // 
            // buttonOpenAvailability
            // 
            this.buttonOpenAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonOpenAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenAvailability.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonOpenAvailability.Location = new System.Drawing.Point(12, 264);
            this.buttonOpenAvailability.Name = "buttonOpenAvailability";
            this.buttonOpenAvailability.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenAvailability.TabIndex = 3;
            this.buttonOpenAvailability.Text = "Наличие";
            this.buttonOpenAvailability.UseVisualStyleBackColor = false;
            this.buttonOpenAvailability.Click += new System.EventHandler(this.buttonOpenAvailability_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(279, 331);
            this.Controls.Add(this.buttonOpenAvailability);
            this.Controls.Add(this.buttonOpenCars);
            this.Controls.Add(this.buttonOpenCompany);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonOpenCompany;
        private System.Windows.Forms.Button buttonOpenCars;
        private System.Windows.Forms.Button buttonOpenAvailability;
    }
}

