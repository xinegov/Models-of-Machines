namespace Cars
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.car = new System.Windows.Forms.PictureBox();
            this.maim = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dop = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            this.SuspendLayout();
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Transparent;
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(-34, -7);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(829, 580);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 0;
            this.car.TabStop = false;
            // 
            // maim
            // 
            this.maim.AutoSize = true;
            this.maim.BackColor = System.Drawing.Color.Transparent;
            this.maim.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maim.Location = new System.Drawing.Point(116, 27);
            this.maim.Name = "maim";
            this.maim.Size = new System.Drawing.Size(569, 55);
            this.maim.TabIndex = 1;
            this.maim.Text = "ДОБРО ПОЖАЛОВАТЬ";
            this.maim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(82)))), ((int)(((byte)(51)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(214, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 61);
            this.button1.TabIndex = 13;
            this.button1.Text = "E-series";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.eseries_Click);
            // 
            // dop
            // 
            this.dop.BackColor = System.Drawing.Color.Transparent;
            this.dop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dop.ForeColor = System.Drawing.Color.DimGray;
            this.dop.Location = new System.Drawing.Point(162, 89);
            this.dop.Name = "dop";
            this.dop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dop.Size = new System.Drawing.Size(464, 109);
            this.dop.TabIndex = 18;
            this.dop.Text = "В нашем автосалоне вы можете подобрать различные машины по своему желанию. У нас " +
    "в наличии имеются такие серии машин, как E-series. Также есть возможность посмот" +
    "реть их технические характеристики.";
            this.dop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.info.Location = new System.Drawing.Point(403, 166);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(154, 61);
            this.info.TabIndex = 20;
            this.info.Text = "Информация";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dop);
            this.Controls.Add(this.maim);
            this.Controls.Add(this.car);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstForm";
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Label maim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dop;
        private System.Windows.Forms.Button info;
    }
}