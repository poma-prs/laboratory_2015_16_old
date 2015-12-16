namespace Auto
{
    partial class FormMenu
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
            this.buttonNavigator = new System.Windows.Forms.Button();
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.buttonRadio = new System.Windows.Forms.Button();
            this.buttonCurrentData = new System.Windows.Forms.Button();
            this.buttonJournal = new System.Windows.Forms.Button();
            this.buttonConditioner = new System.Windows.Forms.Button();
            this.buttonParkingSensor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNavigator
            // 
            this.buttonNavigator.Location = new System.Drawing.Point(30, 21);
            this.buttonNavigator.Name = "buttonNavigator";
            this.buttonNavigator.Size = new System.Drawing.Size(75, 48);
            this.buttonNavigator.TabIndex = 0;
            this.buttonNavigator.Text = "Навигатор";
            this.buttonNavigator.UseVisualStyleBackColor = true;
            this.buttonNavigator.Click += new System.EventHandler(this.buttonNavigator_Click);
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.Location = new System.Drawing.Point(140, 21);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(75, 48);
            this.buttonPlayer.TabIndex = 1;
            this.buttonPlayer.Text = "Плеер";
            this.buttonPlayer.UseVisualStyleBackColor = true;
            this.buttonPlayer.Click += new System.EventHandler(this.buttonPlayer_Click);
            // 
            // buttonRadio
            // 
            this.buttonRadio.Location = new System.Drawing.Point(257, 21);
            this.buttonRadio.Name = "buttonRadio";
            this.buttonRadio.Size = new System.Drawing.Size(75, 48);
            this.buttonRadio.TabIndex = 2;
            this.buttonRadio.Text = "Радио";
            this.buttonRadio.UseVisualStyleBackColor = true;
            this.buttonRadio.Click += new System.EventHandler(this.buttonRadio_Click);
            // 
            // buttonCurrentData
            // 
            this.buttonCurrentData.Location = new System.Drawing.Point(30, 102);
            this.buttonCurrentData.Name = "buttonCurrentData";
            this.buttonCurrentData.Size = new System.Drawing.Size(75, 52);
            this.buttonCurrentData.TabIndex = 3;
            this.buttonCurrentData.Text = "Данные о поездке";
            this.buttonCurrentData.UseVisualStyleBackColor = true;
            this.buttonCurrentData.Click += new System.EventHandler(this.buttonCurrentData_Click);
            // 
            // buttonJournal
            // 
            this.buttonJournal.Location = new System.Drawing.Point(140, 102);
            this.buttonJournal.Name = "buttonJournal";
            this.buttonJournal.Size = new System.Drawing.Size(75, 52);
            this.buttonJournal.TabIndex = 4;
            this.buttonJournal.Text = "Журнал";
            this.buttonJournal.UseVisualStyleBackColor = true;
            this.buttonJournal.Click += new System.EventHandler(this.buttonJournal_Click);
            // 
            // buttonConditioner
            // 
            this.buttonConditioner.Location = new System.Drawing.Point(257, 102);
            this.buttonConditioner.Name = "buttonConditioner";
            this.buttonConditioner.Size = new System.Drawing.Size(86, 52);
            this.buttonConditioner.TabIndex = 5;
            this.buttonConditioner.Text = "Кондиционер";
            this.buttonConditioner.UseVisualStyleBackColor = true;
            this.buttonConditioner.Click += new System.EventHandler(this.buttonConditioner_Click);
            // 
            // buttonParkingSensor
            // 
            this.buttonParkingSensor.Location = new System.Drawing.Point(30, 185);
            this.buttonParkingSensor.Name = "buttonParkingSensor";
            this.buttonParkingSensor.Size = new System.Drawing.Size(75, 50);
            this.buttonParkingSensor.TabIndex = 6;
            this.buttonParkingSensor.Text = "Парктроники";
            this.buttonParkingSensor.UseVisualStyleBackColor = true;
            this.buttonParkingSensor.Click += new System.EventHandler(this.buttonParkingSensor_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.buttonParkingSensor);
            this.Controls.Add(this.buttonConditioner);
            this.Controls.Add(this.buttonJournal);
            this.Controls.Add(this.buttonCurrentData);
            this.Controls.Add(this.buttonRadio);
            this.Controls.Add(this.buttonPlayer);
            this.Controls.Add(this.buttonNavigator);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNavigator;
        private System.Windows.Forms.Button buttonPlayer;
        private System.Windows.Forms.Button buttonRadio;
        private System.Windows.Forms.Button buttonCurrentData;
        private System.Windows.Forms.Button buttonJournal;
        private System.Windows.Forms.Button buttonConditioner;
        private System.Windows.Forms.Button buttonParkingSensor;
    }
}