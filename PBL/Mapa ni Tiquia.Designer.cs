namespace PBL
{
    partial class Mapa_ni_Tiquia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mapa_ni_Tiquia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mapImage = new System.Windows.Forms.PictureBox();
            this.islandLabel = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.islandComboBox = new System.Windows.Forms.ComboBox();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.provinceComboBox = new System.Windows.Forms.ComboBox();
            this.caseInputTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.mapImage);
            this.panel1.Location = new System.Drawing.Point(1070, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 569);
            this.panel1.TabIndex = 0;
            // 
            // mapImage
            // 
            this.mapImage.Image = ((System.Drawing.Image)(resources.GetObject("mapImage.Image")));
            this.mapImage.Location = new System.Drawing.Point(218, 27);
            this.mapImage.Name = "mapImage";
            this.mapImage.Size = new System.Drawing.Size(515, 505);
            this.mapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapImage.TabIndex = 0;
            this.mapImage.TabStop = false;
            // 
            // islandLabel
            // 
            this.islandLabel.AutoSize = true;
            this.islandLabel.BackColor = System.Drawing.Color.Khaki;
            this.islandLabel.Location = new System.Drawing.Point(106, 48);
            this.islandLabel.Name = "islandLabel";
            this.islandLabel.Size = new System.Drawing.Size(52, 20);
            this.islandLabel.TabIndex = 1;
            this.islandLabel.Text = "Island";
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.BackColor = System.Drawing.Color.Khaki;
            this.regionLabel.Location = new System.Drawing.Point(106, 145);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(60, 20);
            this.regionLabel.TabIndex = 2;
            this.regionLabel.Text = "Region";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.BackColor = System.Drawing.Color.Khaki;
            this.provinceLabel.Location = new System.Drawing.Point(106, 246);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(69, 20);
            this.provinceLabel.TabIndex = 1;
            this.provinceLabel.Text = "Province";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(106, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cases";
            // 
            // islandComboBox
            // 
            this.islandComboBox.FormattingEnabled = true;
            this.islandComboBox.Location = new System.Drawing.Point(110, 89);
            this.islandComboBox.Name = "islandComboBox";
            this.islandComboBox.Size = new System.Drawing.Size(445, 28);
            this.islandComboBox.TabIndex = 3;
            this.islandComboBox.DropDown += new System.EventHandler(this.islandComboBox_DropDown);
            this.islandComboBox.SelectedIndexChanged += new System.EventHandler(this.islandComboBox_SelectedIndexChanged);
            // 
            // regionComboBox
            // 
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(110, 180);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(445, 28);
            this.regionComboBox.TabIndex = 4;
            this.regionComboBox.DropDown += new System.EventHandler(this.regionComboBox_DropDown);
            this.regionComboBox.SelectedIndexChanged += new System.EventHandler(this.regionComboBox_SelectedIndexChanged);
            // 
            // provinceComboBox
            // 
            this.provinceComboBox.FormattingEnabled = true;
            this.provinceComboBox.Location = new System.Drawing.Point(110, 278);
            this.provinceComboBox.Name = "provinceComboBox";
            this.provinceComboBox.Size = new System.Drawing.Size(445, 28);
            this.provinceComboBox.TabIndex = 5;
            this.provinceComboBox.SelectedIndexChanged += new System.EventHandler(this.provinceComboBox_SelectedIndexChanged);
            // 
            // caseInputTextBox
            // 
            this.caseInputTextBox.Location = new System.Drawing.Point(110, 374);
            this.caseInputTextBox.Name = "caseInputTextBox";
            this.caseInputTextBox.Size = new System.Drawing.Size(100, 26);
            this.caseInputTextBox.TabIndex = 6;
            this.caseInputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.caseInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.caseInputTextBox_KeyDown);
            // 
            // Mapa_ni_Tiquia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.caseInputTextBox);
            this.Controls.Add(this.provinceComboBox);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.islandComboBox);
            this.Controls.Add(this.islandLabel);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.provinceLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Mapa_ni_Tiquia";
            this.Text = "Mapa_ni_Tiquia";
            this.Load += new System.EventHandler(this.Mapa_ni_Tiquia_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox mapImage;
        private System.Windows.Forms.Label islandLabel;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox islandComboBox;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.ComboBox provinceComboBox;
        private System.Windows.Forms.TextBox caseInputTextBox;
    }
}