namespace Paint
{
    partial class frmFontDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbxUnderline = new System.Windows.Forms.CheckBox();
            this.chbxStrikeout = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.txtFontStyle = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lboxFont = new System.Windows.Forms.ListBox();
            this.lboxFontStyle = new System.Windows.Forms.ListBox();
            this.lboxSize = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEjemplo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Font Style:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbxUnderline);
            this.groupBox1.Controls.Add(this.chbxStrikeout);
            this.groupBox1.Location = new System.Drawing.Point(16, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Effects";
            // 
            // chbxUnderline
            // 
            this.chbxUnderline.AutoSize = true;
            this.chbxUnderline.Location = new System.Drawing.Point(6, 43);
            this.chbxUnderline.Name = "chbxUnderline";
            this.chbxUnderline.Size = new System.Drawing.Size(71, 17);
            this.chbxUnderline.TabIndex = 1;
            this.chbxUnderline.Text = "Underline";
            this.chbxUnderline.UseVisualStyleBackColor = true;
            this.chbxUnderline.CheckedChanged += new System.EventHandler(this.chbxUnderline_CheckedChanged);
            // 
            // chbxStrikeout
            // 
            this.chbxStrikeout.AutoSize = true;
            this.chbxStrikeout.Location = new System.Drawing.Point(6, 19);
            this.chbxStrikeout.Name = "chbxStrikeout";
            this.chbxStrikeout.Size = new System.Drawing.Size(68, 17);
            this.chbxStrikeout.TabIndex = 0;
            this.chbxStrikeout.Text = "Strikeout";
            this.chbxStrikeout.UseVisualStyleBackColor = true;
            this.chbxStrikeout.CheckedChanged += new System.EventHandler(this.chbxStrikeout_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEjemplo);
            this.groupBox2.Location = new System.Drawing.Point(222, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text";
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(16, 30);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(100, 20);
            this.txtFont.TabIndex = 7;
            this.txtFont.Text = "Microsoft Sans Serif";
            this.txtFont.TextChanged += new System.EventHandler(this.txtFont_TextChanged);
            // 
            // txtFontStyle
            // 
            this.txtFontStyle.Location = new System.Drawing.Point(122, 30);
            this.txtFontStyle.Name = "txtFontStyle";
            this.txtFontStyle.Size = new System.Drawing.Size(100, 20);
            this.txtFontStyle.TabIndex = 8;
            this.txtFontStyle.Text = "Regular";
            this.txtFontStyle.TextChanged += new System.EventHandler(this.txtFontStyle_TextChanged);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(229, 29);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(59, 20);
            this.txtSize.TabIndex = 9;
            this.txtSize.Text = "8";
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // lboxFont
            // 
            this.lboxFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxFont.FormattingEnabled = true;
            this.lboxFont.ItemHeight = 16;
            this.lboxFont.Items.AddRange(new object[] {
            "Arial",
            "Comic Sans MS",
            "Consolas",
            "Microsoft Sans Serif",
            "Microsoft YaHei UI",
            "Stencil",
            "Tahoma",
            "Times New Roman",
            "Yu Gothic UI"});
            this.lboxFont.Location = new System.Drawing.Point(17, 58);
            this.lboxFont.Name = "lboxFont";
            this.lboxFont.Size = new System.Drawing.Size(99, 84);
            this.lboxFont.TabIndex = 10;
            this.lboxFont.SelectedIndexChanged += new System.EventHandler(this.lboxFont_SelectedIndexChanged);
            // 
            // lboxFontStyle
            // 
            this.lboxFontStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxFontStyle.FormattingEnabled = true;
            this.lboxFontStyle.ItemHeight = 16;
            this.lboxFontStyle.Items.AddRange(new object[] {
            "Regular",
            "Bold",
            "Italic"});
            this.lboxFontStyle.Location = new System.Drawing.Point(123, 58);
            this.lboxFontStyle.Name = "lboxFontStyle";
            this.lboxFontStyle.Size = new System.Drawing.Size(99, 84);
            this.lboxFontStyle.TabIndex = 11;
            this.lboxFontStyle.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lboxSize
            // 
            this.lboxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxSize.FormattingEnabled = true;
            this.lboxSize.ItemHeight = 16;
            this.lboxSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26"});
            this.lboxSize.Location = new System.Drawing.Point(229, 58);
            this.lboxSize.Name = "lboxSize";
            this.lboxSize.Size = new System.Drawing.Size(59, 84);
            this.lboxSize.TabIndex = 12;
            this.lboxSize.SelectedIndexChanged += new System.EventHandler(this.lboxSize_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(306, 29);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(306, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.Location = new System.Drawing.Point(7, 30);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(120, 20);
            this.lblEjemplo.TabIndex = 15;
            this.lblEjemplo.Text = "Text Sample";
            // 
            // frmFontDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 248);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lboxSize);
            this.Controls.Add(this.lboxFontStyle);
            this.Controls.Add(this.lboxFont);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtFontStyle);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFontDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font_Dialog";
            this.Load += new System.EventHandler(this.frmFontDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.TextBox txtFontStyle;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.CheckBox chbxUnderline;
        private System.Windows.Forms.CheckBox chbxStrikeout;
        private System.Windows.Forms.ListBox lboxFont;
        private System.Windows.Forms.ListBox lboxFontStyle;
        private System.Windows.Forms.ListBox lboxSize;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox lblEjemplo;
    }
}