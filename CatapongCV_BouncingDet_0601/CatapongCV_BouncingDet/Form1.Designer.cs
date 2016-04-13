namespace CatapongCV_BouncingDet
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.ibHist = new Emgu.CV.UI.ImageBox();
            this.ibNorm = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibNorm)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(8, 8);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(200, 240);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 126);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(633, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(634, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "200";
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(216, 8);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(200, 240);
            this.imageBox2.TabIndex = 6;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(424, 8);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(160, 120);
            this.imageBox3.TabIndex = 7;
            this.imageBox3.TabStop = false;
            // 
            // ibHist
            // 
            this.ibHist.Location = new System.Drawing.Point(216, 256);
            this.ibHist.Name = "ibHist";
            this.ibHist.Size = new System.Drawing.Size(200, 100);
            this.ibHist.TabIndex = 8;
            this.ibHist.TabStop = false;
            // 
            // ibNorm
            // 
            this.ibNorm.Location = new System.Drawing.Point(424, 256);
            this.ibNorm.Name = "ibNorm";
            this.ibNorm.Size = new System.Drawing.Size(200, 100);
            this.ibNorm.TabIndex = 9;
            this.ibNorm.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 435);
            this.Controls.Add(this.ibNorm);
            this.Controls.Add(this.ibHist);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibNorm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox ibHist;
        private Emgu.CV.UI.ImageBox ibNorm;
    }
}

