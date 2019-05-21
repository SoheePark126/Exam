namespace TeaBagMaker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.teaList1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.btnMake = new System.Windows.Forms.Button();
            this.time2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // teaList1
            // 
            this.teaList1.FormattingEnabled = true;
            this.teaList1.Location = new System.Drawing.Point(13, 13);
            this.teaList1.Name = "teaList1";
            this.teaList1.Size = new System.Drawing.Size(179, 20);
            this.teaList1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "2019.05.21 3606 박소희";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(13, 46);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(41, 12);
            this.time1.TabIndex = 2;
            this.time1.Text = "시간 : ";
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(12, 94);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(75, 23);
            this.btnMake.TabIndex = 3;
            this.btnMake.Text = "담그기!";
            this.btnMake.UseVisualStyleBackColor = true;
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(13, 69);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(69, 12);
            this.time2.TabIndex = 4;
            this.time2.Text = "남은 시간 : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 21);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 184);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teaList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teaList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

