namespace WinFormsApp1.UI
{
    partial class Formulasım
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
            this.txtsoför = new System.Windows.Forms.TextBox();
            this.txtvarıs = new System.Windows.Forms.TextBox();
            this.txtkalkıs = new System.Windows.Forms.TextBox();
            this.txtarno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtulas = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(33, 220);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(94, 29);
            this.btniptal.TabIndex = 15;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(244, 220);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 29);
            this.btnkaydet.TabIndex = 17;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtsoför
            // 
            this.txtsoför.Location = new System.Drawing.Point(111, 149);
            this.txtsoför.Name = "txtsoför";
            this.txtsoför.Size = new System.Drawing.Size(151, 27);
            this.txtsoför.TabIndex = 13;
            // 
            // txtvarıs
            // 
            this.txtvarıs.Location = new System.Drawing.Point(111, 112);
            this.txtvarıs.Name = "txtvarıs";
            this.txtvarıs.Size = new System.Drawing.Size(83, 27);
            this.txtvarıs.TabIndex = 12;
            // 
            // txtkalkıs
            // 
            this.txtkalkıs.Location = new System.Drawing.Point(111, 73);
            this.txtkalkıs.Name = "txtkalkıs";
            this.txtkalkıs.Size = new System.Drawing.Size(83, 27);
            this.txtkalkıs.TabIndex = 11;
            // 
            // txtarno
            // 
            this.txtarno.Location = new System.Drawing.Point(111, 6);
            this.txtarno.Name = "txtarno";
            this.txtarno.ReadOnly = true;
            this.txtarno.Size = new System.Drawing.Size(83, 27);
            this.txtarno.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şoför Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Varış Şehri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kalkış Şehri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ulaşım Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Araç Numarası";
            // 
            // txtulas
            // 
            this.txtulas.FormattingEnabled = true;
            this.txtulas.Items.AddRange(new object[] {
            "Tır",
            "Kamyon",
            "Ticari",
            "Tren",
            "Uçak"});
            this.txtulas.Location = new System.Drawing.Point(111, 39);
            this.txtulas.Name = "txtulas";
            this.txtulas.Size = new System.Drawing.Size(151, 28);
            this.txtulas.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Formulasım
            // 
            this.AcceptButton = this.btnkaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(373, 299);
            this.Controls.Add(this.txtulas);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtsoför);
            this.Controls.Add(this.txtvarıs);
            this.Controls.Add(this.txtkalkıs);
            this.Controls.Add(this.txtarno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Formulasım";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulasım";
            this.Load += new System.EventHandler(this.Formulasım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btniptal;
        private Button btnkaydet;
        private TextBox txtsoför;
        private TextBox txtvarıs;
        private TextBox txtkalkıs;
        private TextBox txtarno;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox txtulas;
        private ErrorProvider errorProvider1;
    }
}