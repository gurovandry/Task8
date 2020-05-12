namespace PC_Searching.Forms
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cpu_text_box = new System.Windows.Forms.TextBox();
            this.ram_text_box = new System.Windows.Forms.TextBox();
            this.vm_text_box = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hdd_text_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.MaximumSize = new System.Drawing.Size(167, 23);
            this.label1.MinimumSize = new System.Drawing.Size(167, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(35, 140);
            this.label2.MaximumSize = new System.Drawing.Size(167, 23);
            this.label2.MinimumSize = new System.Drawing.Size(167, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "RAM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(35, 220);
            this.label3.MaximumSize = new System.Drawing.Size(167, 23);
            this.label3.MinimumSize = new System.Drawing.Size(167, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Video Card Memory";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpu_text_box
            // 
            this.cpu_text_box.Location = new System.Drawing.Point(208, 60);
            this.cpu_text_box.MaxLength = 20;
            this.cpu_text_box.Name = "cpu_text_box";
            this.cpu_text_box.Size = new System.Drawing.Size(197, 22);
            this.cpu_text_box.TabIndex = 10;
            // 
            // ram_text_box
            // 
            this.ram_text_box.Location = new System.Drawing.Point(208, 140);
            this.ram_text_box.MaxLength = 20;
            this.ram_text_box.Name = "ram_text_box";
            this.ram_text_box.Size = new System.Drawing.Size(197, 22);
            this.ram_text_box.TabIndex = 11;
            // 
            // vm_text_box
            // 
            this.vm_text_box.Location = new System.Drawing.Point(208, 220);
            this.vm_text_box.MaxLength = 20;
            this.vm_text_box.Name = "vm_text_box";
            this.vm_text_box.Size = new System.Drawing.Size(197, 22);
            this.vm_text_box.TabIndex = 12;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(185, 361);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(80, 30);
            this.search_button.TabIndex = 13;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(35, 300);
            this.label4.MaximumSize = new System.Drawing.Size(167, 23);
            this.label4.MinimumSize = new System.Drawing.Size(167, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "HDD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hdd_text_box
            // 
            this.hdd_text_box.Location = new System.Drawing.Point(208, 300);
            this.hdd_text_box.MaxLength = 20;
            this.hdd_text_box.Name = "hdd_text_box";
            this.hdd_text_box.Size = new System.Drawing.Size(197, 22);
            this.hdd_text_box.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.hdd_text_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.vm_text_box);
            this.Controls.Add(this.ram_text_box);
            this.Controls.Add(this.cpu_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Form3";
            this.Text = "Filters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cpu_text_box;
        private System.Windows.Forms.TextBox ram_text_box;
        private System.Windows.Forms.TextBox vm_text_box;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hdd_text_box;
    }
}