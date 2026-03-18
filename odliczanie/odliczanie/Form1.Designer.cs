namespace odliczanie
{
    partial class Form1
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
            tabControl1 = new TabControl();
            Minutnik = new TabPage();
            Stoper = new TabPage();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tabControl1.SuspendLayout();
            Minutnik.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Minutnik);
            tabControl1.Controls.Add(Stoper);
            tabControl1.Location = new Point(40, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(732, 383);
            tabControl1.TabIndex = 0;
            // 
            // Minutnik
            // 
            Minutnik.Controls.Add(textBox2);
            Minutnik.Controls.Add(textBox1);
            Minutnik.Location = new Point(4, 24);
            Minutnik.Name = "Minutnik";
            Minutnik.Padding = new Padding(3);
            Minutnik.Size = new Size(724, 355);
            Minutnik.TabIndex = 0;
            Minutnik.Text = "Minutnik";
            Minutnik.UseVisualStyleBackColor = true;
            // 
            // Stoper
            // 
            Stoper.Location = new Point(4, 24);
            Stoper.Name = "Stoper";
            Stoper.Padding = new Padding(3);
            Stoper.Size = new Size(317, 197);
            Stoper.TabIndex = 1;
            Stoper.Text = "Stoper";
            Stoper.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(92, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(335, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(92, 23);
            textBox2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Minutnik.ResumeLayout(false);
            Minutnik.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Minutnik;
        private TabPage Stoper;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
