namespace Assignment1_SimonGame
{
    partial class InstructionsForm
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
            lblInstructions = new Label();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // lblInstructions
            // 
            lblInstructions.Anchor = AnchorStyles.Top;
            lblInstructions.AutoSize = true;
            lblInstructions.BackColor = Color.Black;
            lblInstructions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructions.ForeColor = Color.White;
            lblInstructions.Location = new Point(193, 83);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(57, 21);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "label1";
            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOkay
            // 
            btnOkay.Anchor = AnchorStyles.Bottom;
            btnOkay.BackColor = Color.White;
            btnOkay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOkay.Location = new Point(356, 355);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(108, 38);
            btnOkay.TabIndex = 1;
            btnOkay.Text = "OK";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += btnOkay_Click;
            // 
            // InstructionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOkay);
            Controls.Add(lblInstructions);
            Name = "InstructionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstructions;
        private Button btnOkay;
    }
}