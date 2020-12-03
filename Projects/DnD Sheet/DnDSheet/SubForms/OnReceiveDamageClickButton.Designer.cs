namespace DnDSheet.SubForms
{
    partial class OnReceiveDamageClickButton
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
            this.ReceiveDamagePopupPanel = new System.Windows.Forms.Panel();
            this.ReceiveDamageAmountTextBox = new System.Windows.Forms.TextBox();
            this.ReceiveDamagePopupOKButton = new System.Windows.Forms.Button();
            this.ReceiveDamagePopupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReceiveDamagePopupPanel
            // 
            this.ReceiveDamagePopupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.ReceiveDamagePopupPanel.Controls.Add(this.ReceiveDamageAmountTextBox);
            this.ReceiveDamagePopupPanel.Controls.Add(this.ReceiveDamagePopupOKButton);
            this.ReceiveDamagePopupPanel.Location = new System.Drawing.Point(4, 4);
            this.ReceiveDamagePopupPanel.Name = "ReceiveDamagePopupPanel";
            this.ReceiveDamagePopupPanel.Size = new System.Drawing.Size(147, 41);
            this.ReceiveDamagePopupPanel.TabIndex = 6;
            // 
            // ReceiveDamageAmountTextBox
            // 
            this.ReceiveDamageAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceiveDamageAmountTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveDamageAmountTextBox.Location = new System.Drawing.Point(11, 12);
            this.ReceiveDamageAmountTextBox.Name = "ReceiveDamageAmountTextBox";
            this.ReceiveDamageAmountTextBox.Size = new System.Drawing.Size(70, 16);
            this.ReceiveDamageAmountTextBox.TabIndex = 0;
            this.ReceiveDamageAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReceiveDamageAmountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReceiveDamageAmountTextBox_KeyDown);
            this.ReceiveDamageAmountTextBox.Leave += new System.EventHandler(this.ReceiveDamageAmountTextBox_Leave);
            // 
            // ReceiveDamagePopupOKButton
            // 
            this.ReceiveDamagePopupOKButton.Location = new System.Drawing.Point(87, 8);
            this.ReceiveDamagePopupOKButton.Name = "ReceiveDamagePopupOKButton";
            this.ReceiveDamagePopupOKButton.Size = new System.Drawing.Size(49, 24);
            this.ReceiveDamagePopupOKButton.TabIndex = 1;
            this.ReceiveDamagePopupOKButton.Text = "OK";
            this.ReceiveDamagePopupOKButton.UseVisualStyleBackColor = true;
            this.ReceiveDamagePopupOKButton.Click += new System.EventHandler(this.ReceiveDamagePopupOKButton_Click);
            // 
            // OnReceiveDamageClickButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(155, 49);
            this.Controls.Add(this.ReceiveDamagePopupPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnReceiveDamageClickButton";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnReceiveDamageClickButton";
            this.ReceiveDamagePopupPanel.ResumeLayout(false);
            this.ReceiveDamagePopupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ReceiveDamagePopupPanel;
        private System.Windows.Forms.TextBox ReceiveDamageAmountTextBox;
        private System.Windows.Forms.Button ReceiveDamagePopupOKButton;
    }
}