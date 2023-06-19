namespace WinFormsApp1.UI
{
    partial class Formdenetmen
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
            this.components = new System.ComponentModel.Container();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtpozi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpoz = new System.Windows.Forms.Label();
            this.txttarih = new System.Windows.Forms.MaskedTextBox();
            this.txtmaas = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(114, 220);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(94, 29);
            this.btniptal.TabIndex = 15;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(342, 220);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 29);
            this.btnkaydet.TabIndex = 17;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(114, 73);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(83, 27);
            this.txtsoyad.TabIndex = 11;
            this.txtsoyad.TextChanged += new System.EventHandler(this.txtdugme_TextChanged);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(114, 39);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(164, 27);
            this.txtad.TabIndex = 10;
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // txtpozi
            // 
            this.txtpozi.Location = new System.Drawing.Point(114, 6);
            this.txtpozi.Name = "txtpozi";
            this.txtpozi.ReadOnly = true;
            this.txtpozi.Size = new System.Drawing.Size(83, 27);
            this.txtpozi.TabIndex = 9;
            this.txtpozi.TextChanged += new System.EventHandler(this.txtKod_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "İşe Giriş Tarihi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Maaş";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Soyad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpoz
            // 
            this.txtpoz.AutoSize = true;
            this.txtpoz.Location = new System.Drawing.Point(37, 9);
            this.txtpoz.Name = "txtpoz";
            this.txtpoz.Size = new System.Drawing.Size(66, 20);
            this.txtpoz.TabIndex = 20;
            this.txtpoz.Text = "Pozisyon";
            this.txtpoz.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(117, 149);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(125, 27);
            this.txttarih.TabIndex = 21;
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(117, 112);
            this.txtmaas.Mask = "00000";
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(125, 27);
            this.txtmaas.TabIndex = 22;
            this.txtmaas.ValidatingType = typeof(int);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Formdenetmen
            // 
            this.AcceptButton = this.btnkaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(466, 277);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.txttarih);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtpozi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpoz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Formdenetmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formdenetmen";
            this.Load += new System.EventHandler(this.Formdenetmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btniptal;
        private Button btnkaydet;
        private TextBox txtsoyad;
        private TextBox txtad;
        private TextBox txtpozi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label txtpoz;
        private MaskedTextBox txttarih;
        private MaskedTextBox txtmaas;
        private ErrorProvider errorProvider1;
    }
}