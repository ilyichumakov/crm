namespace crm
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
            this.preloader_picture = new System.Windows.Forms.PictureBox();
            this.loading_label = new System.Windows.Forms.Label();
            this.app_name_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.preloader_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // preloader_picture
            // 
            this.preloader_picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preloader_picture.Image = global::crm.Properties.Resources.preloader;
            this.preloader_picture.Location = new System.Drawing.Point(270, 147);
            this.preloader_picture.Name = "preloader_picture";
            this.preloader_picture.Size = new System.Drawing.Size(260, 185);
            this.preloader_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.preloader_picture.TabIndex = 0;
            this.preloader_picture.TabStop = false;
            // 
            // loading_label
            // 
            this.loading_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loading_label.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.loading_label.Location = new System.Drawing.Point(314, 281);
            this.loading_label.Name = "loading_label";
            this.loading_label.Size = new System.Drawing.Size(181, 25);
            this.loading_label.TabIndex = 1;
            this.loading_label.Text = "Loading";
            this.loading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // app_name_label
            // 
            this.app_name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.app_name_label.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(168)))), ((int)(((byte)(237)))));
            this.app_name_label.Location = new System.Drawing.Point(314, 147);
            this.app_name_label.Name = "app_name_label";
            this.app_name_label.Size = new System.Drawing.Size(181, 70);
            this.app_name_label.TabIndex = 1;
            this.app_name_label.Text = "Light CRM";
            this.app_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.app_name_label);
            this.Controls.Add(this.loading_label);
            this.Controls.Add(this.preloader_picture);
            this.MinimumSize = new System.Drawing.Size(360, 280);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light CRM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preloader_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox preloader_picture;
        private System.Windows.Forms.Label loading_label;
        private System.Windows.Forms.Label app_name_label;
    }
}

