namespace FalloutTerminalHelper.Gui
{
    partial class FalloutTerminalHelperGui
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
            this.tbWord = new System.Windows.Forms.TextBox();
            this.tbMatches = new System.Windows.Forms.TextBox();
            this.btAddEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.tbCheckWord = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.lMatches = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(53, 215);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(100, 20);
            this.tbWord.TabIndex = 0;
            // 
            // tbMatches
            // 
            this.tbMatches.Location = new System.Drawing.Point(213, 215);
            this.tbMatches.Name = "tbMatches";
            this.tbMatches.Size = new System.Drawing.Size(59, 20);
            this.tbMatches.TabIndex = 1;
            // 
            // btAddEntry
            // 
            this.btAddEntry.Location = new System.Drawing.Point(12, 241);
            this.btAddEntry.Name = "btAddEntry";
            this.btAddEntry.Size = new System.Drawing.Size(260, 23);
            this.btAddEntry.TabIndex = 2;
            this.btAddEntry.Text = "Add Entry";
            this.btAddEntry.UseVisualStyleBackColor = true;
            this.btAddEntry.Click += new System.EventHandler(this.btAddEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matches:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Word:";
            // 
            // pbScreen
            // 
            this.pbScreen.Location = new System.Drawing.Point(12, 12);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(260, 197);
            this.pbScreen.TabIndex = 5;
            this.pbScreen.TabStop = false;
            // 
            // tbCheckWord
            // 
            this.tbCheckWord.Location = new System.Drawing.Point(278, 12);
            this.tbCheckWord.Name = "tbCheckWord";
            this.tbCheckWord.Size = new System.Drawing.Size(94, 20);
            this.tbCheckWord.TabIndex = 6;
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(278, 39);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(94, 23);
            this.btCheck.TabIndex = 7;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // lMatches
            // 
            this.lMatches.AutoSize = true;
            this.lMatches.Location = new System.Drawing.Point(278, 65);
            this.lMatches.Name = "lMatches";
            this.lMatches.Size = new System.Drawing.Size(0, 13);
            this.lMatches.TabIndex = 8;
            // 
            // FalloutTerminalHelperGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 276);
            this.Controls.Add(this.lMatches);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbCheckWord);
            this.Controls.Add(this.pbScreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddEntry);
            this.Controls.Add(this.tbMatches);
            this.Controls.Add(this.tbWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FalloutTerminalHelperGui";
            this.Text = "Fallout Terminal Helper";
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.TextBox tbMatches;
        private System.Windows.Forms.Button btAddEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbScreen;
        private System.Windows.Forms.TextBox tbCheckWord;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label lMatches;
    }
}

