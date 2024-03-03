namespace kpl
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBoxInput

            this.textBoxInput.BackColor = System.Drawing.Color.Blue;
            this.textBoxInput.Location = new System.Drawing.Point(33, 70);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(199, 20);
            this.textBoxInput.TabIndex = 0;
 
            // buttonSubmit

            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.BackColor = System.Drawing.Color.Blue;
            this.buttonSubmit.Location = new System.Drawing.Point(237, 79);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 30);
            this.buttonSubmit.TabIndex = 1;
            this.textBoxInput.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);

            // labelOutput

            this.labelOutput.ForeColor = System.Drawing.Color.White;
            this.labelOutput.BackColor = System.Drawing.Color.Blue;
            this.labelOutput.Location = new System.Drawing.Point(33, 103);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(198, 20);
            this.labelOutput.TabIndex = 2;

            // Form1

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 181);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelOutput;
    }
}