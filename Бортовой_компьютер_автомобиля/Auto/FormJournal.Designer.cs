namespace Auto
{
    partial class FormJournal
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
            this.buttonTrip = new System.Windows.Forms.Button();
            this.buttonFuel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTrip
            // 
            this.buttonTrip.Location = new System.Drawing.Point(12, 48);
            this.buttonTrip.Name = "buttonTrip";
            this.buttonTrip.Size = new System.Drawing.Size(75, 38);
            this.buttonTrip.TabIndex = 0;
            this.buttonTrip.Text = "Журнал поездок";
            this.buttonTrip.UseVisualStyleBackColor = true;
            this.buttonTrip.Click += new System.EventHandler(this.buttonTrip_Click);
            // 
            // buttonFuel
            // 
            this.buttonFuel.Location = new System.Drawing.Point(144, 48);
            this.buttonFuel.Name = "buttonFuel";
            this.buttonFuel.Size = new System.Drawing.Size(75, 38);
            this.buttonFuel.TabIndex = 1;
            this.buttonFuel.Text = "Журнал заправок";
            this.buttonFuel.UseVisualStyleBackColor = true;
            this.buttonFuel.Click += new System.EventHandler(this.buttonFuel_Click);
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 196);
            this.Controls.Add(this.buttonFuel);
            this.Controls.Add(this.buttonTrip);
            this.Name = "FormJournal";
            this.Text = "FormJournal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTrip;
        private System.Windows.Forms.Button buttonFuel;
    }
}