namespace School
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCityName = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(33, 180);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(54, 13);
            this.labelCityName.TabIndex = 1;
            this.labelCityName.Text = "cityName ";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(33, 205);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(66, 13);
            this.labelTemperature.TabIndex = 2;
            this.labelTemperature.Text = "temperature ";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(33, 229);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(53, 13);
            this.labelCondition.TabIndex = 3;
            this.labelCondition.Text = "condition ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Weater";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

