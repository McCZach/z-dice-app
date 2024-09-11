namespace D_D_Dice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnD4 = new Button();
            btnD6 = new Button();
            btnD8 = new Button();
            btnD10 = new Button();
            btnD12 = new Button();
            btnD20 = new Button();
            SuspendLayout();
            // 
            // btnD4
            // 
            btnD4.Image = Properties.Resources.d4;
            btnD4.Location = new Point(12, 14);
            btnD4.Margin = new Padding(3, 100, 3, 3);
            btnD4.Name = "btnD4";
            btnD4.Padding = new Padding(10, 0, 0, 0);
            btnD4.Size = new Size(76, 80);
            btnD4.TabIndex = 0;
            btnD4.UseVisualStyleBackColor = true;
            // 
            // btnD6
            // 
            btnD6.Image = Properties.Resources.d6;
            btnD6.Location = new Point(148, 14);
            btnD6.Margin = new Padding(3, 100, 3, 3);
            btnD6.Name = "btnD6";
            btnD6.Padding = new Padding(10, 0, 0, 0);
            btnD6.Size = new Size(80, 80);
            btnD6.TabIndex = 1;
            btnD6.UseVisualStyleBackColor = true;
            // 
            // btnD8
            // 
            btnD8.Image = Properties.Resources.d8;
            btnD8.Location = new Point(286, 14);
            btnD8.Margin = new Padding(3, 100, 3, 3);
            btnD8.Name = "btnD8";
            btnD8.Padding = new Padding(5, 0, 0, 0);
            btnD8.Size = new Size(80, 80);
            btnD8.TabIndex = 2;
            btnD8.UseVisualStyleBackColor = true;
            // 
            // btnD10
            // 
            btnD10.Image = Properties.Resources.d10;
            btnD10.Location = new Point(423, 14);
            btnD10.Margin = new Padding(3, 100, 3, 3);
            btnD10.Name = "btnD10";
            btnD10.Padding = new Padding(1, 0, 0, 0);
            btnD10.Size = new Size(80, 80);
            btnD10.TabIndex = 3;
            btnD10.UseVisualStyleBackColor = true;
            // 
            // btnD12
            // 
            btnD12.Image = Properties.Resources.d12;
            btnD12.Location = new Point(566, 14);
            btnD12.Margin = new Padding(3, 100, 3, 3);
            btnD12.Name = "btnD12";
            btnD12.Padding = new Padding(1, 0, 0, 0);
            btnD12.Size = new Size(80, 80);
            btnD12.TabIndex = 4;
            btnD12.UseVisualStyleBackColor = true;
            // 
            // btnD20
            // 
            btnD20.Image = (Image)resources.GetObject("btnD20.Image");
            btnD20.Location = new Point(709, 14);
            btnD20.Margin = new Padding(3, 100, 3, 3);
            btnD20.Name = "btnD20";
            btnD20.Padding = new Padding(1, 0, 0, 0);
            btnD20.Size = new Size(80, 80);
            btnD20.TabIndex = 5;
            btnD20.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 600);
            Controls.Add(btnD20);
            Controls.Add(btnD12);
            Controls.Add(btnD10);
            Controls.Add(btnD8);
            Controls.Add(btnD6);
            Controls.Add(btnD4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Dice Roller";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnD4;
        private Button btnD6;
        private Button btnD8;
        private Button btnD10;
        private Button btnD12;
        private Button btnD20;
    }
}
