namespace MultiThreadedApp
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
            this.pTarget = new System.Windows.Forms.Panel();
            this.bBike1 = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.bBike2 = new System.Windows.Forms.Button();
            this.bBike3 = new System.Windows.Forms.Button();
            this.pStart = new System.Windows.Forms.Panel();
            this.bStep1 = new System.Windows.Forms.Button();
            this.pDepo = new System.Windows.Forms.Panel();
            this.bStep2 = new System.Windows.Forms.Button();
            this.bPixels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pTarget
            // 
            this.pTarget.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pTarget.Location = new System.Drawing.Point(577, 12);
            this.pTarget.Name = "pTarget";
            this.pTarget.Size = new System.Drawing.Size(136, 253);
            this.pTarget.TabIndex = 0;
            // 
            // bBike1
            // 
            this.bBike1.Font = new System.Drawing.Font("Webdings", 32F);
            this.bBike1.Location = new System.Drawing.Point(40, 44);
            this.bBike1.Name = "bBike1";
            this.bBike1.Size = new System.Drawing.Size(101, 65);
            this.bBike1.TabIndex = 1;
            this.bBike1.Text = "b";
            this.bBike1.UseVisualStyleBackColor = true;
            this.bBike1.Click += new System.EventHandler(this.bike_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(51, 284);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(80, 35);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bBike2
            // 
            this.bBike2.Font = new System.Drawing.Font("Webdings", 32F);
            this.bBike2.Location = new System.Drawing.Point(40, 115);
            this.bBike2.Name = "bBike2";
            this.bBike2.Size = new System.Drawing.Size(101, 65);
            this.bBike2.TabIndex = 3;
            this.bBike2.Text = "b";
            this.bBike2.UseVisualStyleBackColor = true;
            this.bBike2.Click += new System.EventHandler(this.bike_Click);
            // 
            // bBike3
            // 
            this.bBike3.Font = new System.Drawing.Font("Webdings", 32F);
            this.bBike3.Location = new System.Drawing.Point(40, 186);
            this.bBike3.Name = "bBike3";
            this.bBike3.Size = new System.Drawing.Size(101, 65);
            this.bBike3.TabIndex = 4;
            this.bBike3.Text = "b";
            this.bBike3.UseVisualStyleBackColor = true;
            this.bBike3.Click += new System.EventHandler(this.bike_Click);
            // 
            // pStart
            // 
            this.pStart.BackColor = System.Drawing.Color.SlateGray;
            this.pStart.Location = new System.Drawing.Point(183, 12);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(125, 253);
            this.pStart.TabIndex = 5;
            // 
            // bStep1
            // 
            this.bStep1.Location = new System.Drawing.Point(195, 284);
            this.bStep1.Name = "bStep1";
            this.bStep1.Size = new System.Drawing.Size(100, 35);
            this.bStep1.TabIndex = 6;
            this.bStep1.Text = "Step1";
            this.bStep1.UseVisualStyleBackColor = true;
            this.bStep1.Click += new System.EventHandler(this.bStep1_Click);
            // 
            // pDepo
            // 
            this.pDepo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pDepo.Location = new System.Drawing.Point(373, 12);
            this.pDepo.Name = "pDepo";
            this.pDepo.Size = new System.Drawing.Size(145, 253);
            this.pDepo.TabIndex = 7;
            // 
            // bStep2
            // 
            this.bStep2.Location = new System.Drawing.Point(393, 284);
            this.bStep2.Name = "bStep2";
            this.bStep2.Size = new System.Drawing.Size(104, 35);
            this.bStep2.TabIndex = 8;
            this.bStep2.Text = "Step2";
            this.bStep2.UseVisualStyleBackColor = true;
            this.bStep2.Click += new System.EventHandler(this.bStep2_Click);
            // 
            // bPixels
            // 
            this.bPixels.Location = new System.Drawing.Point(594, 284);
            this.bPixels.Name = "bPixels";
            this.bPixels.Size = new System.Drawing.Size(104, 35);
            this.bPixels.TabIndex = 9;
            this.bPixels.Text = "Pixels";
            this.bPixels.UseVisualStyleBackColor = true;
            this.bPixels.Click += new System.EventHandler(this.bPixels_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 380);
            this.Controls.Add(this.bPixels);
            this.Controls.Add(this.bStep2);
            this.Controls.Add(this.bStep1);
            this.Controls.Add(this.bBike3);
            this.Controls.Add(this.bBike2);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bBike1);
            this.Controls.Add(this.pTarget);
            this.Controls.Add(this.pStart);
            this.Controls.Add(this.pDepo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTarget;
        private System.Windows.Forms.Button bBike1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bBike2;
        private System.Windows.Forms.Button bBike3;
        private System.Windows.Forms.Panel pStart;
        private System.Windows.Forms.Button bStep1;
        private System.Windows.Forms.Panel pDepo;
        private System.Windows.Forms.Button bStep2;
        private System.Windows.Forms.Button bPixels;
    }
}

