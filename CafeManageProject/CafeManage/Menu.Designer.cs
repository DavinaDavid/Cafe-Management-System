namespace vplproject1
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coffeepicbox = new System.Windows.Forms.PictureBox();
            this.teapicbox = new System.Windows.Forms.PictureBox();
            this.cakepicbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coffeepicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teapicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakepicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(327, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Menu Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(113, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cake";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(430, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(744, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Coffee";
            // 
            // coffeepicbox
            // 
            this.coffeepicbox.BackColor = System.Drawing.Color.Transparent;
            this.coffeepicbox.Image = global::vplproject1.Properties.Resources.coffee1;
            this.coffeepicbox.Location = new System.Drawing.Point(691, 166);
            this.coffeepicbox.Name = "coffeepicbox";
            this.coffeepicbox.Size = new System.Drawing.Size(207, 165);
            this.coffeepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coffeepicbox.TabIndex = 3;
            this.coffeepicbox.TabStop = false;
            this.coffeepicbox.Click += new System.EventHandler(this.coffeepicbox_Click);
            // 
            // teapicbox
            // 
            this.teapicbox.BackColor = System.Drawing.Color.Transparent;
            this.teapicbox.Image = global::vplproject1.Properties.Resources.tea3;
            this.teapicbox.Location = new System.Drawing.Point(348, 166);
            this.teapicbox.Name = "teapicbox";
            this.teapicbox.Size = new System.Drawing.Size(208, 165);
            this.teapicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teapicbox.TabIndex = 2;
            this.teapicbox.TabStop = false;
            this.teapicbox.Click += new System.EventHandler(this.teapicbox_Click);
            // 
            // cakepicbox
            // 
            this.cakepicbox.BackColor = System.Drawing.Color.Transparent;
            this.cakepicbox.Image = global::vplproject1.Properties.Resources.cake3;
            this.cakepicbox.Location = new System.Drawing.Point(45, 155);
            this.cakepicbox.Name = "cakepicbox";
            this.cakepicbox.Size = new System.Drawing.Size(220, 165);
            this.cakepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cakepicbox.TabIndex = 1;
            this.cakepicbox.TabStop = false;
            this.cakepicbox.Click += new System.EventHandler(this.cake_menus);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vplproject1.Properties.Resources.maincafe1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coffeepicbox);
            this.Controls.Add(this.teapicbox);
            this.Controls.Add(this.cakepicbox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffeepicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teapicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakepicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cakepicbox;
        private System.Windows.Forms.PictureBox teapicbox;
        private System.Windows.Forms.PictureBox coffeepicbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}