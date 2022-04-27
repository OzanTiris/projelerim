
namespace proje
{
    partial class Form2
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
            this.takımisim = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.oyuncu = new System.Windows.Forms.DataGridView();
            this.txtoyuncu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu)).BeginInit();
            this.SuspendLayout();
            // 
            // takımisim
            // 
            this.takımisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.takımisim.FormattingEnabled = true;
            this.takımisim.ItemHeight = 37;
            this.takımisim.Location = new System.Drawing.Point(31, 12);
            this.takımisim.Name = "takımisim";
            this.takımisim.Size = new System.Drawing.Size(207, 337);
            this.takımisim.TabIndex = 5;
            this.takımisim.SelectedIndexChanged += new System.EventHandler(this.takımisim_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(31, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "takımgetir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oyuncu
            // 
            this.oyuncu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oyuncu.Location = new System.Drawing.Point(284, 118);
            this.oyuncu.Name = "oyuncu";
            this.oyuncu.Size = new System.Drawing.Size(504, 231);
            this.oyuncu.TabIndex = 7;
            this.oyuncu.SelectionChanged += new System.EventHandler(this.oyuncu_SelectionChanged);
            // 
            // txtoyuncu
            // 
            this.txtoyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtoyuncu.Location = new System.Drawing.Point(332, 40);
            this.txtoyuncu.Name = "txtoyuncu";
            this.txtoyuncu.Size = new System.Drawing.Size(401, 29);
            this.txtoyuncu.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtoyuncu);
            this.Controls.Add(this.oyuncu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.takımisim);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox takımisim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView oyuncu;
        private System.Windows.Forms.TextBox txtoyuncu;
    }
}