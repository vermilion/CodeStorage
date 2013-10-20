namespace CodeStorage
{
    partial class EntryEditor
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

        #region Component Designer generated _teCode

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the _teCode editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._teCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._tbDescription = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._cbLanguage = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._tbCategory = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._tbName = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this._teCode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // _teCode
            // 
            this._teCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._teCode.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this._teCode.BackBrush = null;
            this._teCode.CharHeight = 14;
            this._teCode.CharWidth = 8;
            this._teCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._teCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._teCode.IsReplaceMode = false;
            this._teCode.Location = new System.Drawing.Point(6, 19);
            this._teCode.Name = "_teCode";
            this._teCode.Paddings = new System.Windows.Forms.Padding(0);
            this._teCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._teCode.Size = new System.Drawing.Size(688, 301);
            this._teCode.TabIndex = 4;
            this._teCode.Zoom = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this._tbDescription);
            this.groupBox5.Location = new System.Drawing.Point(9, 70);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(688, 45);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Description";
            // 
            // _tbDescription
            // 
            this._tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbDescription.Location = new System.Drawing.Point(3, 16);
            this._tbDescription.Name = "_tbDescription";
            this._tbDescription.Size = new System.Drawing.Size(682, 20);
            this._tbDescription.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this._cbLanguage);
            this.groupBox4.Location = new System.Drawing.Point(609, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(85, 45);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Language";
            // 
            // _cbLanguage
            // 
            this._cbLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbLanguage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbLanguage.Items.AddRange(new object[] {
            "C#",
            "VB",
            "HTML",
            "SQL",
            "PHP",
            "JS",
            "Other"});
            this._cbLanguage.Location = new System.Drawing.Point(3, 16);
            this._cbLanguage.Margin = new System.Windows.Forms.Padding(2);
            this._cbLanguage.Name = "_cbLanguage";
            this._cbLanguage.Size = new System.Drawing.Size(79, 21);
            this._cbLanguage.TabIndex = 3;
            this._cbLanguage.SelectedIndexChanged += new System.EventHandler(this.LangTextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._tbCategory);
            this.groupBox3.Location = new System.Drawing.Point(402, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 45);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category";
            // 
            // _tbCategory
            // 
            this._tbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbCategory.Location = new System.Drawing.Point(3, 16);
            this._tbCategory.Name = "_tbCategory";
            this._tbCategory.Size = new System.Drawing.Size(195, 20);
            this._tbCategory.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._tbName);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name";
            // 
            // _tbName
            // 
            this._tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbName.Location = new System.Drawing.Point(3, 16);
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(387, 20);
            this._tbName.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this._teCode);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 124);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(700, 326);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Code";
            // 
            // EntryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "EntryEditor";
            this.Size = new System.Drawing.Size(700, 450);
            ((System.ComponentModel.ISupportInitialize)(this._teCode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox _teCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox _tbDescription;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox _cbLanguage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _tbCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _tbName;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}
