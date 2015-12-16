namespace Auto
{
    partial class FormRadio
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonFreq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(143, 45);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 40);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Воспроизвести";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(28, 45);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(75, 40);
            this.buttonOn.TabIndex = 1;
            this.buttonOn.Text = "Включить";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(269, 45);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(75, 40);
            this.buttonOff.TabIndex = 2;
            this.buttonOff.Text = "Выключить";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // buttonFreq
            // 
            this.buttonFreq.Location = new System.Drawing.Point(132, 119);
            this.buttonFreq.Name = "buttonFreq";
            this.buttonFreq.Size = new System.Drawing.Size(75, 39);
            this.buttonFreq.TabIndex = 3;
            this.buttonFreq.Text = "Выбрать частоту";
            this.buttonFreq.UseVisualStyleBackColor = true;
            this.buttonFreq.Click += new System.EventHandler(this.buttonFreq_Click);
            // 
            // FormRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 202);
            this.Controls.Add(this.buttonFreq);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.buttonPlay);
            this.Name = "FormRadio";
            this.Text = "FormRadio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonFreq;
    }
}