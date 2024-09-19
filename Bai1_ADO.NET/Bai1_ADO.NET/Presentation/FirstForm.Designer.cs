namespace Bai1_ADO.NET.Presentation
{
    partial class FirstForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bt_confirm = new Button();
            nud_cowAmount = new NumericUpDown();
            nud_sheepAmount = new NumericUpDown();
            nud_goatAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_cowAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_sheepAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_goatAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhập số lượng vật nuôi ban đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(76, 53);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "Số lượng Bò:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(68, 90);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Số lượng Cừu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(76, 128);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 2;
            label4.Text = "Số lượng Dê:";
            // 
            // bt_confirm
            // 
            bt_confirm.Location = new Point(102, 165);
            bt_confirm.Name = "bt_confirm";
            bt_confirm.Size = new Size(109, 35);
            bt_confirm.TabIndex = 3;
            bt_confirm.Text = "Xác nhận";
            bt_confirm.UseVisualStyleBackColor = true;
            bt_confirm.Click += bt_confirm_Click;
            // 
            // nud_cowAmount
            // 
            nud_cowAmount.Location = new Point(159, 51);
            nud_cowAmount.Name = "nud_cowAmount";
            nud_cowAmount.Size = new Size(70, 23);
            nud_cowAmount.TabIndex = 4;
            // 
            // nud_sheepAmount
            // 
            nud_sheepAmount.Location = new Point(159, 88);
            nud_sheepAmount.Name = "nud_sheepAmount";
            nud_sheepAmount.Size = new Size(70, 23);
            nud_sheepAmount.TabIndex = 4;
            // 
            // nud_goatAmount
            // 
            nud_goatAmount.Location = new Point(159, 126);
            nud_goatAmount.Name = "nud_goatAmount";
            nud_goatAmount.Size = new Size(70, 23);
            nud_goatAmount.TabIndex = 4;
            // 
            // FirstForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 212);
            Controls.Add(nud_goatAmount);
            Controls.Add(nud_sheepAmount);
            Controls.Add(nud_cowAmount);
            Controls.Add(bt_confirm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FirstForm";
            Text = "Quản lý nông trại vật nuôi - 21521003";
            ((System.ComponentModel.ISupportInitialize)nud_cowAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_sheepAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_goatAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bt_confirm;
        private NumericUpDown nud_cowAmount;
        private NumericUpDown nud_sheepAmount;
        private NumericUpDown nud_goatAmount;
    }
}