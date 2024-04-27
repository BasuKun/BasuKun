namespace DnDSheet.SubForms
{
    partial class OnHealHPClickButton
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
            this.HealHPAmountTextBox = new System.Windows.Forms.TextBox();
            this.HealHPPopupOKButton = new System.Windows.Forms.Button();
            this.HealHpPopupPanel = new System.Windows.Forms.Panel();
            this.HealHpPopupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HealHPAmountTextBox
            // 
            this.HealHPAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HealHPAmountTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealHPAmountTextBox.Location = new System.Drawing.Point(11, 12);
            this.HealHPAmountTextBox.Name = "HealHPAmountTextBox";
            this.HealHPAmountTextBox.Size = new System.Drawing.Size(70, 16);
            this.HealHPAmountTextBox.TabIndex = 0;
            this.HealHPAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HealHPAmountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HealHPAmountTextBox_KeyDown);
            this.HealHPAmountTextBox.Leave += new System.EventHandler(this.HealHPAmountTextBox_Leave);
            // 
            // HealHPPopupOKButton
            // 
            this.HealHPPopupOKButton.Location = new System.Drawing.Point(87, 8);
            this.HealHPPopupOKButton.Name = "HealHPPopupOKButton";
            this.HealHPPopupOKButton.Size = new System.Drawing.Size(49, 24);
            this.HealHPPopupOKButton.TabIndex = 1;
            this.HealHPPopupOKButton.Text = "OK";
            this.HealHPPopupOKButton.UseVisualStyleBackColor = true;
            this.HealHPPopupOKButton.Click += new System.EventHandler(this.HealHPPopupOKButton_Click);
            // 
            // HealHpPopupPanel
            // 
            this.HealHpPopupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            this.HealHpPopupPanel.Controls.Add(this.HealHPAmountTextBox);
            this.HealHpPopupPanel.Controls.Add(this.HealHPPopupOKButton);
            this.HealHpPopupPanel.Location = new System.Drawing.Point(4, 4);
            this.HealHpPopupPanel.Name = "HealHpPopupPanel";
            this.HealHpPopupPanel.Size = new System.Drawing.Size(147, 41);
            this.HealHpPopupPanel.TabIndex = 5;
            // 
            // OnHealHPClickButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(124)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(155, 49);
            this.Controls.Add(this.HealHpPopupPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnHealHPClickButton";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnHealHPClickButton";
            this.HealHpPopupPanel.ResumeLayout(false);
            this.HealHpPopupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox HealHPAmountTextBox;
        private System.Windows.Forms.Button HealHPPopupOKButton;
        private System.Windows.Forms.Panel HealHpPopupPanel;
    }
}