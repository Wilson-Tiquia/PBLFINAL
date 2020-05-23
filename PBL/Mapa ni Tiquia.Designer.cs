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
            this.islandLabel = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.cases = new System.Windows.Forms.Label();
            this.islandComboBox = new System.Windows.Forms.ComboBox();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.provinceComboBox = new System.Windows.Forms.ComboBox();
            this.caseInputTextBox = new System.Windows.Forms.TextBox();
            this.regionMap = new System.Windows.Forms.Label();
            this.provinceMap = new System.Windows.Forms.Label();
            this.regionMapComboBox = new System.Windows.Forms.ComboBox();
            this.provinceMapComboBox = new System.Windows.Forms.ComboBox();
            this.panelOfImage = new System.Windows.Forms.Panel();
            this.tCase = new System.Windows.Forms.Label();
            this.provinceName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.range501To1k = new System.Windows.Forms.Label();
            this.range0To500 = new System.Windows.Forms.Label();
            this.case1 = new System.Windows.Forms.PictureBox();
            this.case2 = new System.Windows.Forms.PictureBox();
            this.case3 = new System.Windows.Forms.PictureBox();
            this.case4 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.provincePicture = new System.Windows.Forms.PictureBox();
            this.currentIsland = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mindanao = new System.Windows.Forms.Button();
            this.visayas = new System.Windows.Forms.Button();
            this.luzonButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCases = new System.Windows.Forms.Label();
            this.panelOfImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.case1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.case2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.case3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.case4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // cases
            // 
            this.cases.AutoSize = true;
            this.cases.BackColor = System.Drawing.Color.Khaki;
            this.cases.Location = new System.Drawing.Point(106, 329);
            this.cases.Name = "cases";
            this.cases.Size = new System.Drawing.Size(54, 20);
            this.cases.TabIndex = 2;
            this.cases.Text = "Cases";
            // 
            // islandComboBox
            // 
            this.islandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.provinceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinceComboBox.FormattingEnabled = true;
            this.provinceComboBox.Location = new System.Drawing.Point(110, 278);
            this.provinceComboBox.Name = "provinceComboBox";
            this.provinceComboBox.Size = new System.Drawing.Size(445, 28);
            this.provinceComboBox.TabIndex = 5;
            // 
            // caseInputTextBox
            // 
            this.caseInputTextBox.Location = new System.Drawing.Point(110, 374);
            this.caseInputTextBox.Name = "caseInputTextBox";
            this.caseInputTextBox.Size = new System.Drawing.Size(100, 26);
            this.caseInputTextBox.TabIndex = 6;
            this.caseInputTextBox.TextChanged += new System.EventHandler(this.caseInputTextBox_TextChanged);
            this.caseInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.caseInputTextBox_KeyDown);
            // 
            // regionMap
            // 
            this.regionMap.AutoSize = true;
            this.regionMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regionMap.Location = new System.Drawing.Point(106, 48);
            this.regionMap.Name = "regionMap";
            this.regionMap.Size = new System.Drawing.Size(60, 20);
            this.regionMap.TabIndex = 8;
            this.regionMap.Text = "Region";
            // 
            // provinceMap
            // 
            this.provinceMap.AutoSize = true;
            this.provinceMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.provinceMap.Location = new System.Drawing.Point(106, 145);
            this.provinceMap.Name = "provinceMap";
            this.provinceMap.Size = new System.Drawing.Size(69, 20);
            this.provinceMap.TabIndex = 9;
            this.provinceMap.Text = "Province";
            // 
            // regionMapComboBox
            // 
            this.regionMapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionMapComboBox.FormattingEnabled = true;
            this.regionMapComboBox.Location = new System.Drawing.Point(110, 89);
            this.regionMapComboBox.Name = "regionMapComboBox";
            this.regionMapComboBox.Size = new System.Drawing.Size(445, 28);
            this.regionMapComboBox.TabIndex = 10;
            this.regionMapComboBox.DropDown += new System.EventHandler(this.regionMapComboBox_DropDown);
            this.regionMapComboBox.SelectedIndexChanged += new System.EventHandler(this.regionMapComboBox_SelectedIndexChanged);
            // 
            // provinceMapComboBox
            // 
            this.provinceMapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinceMapComboBox.FormattingEnabled = true;
            this.provinceMapComboBox.Location = new System.Drawing.Point(110, 180);
            this.provinceMapComboBox.Name = "provinceMapComboBox";
            this.provinceMapComboBox.Size = new System.Drawing.Size(445, 28);
            this.provinceMapComboBox.TabIndex = 11;
            this.provinceMapComboBox.DropDown += new System.EventHandler(this.provinceMapComboBox_DropDown);
            this.provinceMapComboBox.SelectedIndexChanged += new System.EventHandler(this.provinceMapComboBox_SelectedIndexChanged);
            // 
            // panelOfImage
            // 
            this.panelOfImage.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelOfImage.Controls.Add(this.tCase);
            this.panelOfImage.Controls.Add(this.provinceName);
            this.panelOfImage.Controls.Add(this.label2);
            this.panelOfImage.Controls.Add(this.label1);
            this.panelOfImage.Controls.Add(this.range501To1k);
            this.panelOfImage.Controls.Add(this.range0To500);
            this.panelOfImage.Controls.Add(this.case1);
            this.panelOfImage.Controls.Add(this.case2);
            this.panelOfImage.Controls.Add(this.case3);
            this.panelOfImage.Controls.Add(this.case4);
            this.panelOfImage.Controls.Add(this.backButton);
            this.panelOfImage.Controls.Add(this.provincePicture);
            this.panelOfImage.Location = new System.Drawing.Point(63, 420);
            this.panelOfImage.Name = "panelOfImage";
            this.panelOfImage.Size = new System.Drawing.Size(679, 401);
            this.panelOfImage.TabIndex = 1;
            // 
            // tCase
            // 
            this.tCase.AutoSize = true;
            this.tCase.ForeColor = System.Drawing.Color.Yellow;
            this.tCase.Location = new System.Drawing.Point(350, 78);
            this.tCase.Name = "tCase";
            this.tCase.Size = new System.Drawing.Size(93, 20);
            this.tCase.TabIndex = 5;
            this.tCase.Text = "Total Case: ";
            // 
            // provinceName
            // 
            this.provinceName.AutoSize = true;
            this.provinceName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.provinceName.Location = new System.Drawing.Point(350, 18);
            this.provinceName.Name = "provinceName";
            this.provinceName.Size = new System.Drawing.Size(110, 20);
            this.provinceName.TabIndex = 4;
            this.provinceName.Text = "provinceName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(275, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "2000+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(169, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "1000-2000";
            // 
            // range501To1k
            // 
            this.range501To1k.AutoSize = true;
            this.range501To1k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.range501To1k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.range501To1k.Location = new System.Drawing.Point(84, 258);
            this.range501To1k.Name = "range501To1k";
            this.range501To1k.Size = new System.Drawing.Size(79, 22);
            this.range501To1k.TabIndex = 3;
            this.range501To1k.Text = "501-1000";
            // 
            // range0To500
            // 
            this.range0To500.AutoSize = true;
            this.range0To500.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.range0To500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.range0To500.Location = new System.Drawing.Point(12, 258);
            this.range0To500.Name = "range0To500";
            this.range0To500.Size = new System.Drawing.Size(52, 22);
            this.range0To500.TabIndex = 3;
            this.range0To500.Text = "0-500";
            // 
            // case1
            // 
            this.case1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("case1.BackgroundImage")));
            this.case1.Location = new System.Drawing.Point(12, 201);
            this.case1.Name = "case1";
            this.case1.Size = new System.Drawing.Size(49, 36);
            this.case1.TabIndex = 2;
            this.case1.TabStop = false;
            // 
            // case2
            // 
            this.case2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("case2.BackgroundImage")));
            this.case2.Location = new System.Drawing.Point(98, 201);
            this.case2.Name = "case2";
            this.case2.Size = new System.Drawing.Size(49, 36);
            this.case2.TabIndex = 2;
            this.case2.TabStop = false;
            // 
            // case3
            // 
            this.case3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("case3.BackgroundImage")));
            this.case3.Location = new System.Drawing.Point(186, 201);
            this.case3.Name = "case3";
            this.case3.Size = new System.Drawing.Size(49, 36);
            this.case3.TabIndex = 2;
            this.case3.TabStop = false;
            // 
            // case4
            // 
            this.case4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("case4.BackgroundImage")));
            this.case4.Location = new System.Drawing.Point(275, 201);
            this.case4.Name = "case4";
            this.case4.Size = new System.Drawing.Size(49, 36);
            this.case4.TabIndex = 2;
            this.case4.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(398, 311);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(201, 64);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // provincePicture
            // 
            this.provincePicture.BackColor = System.Drawing.Color.SlateGray;
            this.provincePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.provincePicture.Location = new System.Drawing.Point(98, 18);
            this.provincePicture.Name = "provincePicture";
            this.provincePicture.Size = new System.Drawing.Size(193, 160);
            this.provincePicture.TabIndex = 0;
            this.provincePicture.TabStop = false;
            // 
            // currentIsland
            // 
            this.currentIsland.AutoSize = true;
            this.currentIsland.BackColor = System.Drawing.Color.DarkOrange;
            this.currentIsland.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentIsland.Location = new System.Drawing.Point(682, 9);
            this.currentIsland.Name = "currentIsland";
            this.currentIsland.Size = new System.Drawing.Size(332, 40);
            this.currentIsland.TabIndex = 0;
            this.currentIsland.Text = "CURRENT ISLAND";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.mindanao);
            this.panel1.Controls.Add(this.visayas);
            this.panel1.Controls.Add(this.luzonButton);
            this.panel1.Location = new System.Drawing.Point(1395, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 564);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mindanao
            // 
            this.mindanao.BackColor = System.Drawing.Color.Transparent;
            this.mindanao.FlatAppearance.BorderSize = 0;
            this.mindanao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mindanao.Location = new System.Drawing.Point(127, 407);
            this.mindanao.Name = "mindanao";
            this.mindanao.Size = new System.Drawing.Size(300, 140);
            this.mindanao.TabIndex = 12;
            this.mindanao.Text = "mindanao";
            this.mindanao.UseVisualStyleBackColor = false;
            this.mindanao.Click += new System.EventHandler(this.mindanao_Click);
            // 
            // visayas
            // 
            this.visayas.BackColor = System.Drawing.Color.Transparent;
            this.visayas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.visayas.Location = new System.Drawing.Point(0, 265);
            this.visayas.Name = "visayas";
            this.visayas.Size = new System.Drawing.Size(321, 136);
            this.visayas.TabIndex = 1;
            this.visayas.Text = "visayas";
            this.visayas.UseVisualStyleBackColor = false;
            this.visayas.Click += new System.EventHandler(this.button1_Click);
            // 
            // luzonButton
            // 
            this.luzonButton.BackColor = System.Drawing.Color.Transparent;
            this.luzonButton.FlatAppearance.BorderSize = 0;
            this.luzonButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.luzonButton.Location = new System.Drawing.Point(127, 3);
            this.luzonButton.Name = "luzonButton";
            this.luzonButton.Size = new System.Drawing.Size(194, 256);
            this.luzonButton.TabIndex = 0;
            this.luzonButton.Text = "Luzon";
            this.luzonButton.UseVisualStyleBackColor = false;
            this.luzonButton.Click += new System.EventHandler(this.luzonButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.totalCases);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(886, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 252);
            this.panel2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "TOTAL CASE";
            // 
            // totalCases
            // 
            this.totalCases.AutoSize = true;
            this.totalCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCases.Location = new System.Drawing.Point(47, 104);
            this.totalCases.Name = "totalCases";
            this.totalCases.Size = new System.Drawing.Size(104, 113);
            this.totalCases.TabIndex = 1;
            this.totalCases.Text = "0";
            // 
            // Mapa_ni_Tiquia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.currentIsland);
            this.Controls.Add(this.panelOfImage);
            this.Controls.Add(this.provinceMapComboBox);
            this.Controls.Add(this.regionMapComboBox);
            this.Controls.Add(this.provinceMap);
            this.Controls.Add(this.regionMap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caseInputTextBox);
            this.Controls.Add(this.provinceComboBox);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.islandComboBox);
            this.Controls.Add(this.islandLabel);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.cases);
            this.Controls.Add(this.provinceLabel);
            this.Name = "Mapa_ni_Tiquia";
            this.Text = "Mapa_ni_Tiquia";
            this.Load += new System.EventHandler(this.Mapa_ni_Tiquia_Load);
            this.panelOfImage.ResumeLayout(false);
            this.panelOfImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.case1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.case2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.case3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.case4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label islandLabel;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Label cases;
        private System.Windows.Forms.ComboBox islandComboBox;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.ComboBox provinceComboBox;
        private System.Windows.Forms.TextBox caseInputTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button luzonButton;
        private System.Windows.Forms.Label regionMap;
        private System.Windows.Forms.Label provinceMap;
        private System.Windows.Forms.ComboBox regionMapComboBox;
        private System.Windows.Forms.ComboBox provinceMapComboBox;
        private System.Windows.Forms.Panel panelOfImage;
        private System.Windows.Forms.Label currentIsland;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox provincePicture;
        private System.Windows.Forms.Button visayas;
        private System.Windows.Forms.Button mindanao;
        private System.Windows.Forms.PictureBox case1;
        private System.Windows.Forms.PictureBox case2;
        private System.Windows.Forms.PictureBox case3;
        private System.Windows.Forms.PictureBox case4;
        private System.Windows.Forms.Label provinceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label range501To1k;
        private System.Windows.Forms.Label range0To500;
        private System.Windows.Forms.Label tCase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalCases;
        private System.Windows.Forms.Label label3;
    }
}