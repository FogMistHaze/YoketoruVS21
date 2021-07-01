
namespace YoketoruVS21
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Cmaru = new System.Windows.Forms.Label();
            this.Hightscor = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Label();
            this.Gameover = new System.Windows.Forms.Label();
            this.Modoru = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Complete = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Title.Font = new System.Drawing.Font("プイッコ", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Title.ForeColor = System.Drawing.Color.DarkCyan;
            this.Title.Location = new System.Drawing.Point(160, 85);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(433, 72);
            this.Title.TabIndex = 0;
            this.Title.Text = "よけとる2021";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Pink;
            this.Start.Font = new System.Drawing.Font("プイッコ", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Start.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Start.Location = new System.Drawing.Point(280, 297);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(193, 57);
            this.Start.TabIndex = 1;
            this.Start.Text = "すたーと";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Cmaru
            // 
            this.Cmaru.AutoSize = true;
            this.Cmaru.Location = new System.Drawing.Point(568, 422);
            this.Cmaru.Name = "Cmaru";
            this.Cmaru.Size = new System.Drawing.Size(173, 15);
            this.Cmaru.TabIndex = 2;
            this.Cmaru.Text = "Copyright Ⓒ 2021 AranKura_Izu";
            // 
            // Hightscor
            // 
            this.Hightscor.AutoSize = true;
            this.Hightscor.Font = new System.Drawing.Font("プイッコ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hightscor.Location = new System.Drawing.Point(271, 207);
            this.Hightscor.Name = "Hightscor";
            this.Hightscor.Size = new System.Drawing.Size(210, 32);
            this.Hightscor.TabIndex = 4;
            this.Hightscor.Text = "はいすこあ 100";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("プイッコ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Time.Location = new System.Drawing.Point(12, 9);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(156, 32);
            this.Time.TabIndex = 5;
            this.Time.Text = "たいむ 100";
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.Font = new System.Drawing.Font("プイッコ", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.ForeColor = System.Drawing.Color.Fuchsia;
            this.Clear.Location = new System.Drawing.Point(286, 193);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(180, 61);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "くりあ";
            // 
            // Gameover
            // 
            this.Gameover.AutoSize = true;
            this.Gameover.Font = new System.Drawing.Font("プイッコ", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gameover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Gameover.Location = new System.Drawing.Point(184, 193);
            this.Gameover.Name = "Gameover";
            this.Gameover.Size = new System.Drawing.Size(384, 61);
            this.Gameover.TabIndex = 7;
            this.Gameover.Text = "げーむおーばー";
            // 
            // Modoru
            // 
            this.Modoru.BackColor = System.Drawing.Color.Pink;
            this.Modoru.Font = new System.Drawing.Font("プイッコ", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Modoru.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Modoru.Location = new System.Drawing.Point(12, 377);
            this.Modoru.Name = "Modoru";
            this.Modoru.Size = new System.Drawing.Size(193, 57);
            this.Modoru.TabIndex = 8;
            this.Modoru.Text = "たいとるへ";
            this.Modoru.UseVisualStyleBackColor = false;
            this.Modoru.Click += new System.EventHandler(this.Modoru_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Complete
            // 
            this.Complete.AutoSize = true;
            this.Complete.Font = new System.Drawing.Font("プイッコ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Complete.Location = new System.Drawing.Point(654, 9);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(87, 32);
            this.Complete.TabIndex = 9;
            this.Complete.Text = "🐚：10";
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Font = new System.Drawing.Font("プイッコ", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Temp.ForeColor = System.Drawing.Color.Black;
            this.Temp.Location = new System.Drawing.Point(34, 99);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(43, 30);
            this.Temp.TabIndex = 10;
            this.Temp.Text = "🦈";
            this.Temp.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(753, 446);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Hightscor);
            this.Controls.Add(this.Cmaru);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Gameover);
            this.Controls.Add(this.Modoru);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Cmaru;
        private System.Windows.Forms.Label Hightscor;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Clear;
        private System.Windows.Forms.Label Gameover;
        private System.Windows.Forms.Button Modoru;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Complete;
        private System.Windows.Forms.Label Temp;
    }
}

