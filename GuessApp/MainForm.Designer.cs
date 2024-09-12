namespace GuessApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblFeedback;
        private TextBox txtGuess;
        private Button btnSubmit;
        private Button btnRestart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFeedback = new Label();
            this.txtGuess = new TextBox();
            this.btnSubmit = new Button();
            this.btnRestart = new Button();
            this.SuspendLayout();
            
            // lblFeedback
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(30, 30);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(200, 15);
            this.lblFeedback.TabIndex = 0;
            this.lblFeedback.Text = "Guess a number between 1 and 100.";
            
            // txtGuess
            this.txtGuess.Location = new System.Drawing.Point(30, 60);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 23);
            this.txtGuess.TabIndex = 1;
            
            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(150, 60);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // btnRestart
            this.btnRestart.Location = new System.Drawing.Point(30, 100);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblFeedback);
            this.Name = "MainForm";
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
