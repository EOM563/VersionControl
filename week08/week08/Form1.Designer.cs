namespace week08
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSelectBall = new System.Windows.Forms.Button();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnSelectPresent = new System.Windows.Forms.Button();
            this.pBtnColor1 = new System.Windows.Forms.Button();
            this.pBtnColor2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(-3, 172);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(805, 110);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnColor.Location = new System.Drawing.Point(126, 69);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(108, 18);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSelectBall
            // 
            this.btnSelectBall.Location = new System.Drawing.Point(126, 12);
            this.btnSelectBall.Name = "btnSelectBall";
            this.btnSelectBall.Size = new System.Drawing.Size(108, 51);
            this.btnSelectBall.TabIndex = 2;
            this.btnSelectBall.Text = "BALL";
            this.btnSelectBall.UseVisualStyleBackColor = true;
            this.btnSelectBall.Click += new System.EventHandler(this.btnSelectBall_Click);
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(12, 12);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(108, 51);
            this.btnSelectCar.TabIndex = 2;
            this.btnSelectCar.Text = "CAR";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(373, 12);
            this.lblNext.Name = "lblNext";
            this.lblNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNext.Size = new System.Drawing.Size(70, 13);
            this.lblNext.TabIndex = 3;
            this.lblNext.Text = "Coming Next:";
            // 
            // btnSelectPresent
            // 
            this.btnSelectPresent.Location = new System.Drawing.Point(240, 12);
            this.btnSelectPresent.Name = "btnSelectPresent";
            this.btnSelectPresent.Size = new System.Drawing.Size(108, 51);
            this.btnSelectPresent.TabIndex = 4;
            this.btnSelectPresent.Text = "PRESENT";
            this.btnSelectPresent.UseVisualStyleBackColor = true;
            this.btnSelectPresent.Click += new System.EventHandler(this.btnSelectPresent_Click);
            // 
            // pBtnColor1
            // 
            this.pBtnColor1.BackColor = System.Drawing.Color.Red;
            this.pBtnColor1.Location = new System.Drawing.Point(240, 69);
            this.pBtnColor1.Name = "pBtnColor1";
            this.pBtnColor1.Size = new System.Drawing.Size(108, 18);
            this.pBtnColor1.TabIndex = 5;
            this.pBtnColor1.UseVisualStyleBackColor = false;
            this.pBtnColor1.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pBtnColor2
            // 
            this.pBtnColor2.BackColor = System.Drawing.Color.Yellow;
            this.pBtnColor2.Location = new System.Drawing.Point(240, 93);
            this.pBtnColor2.Name = "pBtnColor2";
            this.pBtnColor2.Size = new System.Drawing.Size(108, 18);
            this.pBtnColor2.TabIndex = 6;
            this.pBtnColor2.UseVisualStyleBackColor = false;
            this.pBtnColor2.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.pBtnColor2);
            this.Controls.Add(this.pBtnColor1);
            this.Controls.Add(this.btnSelectPresent);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btnSelectCar);
            this.Controls.Add(this.btnSelectBall);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSelectBall;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnSelectPresent;
        private System.Windows.Forms.Button pBtnColor1;
        private System.Windows.Forms.Button pBtnColor2;
    }
}

