namespace Lab3CSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateFactoryBtn = new System.Windows.Forms.Button();
            this.ComboBoxCurrentSelectedFactory = new System.Windows.Forms.ComboBox();
            this.TextBoxUniqeKey = new System.Windows.Forms.TextBox();
            this.HireWorkerBtn = new System.Windows.Forms.Button();
            this.FireWorkerBtn = new System.Windows.Forms.Button();
            this.LabelUniqePersonId = new System.Windows.Forms.Label();
            this.ComboBoxSecondaryFactory = new System.Windows.Forms.ComboBox();
            this.LabelCurrentSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.ShowFullInfoBtn = new System.Windows.Forms.Button();
            this.SaveToFilesBtn = new System.Windows.Forms.Button();
            this.ShowInfoFromFilesBtn = new System.Windows.Forms.Button();
            this.CopyFactoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateFactoryBtn
            // 
            this.GenerateFactoryBtn.Location = new System.Drawing.Point(31, 55);
            this.GenerateFactoryBtn.Name = "GenerateFactoryBtn";
            this.GenerateFactoryBtn.Size = new System.Drawing.Size(160, 29);
            this.GenerateFactoryBtn.TabIndex = 14;
            this.GenerateFactoryBtn.Text = "Generate factory";
            this.GenerateFactoryBtn.UseVisualStyleBackColor = true;
            this.GenerateFactoryBtn.Click += new System.EventHandler(this.GenerateFactoryBtn_Click);
            // 
            // ComboBoxCurrentSelectedFactory
            // 
            this.ComboBoxCurrentSelectedFactory.FormattingEnabled = true;
            this.ComboBoxCurrentSelectedFactory.Location = new System.Drawing.Point(501, 56);
            this.ComboBoxCurrentSelectedFactory.Name = "ComboBoxCurrentSelectedFactory";
            this.ComboBoxCurrentSelectedFactory.Size = new System.Drawing.Size(151, 28);
            this.ComboBoxCurrentSelectedFactory.TabIndex = 15;
            // 
            // TextBoxUniqeKey
            // 
            this.TextBoxUniqeKey.Location = new System.Drawing.Point(31, 301);
            this.TextBoxUniqeKey.Name = "TextBoxUniqeKey";
            this.TextBoxUniqeKey.Size = new System.Drawing.Size(125, 27);
            this.TextBoxUniqeKey.TabIndex = 16;
            // 
            // HireWorkerBtn
            // 
            this.HireWorkerBtn.Location = new System.Drawing.Point(131, 344);
            this.HireWorkerBtn.Name = "HireWorkerBtn";
            this.HireWorkerBtn.Size = new System.Drawing.Size(94, 29);
            this.HireWorkerBtn.TabIndex = 17;
            this.HireWorkerBtn.Text = "Hire";
            this.HireWorkerBtn.UseVisualStyleBackColor = true;
            this.HireWorkerBtn.Click += new System.EventHandler(this.HirePersonBtn_Click);
            // 
            // FireWorkerBtn
            // 
            this.FireWorkerBtn.Location = new System.Drawing.Point(31, 344);
            this.FireWorkerBtn.Name = "FireWorkerBtn";
            this.FireWorkerBtn.Size = new System.Drawing.Size(94, 29);
            this.FireWorkerBtn.TabIndex = 18;
            this.FireWorkerBtn.Text = "Fire";
            this.FireWorkerBtn.UseVisualStyleBackColor = true;
            this.FireWorkerBtn.Click += new System.EventHandler(this.FirePersonBtn_Click);
            // 
            // LabelUniqePersonId
            // 
            this.LabelUniqePersonId.AutoSize = true;
            this.LabelUniqePersonId.Location = new System.Drawing.Point(176, 298);
            this.LabelUniqePersonId.Name = "LabelUniqePersonId";
            this.LabelUniqePersonId.Size = new System.Drawing.Size(114, 20);
            this.LabelUniqePersonId.TabIndex = 22;
            this.LabelUniqePersonId.Text = "Uniqe person id";
            // 
            // ComboBoxSecondaryFactory
            // 
            this.ComboBoxSecondaryFactory.FormattingEnabled = true;
            this.ComboBoxSecondaryFactory.Location = new System.Drawing.Point(383, 316);
            this.ComboBoxSecondaryFactory.Name = "ComboBoxSecondaryFactory";
            this.ComboBoxSecondaryFactory.Size = new System.Drawing.Size(151, 28);
            this.ComboBoxSecondaryFactory.TabIndex = 24;
            // 
            // LabelCurrentSelected
            // 
            this.LabelCurrentSelected.AutoSize = true;
            this.LabelCurrentSelected.Location = new System.Drawing.Point(367, 64);
            this.LabelCurrentSelected.Name = "LabelCurrentSelected";
            this.LabelCurrentSelected.Size = new System.Drawing.Size(118, 20);
            this.LabelCurrentSelected.TabIndex = 25;
            this.LabelCurrentSelected.Text = "Current Selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Current Selected (To compare or add)";
            // 
            // CompareBtn
            // 
            this.CompareBtn.Location = new System.Drawing.Point(383, 362);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(94, 29);
            this.CompareBtn.TabIndex = 27;
            this.CompareBtn.Text = "Compare";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // ShowFullInfoBtn
            // 
            this.ShowFullInfoBtn.Location = new System.Drawing.Point(685, 55);
            this.ShowFullInfoBtn.Name = "ShowFullInfoBtn";
            this.ShowFullInfoBtn.Size = new System.Drawing.Size(94, 29);
            this.ShowFullInfoBtn.TabIndex = 32;
            this.ShowFullInfoBtn.Text = "Show Info";
            this.ShowFullInfoBtn.UseVisualStyleBackColor = true;
            this.ShowFullInfoBtn.Click += new System.EventHandler(this.ShowFullInfoBtn_Click);
            // 
            // SaveToFilesBtn
            // 
            this.SaveToFilesBtn.Location = new System.Drawing.Point(131, 203);
            this.SaveToFilesBtn.Name = "SaveToFilesBtn";
            this.SaveToFilesBtn.Size = new System.Drawing.Size(159, 29);
            this.SaveToFilesBtn.TabIndex = 33;
            this.SaveToFilesBtn.Text = "Save info to files";
            this.SaveToFilesBtn.UseVisualStyleBackColor = true;
            this.SaveToFilesBtn.Click += new System.EventHandler(this.SaveToFilesBtn_Click);
            // 
            // ShowInfoFromFilesBtn
            // 
            this.ShowInfoFromFilesBtn.Location = new System.Drawing.Point(367, 203);
            this.ShowInfoFromFilesBtn.Name = "ShowInfoFromFilesBtn";
            this.ShowInfoFromFilesBtn.Size = new System.Drawing.Size(185, 29);
            this.ShowInfoFromFilesBtn.TabIndex = 34;
            this.ShowInfoFromFilesBtn.Text = "Show Info from file";
            this.ShowInfoFromFilesBtn.UseVisualStyleBackColor = true;
            this.ShowInfoFromFilesBtn.Click += new System.EventHandler(this.ShowInfoFromFiles_Click);
            // 
            // CopyFactoryBtn
            // 
            this.CopyFactoryBtn.Location = new System.Drawing.Point(685, 146);
            this.CopyFactoryBtn.Name = "CopyFactoryBtn";
            this.CopyFactoryBtn.Size = new System.Drawing.Size(260, 29);
            this.CopyFactoryBtn.TabIndex = 35;
            this.CopyFactoryBtn.Text = "Copy factory using constructor";
            this.CopyFactoryBtn.UseVisualStyleBackColor = true;
            this.CopyFactoryBtn.Click += new System.EventHandler(this.CopyFactoryBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 462);
            this.Controls.Add(this.CopyFactoryBtn);
            this.Controls.Add(this.ShowInfoFromFilesBtn);
            this.Controls.Add(this.SaveToFilesBtn);
            this.Controls.Add(this.ShowFullInfoBtn);
            this.Controls.Add(this.CompareBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelCurrentSelected);
            this.Controls.Add(this.ComboBoxSecondaryFactory);
            this.Controls.Add(this.LabelUniqePersonId);
            this.Controls.Add(this.FireWorkerBtn);
            this.Controls.Add(this.HireWorkerBtn);
            this.Controls.Add(this.TextBoxUniqeKey);
            this.Controls.Add(this.ComboBoxCurrentSelectedFactory);
            this.Controls.Add(this.GenerateFactoryBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button GenerateFactoryBtn;
        private ComboBox ComboBoxCurrentSelectedFactory;
        private TextBox TextBoxUniqeKey;
        private Button HireWorkerBtn;
        private Button FireWorkerBtn;
        private Label LabelUniqePersonId;
        private ComboBox ComboBoxSecondaryFactory;
        private Label LabelCurrentSelected;
        private Label label1;
        private Button CompareBtn;
        private Button ShowFullInfoBtn;
        private Button SaveToFilesBtn;
        private Button ShowInfoFromFilesBtn;
        private Button CopyFactoryBtn;
    }
}