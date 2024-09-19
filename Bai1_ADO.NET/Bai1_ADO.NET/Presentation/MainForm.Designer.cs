namespace Bai1_ADO.NET
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lb_cowCount = new Label();
            lb_sheepCount = new Label();
            lb_goatCount = new Label();
            label1 = new Label();
            label5 = new Label();
            lb_cowMilkVolume = new Label();
            lb_sheepMilkVolume = new Label();
            lb_goatMilkVolume = new Label();
            label6 = new Label();
            bt_hungry = new Button();
            bt_feed = new Button();
            rtb_sound = new RichTextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(95, 172);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 5;
            label4.Text = "Dê:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(87, 134);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Cừu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(95, 97);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "Bò:";
            // 
            // lb_cowCount
            // 
            lb_cowCount.AutoSize = true;
            lb_cowCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lb_cowCount.Location = new Point(162, 97);
            lb_cowCount.Name = "lb_cowCount";
            lb_cowCount.Size = new Size(13, 15);
            lb_cowCount.TabIndex = 8;
            lb_cowCount.Text = "0";
            // 
            // lb_sheepCount
            // 
            lb_sheepCount.AutoSize = true;
            lb_sheepCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lb_sheepCount.Location = new Point(162, 134);
            lb_sheepCount.Name = "lb_sheepCount";
            lb_sheepCount.Size = new Size(13, 15);
            lb_sheepCount.TabIndex = 8;
            lb_sheepCount.Text = "0";
            // 
            // lb_goatCount
            // 
            lb_goatCount.AutoSize = true;
            lb_goatCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lb_goatCount.Location = new Point(162, 172);
            lb_goatCount.Name = "lb_goatCount";
            lb_goatCount.Size = new Size(13, 15);
            lb_goatCount.TabIndex = 8;
            lb_goatCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.Location = new Point(146, 63);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 8;
            label1.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label5.Location = new Point(222, 63);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Số lít sữa";
            // 
            // lb_cowMilkVolume
            // 
            lb_cowMilkVolume.AutoSize = true;
            lb_cowMilkVolume.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lb_cowMilkVolume.Location = new Point(238, 97);
            lb_cowMilkVolume.Name = "lb_cowMilkVolume";
            lb_cowMilkVolume.Size = new Size(13, 15);
            lb_cowMilkVolume.TabIndex = 8;
            lb_cowMilkVolume.Text = "0";
            // 
            // lb_sheepMilkVolume
            // 
            lb_sheepMilkVolume.AutoSize = true;
            lb_sheepMilkVolume.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lb_sheepMilkVolume.Location = new Point(238, 134);
            lb_sheepMilkVolume.Name = "lb_sheepMilkVolume";
            lb_sheepMilkVolume.Size = new Size(13, 15);
            lb_sheepMilkVolume.TabIndex = 8;
            lb_sheepMilkVolume.Text = "0";
            // 
            // lb_goatMilkVolume
            // 
            lb_goatMilkVolume.AutoSize = true;
            lb_goatMilkVolume.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lb_goatMilkVolume.Location = new Point(238, 172);
            lb_goatMilkVolume.Name = "lb_goatMilkVolume";
            lb_goatMilkVolume.Size = new Size(13, 15);
            lb_goatMilkVolume.TabIndex = 8;
            lb_goatMilkVolume.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label6.Location = new Point(129, 9);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 9;
            label6.Text = "Thống kê";
            // 
            // bt_hungry
            // 
            bt_hungry.Location = new Point(360, 77);
            bt_hungry.Name = "bt_hungry";
            bt_hungry.Size = new Size(109, 35);
            bt_hungry.TabIndex = 10;
            bt_hungry.Text = "Gia súc đói";
            bt_hungry.UseVisualStyleBackColor = true;
            bt_hungry.Click += bt_hungry_Click;
            // 
            // bt_feed
            // 
            bt_feed.Location = new Point(360, 134);
            bt_feed.Name = "bt_feed";
            bt_feed.Size = new Size(109, 35);
            bt_feed.TabIndex = 10;
            bt_feed.Text = "Chăn nuôi";
            bt_feed.UseVisualStyleBackColor = true;
            bt_feed.Click += bt_feed_Click;
            // 
            // rtb_sound
            // 
            rtb_sound.Location = new Point(12, 207);
            rtb_sound.Name = "rtb_sound";
            rtb_sound.Size = new Size(493, 212);
            rtb_sound.TabIndex = 12;
            rtb_sound.Text = "Sự im lặng của bầy gia súc";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 431);
            Controls.Add(rtb_sound);
            Controls.Add(bt_feed);
            Controls.Add(bt_hungry);
            Controls.Add(label6);
            Controls.Add(lb_goatMilkVolume);
            Controls.Add(lb_goatCount);
            Controls.Add(lb_sheepMilkVolume);
            Controls.Add(lb_sheepCount);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(lb_cowMilkVolume);
            Controls.Add(lb_cowCount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "MainForm";
            Text = "Quản lý nông trại vật nuôi - 21521003";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label lb_cowCount;
        private Label lb_sheepCount;
        private Label lb_goatCount;
        private Label label1;
        private Label label5;
        private Label lb_cowMilkVolume;
        private Label lb_sheepMilkVolume;
        private Label lb_goatMilkVolume;
        private Label label6;
        private Button bt_hungry;
        private Button bt_feed;
        private RichTextBox rtb_sound;
    }
}
