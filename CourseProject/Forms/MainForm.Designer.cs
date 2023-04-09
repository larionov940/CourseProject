namespace CourseProject.Forms
{
    partial class MainForm
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
            this.buttonPassenger = new System.Windows.Forms.Button();
            this.buttonBus = new System.Windows.Forms.Button();
            this.buttonBusStation = new System.Windows.Forms.Button();
            this.buttonDrivers = new System.Windows.Forms.Button();
            this.buttonReis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPassenger
            // 
            this.buttonPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPassenger.Location = new System.Drawing.Point(12, 12);
            this.buttonPassenger.Name = "buttonPassenger";
            this.buttonPassenger.Size = new System.Drawing.Size(251, 38);
            this.buttonPassenger.TabIndex = 0;
            this.buttonPassenger.Text = "Пассажиры";
            this.buttonPassenger.UseVisualStyleBackColor = true;
            this.buttonPassenger.Click += new System.EventHandler(this.buttonPassenger_Click);
            // 
            // buttonBus
            // 
            this.buttonBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBus.Location = new System.Drawing.Point(12, 56);
            this.buttonBus.Name = "buttonBus";
            this.buttonBus.Size = new System.Drawing.Size(251, 38);
            this.buttonBus.TabIndex = 1;
            this.buttonBus.Text = "Автобусы";
            this.buttonBus.UseVisualStyleBackColor = true;
            this.buttonBus.Click += new System.EventHandler(this.buttonBus_Click);
            // 
            // buttonBusStation
            // 
            this.buttonBusStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBusStation.Location = new System.Drawing.Point(12, 188);
            this.buttonBusStation.Name = "buttonBusStation";
            this.buttonBusStation.Size = new System.Drawing.Size(251, 38);
            this.buttonBusStation.TabIndex = 2;
            this.buttonBusStation.Text = "Автостанции";
            this.buttonBusStation.UseVisualStyleBackColor = true;
            this.buttonBusStation.Click += new System.EventHandler(this.buttonBusStation_Click);
            // 
            // buttonDrivers
            // 
            this.buttonDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrivers.Location = new System.Drawing.Point(12, 144);
            this.buttonDrivers.Name = "buttonDrivers";
            this.buttonDrivers.Size = new System.Drawing.Size(251, 38);
            this.buttonDrivers.TabIndex = 3;
            this.buttonDrivers.Text = "Водители";
            this.buttonDrivers.UseVisualStyleBackColor = true;
            this.buttonDrivers.Click += new System.EventHandler(this.buttonDrivers_Click);
            // 
            // buttonReis
            // 
            this.buttonReis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReis.Location = new System.Drawing.Point(12, 100);
            this.buttonReis.Name = "buttonReis";
            this.buttonReis.Size = new System.Drawing.Size(251, 38);
            this.buttonReis.TabIndex = 4;
            this.buttonReis.Text = "Рейсы";
            this.buttonReis.UseVisualStyleBackColor = true;
            this.buttonReis.Click += new System.EventHandler(this.buttonReis_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 240);
            this.Controls.Add(this.buttonReis);
            this.Controls.Add(this.buttonDrivers);
            this.Controls.Add(this.buttonBusStation);
            this.Controls.Add(this.buttonBus);
            this.Controls.Add(this.buttonPassenger);
            this.Name = "MainForm";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPassenger;
        private System.Windows.Forms.Button buttonBus;
        private System.Windows.Forms.Button buttonBusStation;
        private System.Windows.Forms.Button buttonDrivers;
        private System.Windows.Forms.Button buttonReis;
    }
}