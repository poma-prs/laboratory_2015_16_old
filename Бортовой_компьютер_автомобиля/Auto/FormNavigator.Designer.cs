namespace Auto
{
    partial class FormNavigator
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
            this.buttonShowMap = new System.Windows.Forms.Button();
            this.buttonLocation = new System.Windows.Forms.Button();
            this.buttonSetRoute = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonTrafficJam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.Location = new System.Drawing.Point(13, 13);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.Size = new System.Drawing.Size(75, 37);
            this.buttonShowMap.TabIndex = 0;
            this.buttonShowMap.Text = "Просмотр карты";
            this.buttonShowMap.UseVisualStyleBackColor = true;
            this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
            // 
            // buttonLocation
            // 
            this.buttonLocation.Location = new System.Drawing.Point(105, 13);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(103, 37);
            this.buttonLocation.TabIndex = 1;
            this.buttonLocation.Text = "Текущее местоположение";
            this.buttonLocation.UseVisualStyleBackColor = true;
            this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
            // 
            // buttonSetRoute
            // 
            this.buttonSetRoute.Location = new System.Drawing.Point(239, 13);
            this.buttonSetRoute.Name = "buttonSetRoute";
            this.buttonSetRoute.Size = new System.Drawing.Size(75, 37);
            this.buttonSetRoute.TabIndex = 2;
            this.buttonSetRoute.Text = "Проложить маршрут";
            this.buttonSetRoute.UseVisualStyleBackColor = true;
            this.buttonSetRoute.Click += new System.EventHandler(this.buttonSetRoute_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(13, 73);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 35);
            this.buttonDownload.TabIndex = 3;
            this.buttonDownload.Text = "Скачать карту";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonTrafficJam
            // 
            this.buttonTrafficJam.Location = new System.Drawing.Point(105, 73);
            this.buttonTrafficJam.Name = "buttonTrafficJam";
            this.buttonTrafficJam.Size = new System.Drawing.Size(83, 35);
            this.buttonTrafficJam.TabIndex = 4;
            this.buttonTrafficJam.Text = "Информация о пробках";
            this.buttonTrafficJam.UseVisualStyleBackColor = true;
            this.buttonTrafficJam.Click += new System.EventHandler(this.buttonTrafficJam_Click);
            // 
            // FormNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 243);
            this.Controls.Add(this.buttonTrafficJam);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonSetRoute);
            this.Controls.Add(this.buttonLocation);
            this.Controls.Add(this.buttonShowMap);
            this.Name = "FormNavigator";
            this.Text = "FormNavigator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowMap;
        private System.Windows.Forms.Button buttonLocation;
        private System.Windows.Forms.Button buttonSetRoute;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonTrafficJam;
    }
}