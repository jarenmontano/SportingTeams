namespace SportingTeams
{
    partial class SportingGui
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
            GBxSports = new GroupBox();
            RBxPickleball = new RadioButton();
            RBxSoccer = new RadioButton();
            RTBxAllInfo = new RichTextBox();
            lblToString = new Label();
            lblTeamName = new Label();
            lblSubclass = new Label();
            TBxTeamName = new TextBox();
            TBxSubclass = new TextBox();
            lblFunding = new Label();
            RTBxFunding = new RichTextBox();
            GBxSports.SuspendLayout();
            SuspendLayout();
            // 
            // GBxSports
            // 
            GBxSports.Controls.Add(RBxPickleball);
            GBxSports.Controls.Add(RBxSoccer);
            GBxSports.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GBxSports.Location = new Point(12, 12);
            GBxSports.Name = "GBxSports";
            GBxSports.Size = new Size(245, 119);
            GBxSports.TabIndex = 0;
            GBxSports.TabStop = false;
            GBxSports.Text = "Sports";
            // 
            // RBxPickleball
            // 
            RBxPickleball.AutoSize = true;
            RBxPickleball.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RBxPickleball.Location = new Point(55, 61);
            RBxPickleball.Name = "RBxPickleball";
            RBxPickleball.Size = new Size(102, 25);
            RBxPickleball.TabIndex = 1;
            RBxPickleball.TabStop = true;
            RBxPickleball.Text = "Pickleball";
            RBxPickleball.UseVisualStyleBackColor = true;
            RBxPickleball.CheckedChanged += RBxPickleball_CheckedChanged;
            // 
            // RBxSoccer
            // 
            RBxSoccer.AutoSize = true;
            RBxSoccer.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RBxSoccer.Location = new Point(55, 27);
            RBxSoccer.Name = "RBxSoccer";
            RBxSoccer.Size = new Size(79, 25);
            RBxSoccer.TabIndex = 0;
            RBxSoccer.TabStop = true;
            RBxSoccer.Text = "Soccer";
            RBxSoccer.UseVisualStyleBackColor = true;
            RBxSoccer.CheckedChanged += RBxSoccer_CheckedChanged;
            // 
            // RTBxAllInfo
            // 
            RTBxAllInfo.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RTBxAllInfo.Location = new Point(144, 290);
            RTBxAllInfo.Name = "RTBxAllInfo";
            RTBxAllInfo.Size = new Size(326, 144);
            RTBxAllInfo.TabIndex = 1;
            RTBxAllInfo.Text = "";
            // 
            // lblToString
            // 
            lblToString.AutoSize = true;
            lblToString.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblToString.Location = new Point(42, 310);
            lblToString.Name = "lblToString";
            lblToString.Size = new Size(64, 21);
            lblToString.TabIndex = 2;
            lblToString.Text = "All Info";
            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTeamName.Location = new Point(17, 166);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(97, 21);
            lblTeamName.TabIndex = 3;
            lblTeamName.Text = "Team Name";
            // 
            // lblSubclass
            // 
            lblSubclass.AutoSize = true;
            lblSubclass.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubclass.Location = new Point(11, 211);
            lblSubclass.Name = "lblSubclass";
            lblSubclass.Size = new Size(110, 21);
            lblSubclass.TabIndex = 4;
            lblSubclass.Text = "Subclass Info";
            // 
            // TBxTeamName
            // 
            TBxTeamName.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TBxTeamName.Location = new Point(144, 160);
            TBxTeamName.Name = "TBxTeamName";
            TBxTeamName.Size = new Size(163, 22);
            TBxTeamName.TabIndex = 5;
            // 
            // TBxSubclass
            // 
            TBxSubclass.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TBxSubclass.Location = new Point(144, 210);
            TBxSubclass.Name = "TBxSubclass";
            TBxSubclass.Size = new Size(326, 22);
            TBxSubclass.TabIndex = 6;
            // 
            // lblFunding
            // 
            lblFunding.AutoSize = true;
            lblFunding.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFunding.Location = new Point(505, 43);
            lblFunding.Name = "lblFunding";
            lblFunding.Size = new Size(69, 21);
            lblFunding.TabIndex = 7;
            lblFunding.Text = "Funding";
            // 
            // RTBxFunding
            // 
            RTBxFunding.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RTBxFunding.Location = new Point(511, 71);
            RTBxFunding.Name = "RTBxFunding";
            RTBxFunding.Size = new Size(273, 363);
            RTBxFunding.TabIndex = 8;
            RTBxFunding.Text = "";
            // 
            // SportingGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(RTBxFunding);
            Controls.Add(lblFunding);
            Controls.Add(TBxSubclass);
            Controls.Add(TBxTeamName);
            Controls.Add(lblSubclass);
            Controls.Add(lblTeamName);
            Controls.Add(lblToString);
            Controls.Add(RTBxAllInfo);
            Controls.Add(GBxSports);
            Name = "SportingGui";
            Text = "Sporting Weber";
            Load += SportingGui_Load;
            GBxSports.ResumeLayout(false);
            GBxSports.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GBxSports;
        private RadioButton RBxPickleball;
        private RadioButton RBxSoccer;
        private RichTextBox RTBxAllInfo;
        private Label lblToString;
        private Label lblTeamName;
        private Label lblSubclass;
        private TextBox TBxTeamName;
        private TextBox TBxSubclass;
        private Label lblFunding;
        private RichTextBox RTBxFunding;
    }
}