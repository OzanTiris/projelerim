
namespace formm_5_quizz_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.K = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.SAYAÇ = new System.Windows.Forms.Button();
            this.SÜRE = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // K
            // 
            this.K.BackColor = System.Drawing.Color.Black;
            this.K.Location = new System.Drawing.Point(187, 12);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(112, 85);
            this.K.TabIndex = 0;
            this.K.UseVisualStyleBackColor = false;
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.S.Location = new System.Drawing.Point(187, 102);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(112, 84);
            this.S.TabIndex = 1;
            this.S.UseVisualStyleBackColor = false;
            // 
            // Y
            // 
            this.Y.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Y.Location = new System.Drawing.Point(187, 192);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(112, 85);
            this.Y.TabIndex = 2;
            this.Y.UseVisualStyleBackColor = false;
            // 
            // SAYAÇ
            // 
            this.SAYAÇ.Location = new System.Drawing.Point(146, 283);
            this.SAYAÇ.Name = "SAYAÇ";
            this.SAYAÇ.Size = new System.Drawing.Size(203, 116);
            this.SAYAÇ.TabIndex = 3;
            this.SAYAÇ.UseVisualStyleBackColor = true;
            // 
            // SÜRE
            // 
            this.SÜRE.Tick += new System.EventHandler(this.SÜRE_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SAYAÇ);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.S);
            this.Controls.Add(this.K);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button K;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button Y;
        private System.Windows.Forms.Button SAYAÇ;
        private System.Windows.Forms.Timer SÜRE;
    }
}

