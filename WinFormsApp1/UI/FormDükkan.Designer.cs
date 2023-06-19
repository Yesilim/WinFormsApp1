namespace WinFormsApp1.UI
{
    partial class FormDükkan
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
            this.txtişcisay = new System.Windows.Forms.TextBox();
            this.txtadr = new System.Windows.Forms.TextBox();
            this.txtpaket = new System.Windows.Forms.TextBox();
            this.txtmüd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttelno = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(114, 240);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(94, 29);
            this.btniptal.TabIndex = 15;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(342, 240);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 29);
            this.btnkaydet.TabIndex = 17;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtişcisay
            // 
            this.txtişcisay.Location = new System.Drawing.Point(135, 132);
            this.txtişcisay.Name = "txtişcisay";
            this.txtişcisay.Size = new System.Drawing.Size(73, 27);
            this.txtişcisay.TabIndex = 12;
            // 
            // txtadr
            // 
            this.txtadr.Location = new System.Drawing.Point(135, 93);
            this.txtadr.Name = "txtadr";
            this.txtadr.Size = new System.Drawing.Size(322, 27);
            this.txtadr.TabIndex = 11;
            // 
            // txtpaket
            // 
            this.txtpaket.Location = new System.Drawing.Point(135, 59);
            this.txtpaket.Name = "txtpaket";
            this.txtpaket.Size = new System.Drawing.Size(322, 27);
            this.txtpaket.TabIndex = 10;
            // 
            // txtmüd
            // 
            this.txtmüd.Location = new System.Drawing.Point(135, 26);
            this.txtmüd.Name = "txtmüd";
            this.txtmüd.ReadOnly = true;
            this.txtmüd.Size = new System.Drawing.Size(134, 27);
            this.txtmüd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefon Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "İşçi Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "PaketAdı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Müdür";
            // 
            // txttelno
            // 
            this.txttelno.Location = new System.Drawing.Point(135, 172);
            this.txttelno.Mask = "\\0(599) 000-0000";
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(125, 27);
            this.txttelno.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormDükkan
            // 
            this.AcceptButton = this.btnkaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(468, 299);
            this.Controls.Add(this.txttelno);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtişcisay);
            this.Controls.Add(this.txtadr);
            this.Controls.Add(this.txtpaket);
            this.Controls.Add(this.txtmüd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormDükkan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDükkan";
            this.Load += new System.EventHandler(this.FormDükkan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btniptal;
        private Button btnkaydet;
        private TextBox txtişcisay;
        private TextBox txtadr;
        private TextBox txtpaket;
        private TextBox txtmüd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox txttelno;
        private ErrorProvider errorProvider1;
    }
}