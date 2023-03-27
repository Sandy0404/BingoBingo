namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl亂數1 = new System.Windows.Forms.Label();
            this.lbl亂數2 = new System.Windows.Forms.Label();
            this.lbl亂數3 = new System.Windows.Forms.Label();
            this.產生號碼 = new System.Windows.Forms.Button();
            this.txtOutpute = new System.Windows.Forms.TextBox();
            this.txt樂透1 = new System.Windows.Forms.TextBox();
            this.txt樂透2 = new System.Windows.Forms.TextBox();
            this.txt樂透3 = new System.Windows.Forms.TextBox();
            this.btn兌獎 = new System.Windows.Forms.Button();
            this.lbl1回應訊息 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn產生號碼 = new System.Windows.Forms.Button();
            this.lbl產生號碼 = new System.Windows.Forms.TextBox();
            this.textBox包牌 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn開獎結果 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn停止產生號碼 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl亂數1
            // 
            this.lbl亂數1.AutoSize = true;
            this.lbl亂數1.BackColor = System.Drawing.Color.White;
            this.lbl亂數1.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl亂數1.Location = new System.Drawing.Point(12, 42);
            this.lbl亂數1.Name = "lbl亂數1";
            this.lbl亂數1.Size = new System.Drawing.Size(31, 35);
            this.lbl亂數1.TabIndex = 0;
            this.lbl亂數1.Text = "0";
            // 
            // lbl亂數2
            // 
            this.lbl亂數2.AutoSize = true;
            this.lbl亂數2.BackColor = System.Drawing.Color.White;
            this.lbl亂數2.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl亂數2.Location = new System.Drawing.Point(72, 42);
            this.lbl亂數2.Name = "lbl亂數2";
            this.lbl亂數2.Size = new System.Drawing.Size(31, 35);
            this.lbl亂數2.TabIndex = 1;
            this.lbl亂數2.Text = "0";
            // 
            // lbl亂數3
            // 
            this.lbl亂數3.AutoSize = true;
            this.lbl亂數3.BackColor = System.Drawing.Color.White;
            this.lbl亂數3.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl亂數3.Location = new System.Drawing.Point(135, 42);
            this.lbl亂數3.Name = "lbl亂數3";
            this.lbl亂數3.Size = new System.Drawing.Size(31, 35);
            this.lbl亂數3.TabIndex = 2;
            this.lbl亂數3.Text = "0";
            // 
            // 產生號碼
            // 
            this.產生號碼.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.產生號碼.Location = new System.Drawing.Point(194, 39);
            this.產生號碼.Name = "產生號碼";
            this.產生號碼.Size = new System.Drawing.Size(170, 38);
            this.產生號碼.TabIndex = 3;
            this.產生號碼.Text = "產生號碼";
            this.產生號碼.UseVisualStyleBackColor = true;
            this.產生號碼.Click += new System.EventHandler(this.產生亂數_Click);
            // 
            // txtOutpute
            // 
            this.txtOutpute.Location = new System.Drawing.Point(12, 150);
            this.txtOutpute.Multiline = true;
            this.txtOutpute.Name = "txtOutpute";
            this.txtOutpute.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutpute.Size = new System.Drawing.Size(352, 93);
            this.txtOutpute.TabIndex = 4;
            // 
            // txt樂透1
            // 
            this.txt樂透1.Location = new System.Drawing.Point(8, 308);
            this.txt樂透1.Name = "txt樂透1";
            this.txt樂透1.Size = new System.Drawing.Size(45, 22);
            this.txt樂透1.TabIndex = 5;
            // 
            // txt樂透2
            // 
            this.txt樂透2.Location = new System.Drawing.Point(83, 308);
            this.txt樂透2.Name = "txt樂透2";
            this.txt樂透2.Size = new System.Drawing.Size(50, 22);
            this.txt樂透2.TabIndex = 6;
            // 
            // txt樂透3
            // 
            this.txt樂透3.Location = new System.Drawing.Point(165, 308);
            this.txt樂透3.Name = "txt樂透3";
            this.txt樂透3.Size = new System.Drawing.Size(59, 22);
            this.txt樂透3.TabIndex = 7;
            // 
            // btn兌獎
            // 
            this.btn兌獎.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn兌獎.Location = new System.Drawing.Point(246, 303);
            this.btn兌獎.Name = "btn兌獎";
            this.btn兌獎.Size = new System.Drawing.Size(95, 36);
            this.btn兌獎.TabIndex = 8;
            this.btn兌獎.Text = "兌獎";
            this.btn兌獎.UseVisualStyleBackColor = true;
            this.btn兌獎.Click += new System.EventHandler(this.btn兌獎_Click);
            // 
            // lbl1回應訊息
            // 
            this.lbl1回應訊息.BackColor = System.Drawing.Color.White;
            this.lbl1回應訊息.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl1回應訊息.Location = new System.Drawing.Point(9, 348);
            this.lbl1回應訊息.Name = "lbl1回應訊息";
            this.lbl1回應訊息.Size = new System.Drawing.Size(355, 73);
            this.lbl1回應訊息.TabIndex = 9;
            this.lbl1回應訊息.Text = "輸入號碼進行兌獎";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(38, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "輸入BINGO BINGO賓果賓果號碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(38, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "產生BINGO BINGO賓果賓果號碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(517, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "包牌號碼";
            // 
            // btn產生號碼
            // 
            this.btn產生號碼.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn產生號碼.Location = new System.Drawing.Point(561, 303);
            this.btn產生號碼.Name = "btn產生號碼";
            this.btn產生號碼.Size = new System.Drawing.Size(104, 28);
            this.btn產生號碼.TabIndex = 14;
            this.btn產生號碼.Text = "產生號碼";
            this.btn產生號碼.UseVisualStyleBackColor = true;
            this.btn產生號碼.Click += new System.EventHandler(this.btn產生號碼_Click);
            // 
            // lbl產生號碼
            // 
            this.lbl產生號碼.Location = new System.Drawing.Point(410, 336);
            this.lbl產生號碼.Multiline = true;
            this.lbl產生號碼.Name = "lbl產生號碼";
            this.lbl產生號碼.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbl產生號碼.Size = new System.Drawing.Size(303, 87);
            this.lbl產生號碼.TabIndex = 15;
            // 
            // textBox包牌
            // 
            this.textBox包牌.Location = new System.Drawing.Point(496, 307);
            this.textBox包牌.Name = "textBox包牌";
            this.textBox包牌.Size = new System.Drawing.Size(52, 22);
            this.textBox包牌.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(417, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "包牌數量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(500, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "本期開獎號碼";
            // 
            // btn開獎結果
            // 
            this.btn開獎結果.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn開獎結果.Location = new System.Drawing.Point(504, 188);
            this.btn開獎結果.Name = "btn開獎結果";
            this.btn開獎結果.Size = new System.Drawing.Size(115, 37);
            this.btn開獎結果.TabIndex = 23;
            this.btn開獎結果.Text = "開獎結果";
            this.btn開獎結果.UseVisualStyleBackColor = true;
            this.btn開獎結果.Click += new System.EventHandler(this.btn開獎結果_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(632, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 64);
            this.label6.TabIndex = 22;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(532, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 64);
            this.label7.TabIndex = 21;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(429, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 64);
            this.label8.TabIndex = 20;
            this.label8.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(122, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "5秒產生一組";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn5秒產生一組_Click);
            // 
            // btn停止產生號碼
            // 
            this.btn停止產生號碼.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn停止產生號碼.Location = new System.Drawing.Point(245, 95);
            this.btn停止產生號碼.Name = "btn停止產生號碼";
            this.btn停止產生號碼.Size = new System.Drawing.Size(117, 38);
            this.btn停止產生號碼.TabIndex = 25;
            this.btn停止產生號碼.Text = "停止產生號碼";
            this.btn停止產生號碼.UseVisualStyleBackColor = true;
            this.btn停止產生號碼.Click += new System.EventHandler(this.btn停止產生號碼_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(728, 434);
            this.Controls.Add(this.btn停止產生號碼);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn開獎結果);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox包牌);
            this.Controls.Add(this.lbl產生號碼);
            this.Controls.Add(this.btn產生號碼);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1回應訊息);
            this.Controls.Add(this.btn兌獎);
            this.Controls.Add(this.txt樂透3);
            this.Controls.Add(this.txt樂透2);
            this.Controls.Add(this.txt樂透1);
            this.Controls.Add(this.txtOutpute);
            this.Controls.Add(this.產生號碼);
            this.Controls.Add(this.lbl亂數3);
            this.Controls.Add(this.lbl亂數2);
            this.Controls.Add(this.lbl亂數1);
            this.Name = "Form1";
            this.Text = "BINGO BINGO賓果賓果";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl亂數1;
        private System.Windows.Forms.Label lbl亂數2;
        private System.Windows.Forms.Label lbl亂數3;
        private System.Windows.Forms.Button 產生號碼;
        private System.Windows.Forms.TextBox txtOutpute;
        private System.Windows.Forms.TextBox txt樂透1;
        private System.Windows.Forms.TextBox txt樂透2;
        private System.Windows.Forms.TextBox txt樂透3;
        private System.Windows.Forms.Button btn兌獎;
        private System.Windows.Forms.Label lbl1回應訊息;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn產生號碼;
        private System.Windows.Forms.TextBox lbl產生號碼;
        private System.Windows.Forms.TextBox textBox包牌;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn開獎結果;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn停止產生號碼;
    }
}

