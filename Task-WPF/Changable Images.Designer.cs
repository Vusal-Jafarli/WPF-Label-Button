namespace Task_WPF
{
    partial class Changable_Images
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
            button_baku = new Button();
            button_london = new Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button_baku
            // 
            button_baku.Location = new Point(180, 169);
            button_baku.Name = "button_baku";
            button_baku.Size = new Size(150, 70);
            button_baku.TabIndex = 0;
            button_baku.Text = "BAKU";
            button_baku.UseVisualStyleBackColor = true;
            button_baku.MouseClick += Baku_click;
            // 
            // button_london
            // 
            button_london.Location = new Point(431, 169);
            button_london.Name = "button_london";
            button_london.Size = new Size(150, 70);
            button_london.TabIndex = 1;
            button_london.Text = "LONDON";
            button_london.UseVisualStyleBackColor = true;
            button_london.MouseClick += London_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(313, 77);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Changable_Images
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button_london);
            Controls.Add(button_baku);
            Name = "Changable_Images";
            Text = "Changable_Images";
            Load += Changable_Images_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_baku;
        private Button button_london;
        private System.Windows.Forms.Label label1;
    }
}