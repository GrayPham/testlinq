namespace testlinq
{
    partial class Form1
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.button_log = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_can = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_id.Location = new System.Drawing.Point(209, 164);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(29, 22);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_pass.Location = new System.Drawing.Point(209, 207);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(54, 22);
            this.label_pass.TabIndex = 2;
            this.label_pass.Text = "Pass";
            // 
            // button_log
            // 
            this.button_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_log.Location = new System.Drawing.Point(297, 270);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(80, 40);
            this.button_log.TabIndex = 3;
            this.button_log.Text = "Log in";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_id.Location = new System.Drawing.Point(284, 161);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(233, 28);
            this.textBox_id.TabIndex = 1;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_pass.Location = new System.Drawing.Point(284, 207);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(233, 28);
            this.textBox_pass.TabIndex = 4;
            // 
            // button_can
            // 
            this.button_can.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_can.Location = new System.Drawing.Point(409, 270);
            this.button_can.Name = "button_can";
            this.button_can.Size = new System.Drawing.Size(82, 40);
            this.button_can.TabIndex = 5;
            this.button_can.Text = "Cancel";
            this.button_can.UseVisualStyleBackColor = true;
            this.button_can.Click += new System.EventHandler(this.button_can_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_can);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_can;
    }
}

