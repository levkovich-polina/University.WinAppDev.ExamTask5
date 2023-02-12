namespace Task5
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
            this.Panel = new System.Windows.Forms.Panel();
            this.RainButton = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.MinSpeedTextBox = new System.Windows.Forms.TextBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Location = new System.Drawing.Point(1, -1);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(802, 305);
            this.Panel.TabIndex = 0;
            // 
            // RainButton
            // 
            this.RainButton.Location = new System.Drawing.Point(601, 26);
            this.RainButton.Name = "RainButton";
            this.RainButton.Size = new System.Drawing.Size(175, 88);
            this.RainButton.TabIndex = 0;
            this.RainButton.Text = "Дождь!";
            this.RainButton.UseVisualStyleBackColor = true;
            this.RainButton.Click += new System.EventHandler(this.RainButton_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.MaxSpeedTextBox);
            this.GroupBox.Controls.Add(this.MinSpeedTextBox);
            this.GroupBox.Controls.Add(this.ColorButton);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.RainButton);
            this.GroupBox.Location = new System.Drawing.Point(1, 313);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(802, 125);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Управление";
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(321, 75);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(65, 27);
            this.MaxSpeedTextBox.TabIndex = 5;
            // 
            // MinSpeedTextBox
            // 
            this.MinSpeedTextBox.Location = new System.Drawing.Point(238, 75);
            this.MinSpeedTextBox.Name = "MinSpeedTextBox";
            this.MinSpeedTextBox.Size = new System.Drawing.Size(65, 27);
            this.MinSpeedTextBox.TabIndex = 4;
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.Silver;
            this.ColorButton.Location = new System.Drawing.Point(262, 26);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(41, 32);
            this.ColorButton.TabIndex = 3;
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Диапозон скорости капель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор цвета для произведения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Panel;
        private Button RainButton;
        private GroupBox GroupBox;
        private TextBox MaxSpeedTextBox;
        private TextBox MinSpeedTextBox;
        private Button ColorButton;
        private Label label2;
        private Label label1;
        private ColorDialog ColorDialog;
    }
}