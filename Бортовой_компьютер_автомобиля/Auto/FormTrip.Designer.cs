namespace Auto
{
    partial class FormTrip
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
            this.buttonCurrentTrip = new System.Windows.Forms.Button();
            this.buttonCurrentFuel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCurrentTrip
            // 
            this.buttonCurrentTrip.Location = new System.Drawing.Point(31, 27);
            this.buttonCurrentTrip.Name = "buttonCurrentTrip";
            this.buttonCurrentTrip.Size = new System.Drawing.Size(111, 38);
            this.buttonCurrentTrip.TabIndex = 0;
            this.buttonCurrentTrip.Text = "Текущие данные о поездке";
            this.buttonCurrentTrip.UseVisualStyleBackColor = true;
            this.buttonCurrentTrip.Click += new System.EventHandler(this.buttonCurrentTrip_Click);
            // 
            // buttonCurrentFuel
            // 
            this.buttonCurrentFuel.Location = new System.Drawing.Point(206, 27);
            this.buttonCurrentFuel.Name = "buttonCurrentFuel";
            this.buttonCurrentFuel.Size = new System.Drawing.Size(101, 38);
            this.buttonCurrentFuel.TabIndex = 1;
            this.buttonCurrentFuel.Text = "Текущие данные о бензине";
            this.buttonCurrentFuel.UseVisualStyleBackColor = true;
            this.buttonCurrentFuel.Click += new System.EventHandler(this.buttonCurrentFuel_Click);
            // 
            // FormTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 214);
            this.Controls.Add(this.buttonCurrentFuel);
            this.Controls.Add(this.buttonCurrentTrip);
            this.Name = "FormTrip";
            this.Text = "FormTrip";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCurrentTrip;
        private System.Windows.Forms.Button buttonCurrentFuel;
    }
}