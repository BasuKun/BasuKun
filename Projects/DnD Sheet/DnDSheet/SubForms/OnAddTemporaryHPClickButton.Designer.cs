namespace DnDSheet.SubForms
{
    partial class OnAddTemporaryHPClickButton
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
            this.AddTemporaryHPPopupPanel = new System.Windows.Forms.Panel();
            this.AddTemporaryHPAmountTextBox = new System.Windows.Forms.TextBox();
            this.AddTemporaryHPPopupOKButton = new System.Windows.Forms.Button();
            this.AddTemporaryHPPopupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTemporaryHPPopupPanel
            // 
            this.AddTemporaryHPPopupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(189)))), ((int)(((byte)(206)))));
            this.AddTemporaryHPPopupPanel.Controls.Add(this.AddTemporaryHPAmountTextBox);
            this.AddTemporaryHPPopupPanel.Controls.Add(this.AddTemporaryHPPopupOKButton);
            this.AddTemporaryHPPopupPanel.Location = new System.Drawing.Point(4, 4);
            this.AddTemporaryHPPopupPanel.Name = "AddTemporaryHPPopupPanel";
            this.AddTemporaryHPPopupPanel.Size = new System.Drawing.Size(147, 41);
            this.AddTemporaryHPPopupPanel.TabIndex = 7;
            // 
            // AddTemporaryHPAmountTextBox
            // 
            this.AddTemporaryHPAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddTemporaryHPAmountTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTemporaryHPAmountTextBox.Location = new System.Drawing.Point(11, 12);
            this.AddTemporaryHPAmountTextBox.Name = "AddTemporaryHPAmountTextBox";
            this.AddTemporaryHPAmountTextBox.Size = new System.Drawing.Size(70, 16);
            this.AddTemporaryHPAmountTextBox.TabIndex = 0;
            this.AddTemporaryHPAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddTemporaryHPAmountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddTemporaryHPAmountTextBox_KeyDown);
            this.AddTemporaryHPAmountTextBox.Leave += new System.EventHandler(this.AddTemporaryHPAmountTextBox_Leave);
            // 
            // AddTemporaryHPPopupOKButton
            // 
            this.AddTemporaryHPPopupOKButton.Location = new System.Drawing.Point(87, 8);
            this.AddTemporaryHPPopupOKButton.Name = "AddTemporaryHPPopupOKButton";
            this.AddTemporaryHPPopupOKButton.Size = new System.Drawing.Size(49, 24);
            this.AddTemporaryHPPopupOKButton.TabIndex = 1;
            this.AddTemporaryHPPopupOKButton.Text = "OK";
            this.AddTemporaryHPPopupOKButton.UseVisualStyleBackColor = true;
            this.AddTemporaryHPPopupOKButton.Click += new System.EventHandler(this.AddTemporaryHPPopupOKButton_Click);
            // 
            // OnAddTemporaryHPClickButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(91)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(155, 49);
            this.Controls.Add(this.AddTemporaryHPPopupPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnAddTemporaryHPClickButton";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnAddTemporaryHPClickButton";
            this.AddTemporaryHPPopupPanel.ResumeLayout(false);
            this.AddTemporaryHPPopupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddTemporaryHPPopupPanel;
        private System.Windows.Forms.TextBox AddTemporaryHPAmountTextBox;
        private System.Windows.Forms.Button AddTemporaryHPPopupOKButton;
    }
}