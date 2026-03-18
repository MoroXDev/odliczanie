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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            Minutnik = new TabPage();
            reset_btn1 = new Button();
            stop_btn1 = new Button();
            start_btn1 = new Button();
            timer_label1 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Stoper = new TabPage();
            reset_btn2 = new Button();
            stop_btn2 = new Button();
            start_btn2 = new Button();
            timer_label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            Minutnik.SuspendLayout();
            Stoper.SuspendLayout();
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
            Minutnik.Controls.Add(reset_btn1);
            Minutnik.Controls.Add(stop_btn1);
            Minutnik.Controls.Add(start_btn1);
            Minutnik.Controls.Add(timer_label1);
            Minutnik.Controls.Add(label2);
            Minutnik.Controls.Add(label1);
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
            // reset_btn1
            // 
            reset_btn1.Location = new Point(309, 161);
            reset_btn1.Name = "reset_btn1";
            reset_btn1.Size = new Size(75, 23);
            reset_btn1.TabIndex = 7;
            reset_btn1.Text = "reset";
            reset_btn1.UseVisualStyleBackColor = true;
            reset_btn1.Click += reset_btn1_Click;
            // 
            // stop_btn1
            // 
            stop_btn1.Location = new Point(411, 161);
            stop_btn1.Name = "stop_btn1";
            stop_btn1.Size = new Size(75, 23);
            stop_btn1.TabIndex = 6;
            stop_btn1.Text = "stop";
            stop_btn1.UseVisualStyleBackColor = true;
            stop_btn1.Click += stop_btn1_Click;
            // 
            // start_btn1
            // 
            start_btn1.Location = new Point(203, 161);
            start_btn1.Name = "start_btn1";
            start_btn1.Size = new Size(75, 23);
            start_btn1.TabIndex = 5;
            start_btn1.Text = "start";
            start_btn1.UseVisualStyleBackColor = true;
            start_btn1.Click += start_btn1_Click;
            // 
            // timer_label1
            // 
            timer_label1.AutoSize = true;
            timer_label1.Font = new Font("Segoe UI", 30F);
            timer_label1.Location = new Point(289, 254);
            timer_label1.Name = "timer_label1";
            timer_label1.Size = new Size(120, 54);
            timer_label1.TabIndex = 4;
            timer_label1.Text = "00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 84);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Sekundy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 84);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Minuty";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(411, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(92, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(92, 23);
            textBox1.TabIndex = 0;
            // 
            // Stoper
            // 
            Stoper.Controls.Add(reset_btn2);
            Stoper.Controls.Add(stop_btn2);
            Stoper.Controls.Add(start_btn2);
            Stoper.Controls.Add(timer_label2);
            Stoper.Location = new Point(4, 24);
            Stoper.Name = "Stoper";
            Stoper.Padding = new Padding(3);
            Stoper.Size = new Size(724, 355);
            Stoper.TabIndex = 1;
            Stoper.Text = "Stoper";
            Stoper.UseVisualStyleBackColor = true;
            // 
            // reset_btn2
            // 
            reset_btn2.Location = new Point(459, 68);
            reset_btn2.Name = "reset_btn2";
            reset_btn2.Size = new Size(75, 23);
            reset_btn2.TabIndex = 3;
            reset_btn2.Text = "reset";
            reset_btn2.UseVisualStyleBackColor = true;
            reset_btn2.Click += reset_btn2_Click;
            // 
            // stop_btn2
            // 
            stop_btn2.Location = new Point(322, 68);
            stop_btn2.Name = "stop_btn2";
            stop_btn2.Size = new Size(75, 23);
            stop_btn2.TabIndex = 2;
            stop_btn2.Text = "stop";
            stop_btn2.UseVisualStyleBackColor = true;
            stop_btn2.Click += stop_btn2_Click;
            // 
            // start_btn2
            // 
            start_btn2.Location = new Point(170, 68);
            start_btn2.Name = "start_btn2";
            start_btn2.Size = new Size(75, 23);
            start_btn2.TabIndex = 1;
            start_btn2.Text = "start";
            start_btn2.UseVisualStyleBackColor = true;
            start_btn2.Click += start_btn2_Click;
            // 
            // timer_label2
            // 
            timer_label2.AutoSize = true;
            timer_label2.Font = new Font("Segoe UI", 30F);
            timer_label2.Location = new Point(297, 208);
            timer_label2.Name = "timer_label2";
            timer_label2.Size = new Size(120, 54);
            timer_label2.TabIndex = 0;
            timer_label2.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
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
            Stoper.ResumeLayout(false);
            Stoper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        int seconds_time1 = 0;
        int seconds_time2 = 0;

        private TabControl tabControl1;
        private TabPage Minutnik;
        private TabPage Stoper;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button stop_btn1;
        private Button start_btn1;
        private Label timer_label1;
        private Button reset_btn1;
        private Button reset_btn2;
        private Button stop_btn2;
        private Button start_btn2;
        private Label timer_label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
