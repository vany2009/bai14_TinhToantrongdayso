namespace bai14_TinhToantrongdayso
{
    partial class Form1
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
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttongle = new System.Windows.Forms.TextBox();
            this.txttongchan = new System.Windows.Forms.TextBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(64, 43);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 0;
            this.txtso1.Text = "1";
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(64, 111);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 0;
            this.txtso2.Text = "10";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(163, 216);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(285, 59);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng chẵn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "tổng lẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng";
            // 
            // txttongle
            // 
            this.txttongle.Location = new System.Drawing.Point(438, 97);
            this.txttongle.Name = "txttongle";
            this.txttongle.Size = new System.Drawing.Size(100, 20);
            this.txttongle.TabIndex = 3;
            // 
            // txttongchan
            // 
            this.txttongchan.Location = new System.Drawing.Point(438, 40);
            this.txttongchan.Name = "txttongchan";
            this.txttongchan.Size = new System.Drawing.Size(100, 20);
            this.txttongchan.TabIndex = 3;
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(438, 153);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(100, 20);
            this.txttong.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.txttongchan);
            this.Controls.Add(this.txttongle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttongle;
        private System.Windows.Forms.TextBox txttongchan;
        private System.Windows.Forms.TextBox txttong;
    }
}

