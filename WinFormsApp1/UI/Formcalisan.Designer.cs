namespace WinFormsApp1.UI
{
    partial class Formcalisan
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
            this.txttelno = new System.Windows.Forms.MaskedTextBox();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txttcno = new System.Windows.Forms.TextBox();
            this.txtissoy = new System.Windows.Forms.TextBox();
            this.txtisad = new System.Windows.Forms.TextBox();
            this.txtpozis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtvardi = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttelno
            // 
            this.txttelno.Location = new System.Drawing.Point(128, 187);
            this.txttelno.Mask = "\\0(599) 000-0000";
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(125, 27);
            this.txttelno.TabIndex = 33;
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(107, 308);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(94, 29);
            this.btniptal.TabIndex = 27;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(355, 308);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 29);
            this.btnkaydet.TabIndex = 29;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txttcno
            // 
            this.txttcno.Location = new System.Drawing.Point(128, 112);
            this.txttcno.Name = "txttcno";
            this.txttcno.Size = new System.Drawing.Size(73, 27);
            this.txttcno.TabIndex = 25;
            // 
            // txtissoy
            // 
            this.txtissoy.Location = new System.Drawing.Point(128, 73);
            this.txtissoy.Name = "txtissoy";
            this.txtissoy.Size = new System.Drawing.Size(322, 27);
            this.txtissoy.TabIndex = 24;
            // 
            // txtisad
            // 
            this.txtisad.Location = new System.Drawing.Point(128, 39);
            this.txtisad.Name = "txtisad";
            this.txtisad.Size = new System.Drawing.Size(322, 27);
            this.txtisad.TabIndex = 23;
            // 
            // txtpozis
            // 
            this.txtpozis.Location = new System.Drawing.Point(128, 6);
            this.txtpozis.Name = "txtpozis";
            this.txtpozis.ReadOnly = true;
            this.txtpozis.Size = new System.Drawing.Size(134, 27);
            this.txtpozis.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefon Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tc Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Pozisyon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Yaş";
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(128, 148);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(73, 27);
            this.txtyas.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Maaş";
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(128, 222);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(73, 27);
            this.txtmaas.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Vardıyalı Mı";
            // 
            // txtvardi
            // 
            this.txtvardi.FormattingEnabled = true;
            this.txtvardi.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.txtvardi.Location = new System.Drawing.Point(128, 255);
            this.txtvardi.Name = "txtvardi";
            this.txtvardi.Size = new System.Drawing.Size(151, 28);
            this.txtvardi.TabIndex = 34;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Formcalisan
            // 
            this.AcceptButton = this.btnkaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(461, 349);
            this.Controls.Add(this.txtvardi);
            this.Controls.Add(this.txttelno);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.txttcno);
            this.Controls.Add(this.txtissoy);
            this.Controls.Add(this.txtisad);
            this.Controls.Add(this.txtpozis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Formcalisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formcalisan";
            this.Load += new System.EventHandler(this.Formcalisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txttelno;
        private Button btniptal;
        private Button btnkaydet;
        private TextBox txttcno;
        private TextBox txtissoy;
        private TextBox txtisad;
        private TextBox txtpozis;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtyas;
        private Label label7;
        private TextBox txtmaas;
        private Label label8;
        private ComboBox txtvardi;
        private ErrorProvider errorProvider1;
    }
}