
namespace sınav_2.dönem
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
            this.txtvalue4 = new System.Windows.Forms.TextBox();
            this.txtvalue2 = new System.Windows.Forms.TextBox();
            this.txtvalue1 = new System.Windows.Forms.TextBox();
            this.txtvalue3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblsonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtvalue4
            // 
            this.txtvalue4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtvalue4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtvalue4.Location = new System.Drawing.Point(407, 143);
            this.txtvalue4.Name = "txtvalue4";
            this.txtvalue4.Size = new System.Drawing.Size(99, 38);
            this.txtvalue4.TabIndex = 0;
            // 
            // txtvalue2
            // 
            this.txtvalue2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtvalue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtvalue2.Location = new System.Drawing.Point(67, 143);
            this.txtvalue2.Name = "txtvalue2";
            this.txtvalue2.Size = new System.Drawing.Size(98, 38);
            this.txtvalue2.TabIndex = 1;
            // 
            // txtvalue1
            // 
            this.txtvalue1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtvalue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtvalue1.Location = new System.Drawing.Point(67, 12);
            this.txtvalue1.Name = "txtvalue1";
            this.txtvalue1.Size = new System.Drawing.Size(98, 38);
            this.txtvalue1.TabIndex = 2;
            // 
            // txtvalue3
            // 
            this.txtvalue3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtvalue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtvalue3.Location = new System.Drawing.Point(407, 12);
            this.txtvalue3.Name = "txtvalue3";
            this.txtvalue3.Size = new System.Drawing.Size(99, 38);
            this.txtvalue3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(270, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(368, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "________";
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(89, 201);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(417, 53);
            this.btnhesapla.TabIndex = 7;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(24, 270);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(718, 168);
            this.dgv.TabIndex = 8;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsonuc.Location = new System.Drawing.Point(613, 78);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(113, 31);
            this.lblsonuc.TabIndex = 9;
            this.lblsonuc.Text = "SONUÇ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalue3);
            this.Controls.Add(this.txtvalue1);
            this.Controls.Add(this.txtvalue2);
            this.Controls.Add(this.txtvalue4);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalue4;
        private System.Windows.Forms.TextBox txtvalue2;
        private System.Windows.Forms.TextBox txtvalue1;
        private System.Windows.Forms.TextBox txtvalue3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblsonuc;
    }
}

