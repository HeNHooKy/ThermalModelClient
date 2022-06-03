namespace ThermalModelClient
{
    partial class DataWindow
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
            this.SensorNameLabel = new System.Windows.Forms.Label();
            this.SensorName = new System.Windows.Forms.TextBox();
            this.SensorIdLabel = new System.Windows.Forms.Label();
            this.SensorId = new System.Windows.Forms.TextBox();
            this.XCoordLabel = new System.Windows.Forms.Label();
            this.XCoord = new System.Windows.Forms.TextBox();
            this.YCoordLabel = new System.Windows.Forms.Label();
            this.YCoord = new System.Windows.Forms.TextBox();
            this.ZCoordLabel = new System.Windows.Forms.Label();
            this.ZCoord = new System.Windows.Forms.TextBox();
            this.LastCheckLabel = new System.Windows.Forms.Label();
            this.LastCheck = new System.Windows.Forms.TextBox();
            this.LastValueLabel = new System.Windows.Forms.Label();
            this.LastValue = new System.Windows.Forms.TextBox();
            this.BlockIdLabel = new System.Windows.Forms.Label();
            this.BlockId = new System.Windows.Forms.TextBox();
            this.DataDataGrid = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SensorNameLabel
            // 
            this.SensorNameLabel.AutoSize = true;
            this.SensorNameLabel.Location = new System.Drawing.Point(22, 11);
            this.SensorNameLabel.Name = "SensorNameLabel";
            this.SensorNameLabel.Size = new System.Drawing.Size(78, 15);
            this.SensorNameLabel.TabIndex = 0;
            this.SensorNameLabel.Text = "Sensor name:";
            // 
            // SensorName
            // 
            this.SensorName.Location = new System.Drawing.Point(106, 8);
            this.SensorName.Name = "SensorName";
            this.SensorName.Size = new System.Drawing.Size(198, 23);
            this.SensorName.TabIndex = 1;
            this.SensorName.Text = "Loading...";
            // 
            // SensorIdLabel
            // 
            this.SensorIdLabel.AutoSize = true;
            this.SensorIdLabel.Location = new System.Drawing.Point(42, 40);
            this.SensorIdLabel.Name = "SensorIdLabel";
            this.SensorIdLabel.Size = new System.Drawing.Size(58, 15);
            this.SensorIdLabel.TabIndex = 0;
            this.SensorIdLabel.Text = "Sensor Id:";
            // 
            // SensorId
            // 
            this.SensorId.Location = new System.Drawing.Point(106, 37);
            this.SensorId.Name = "SensorId";
            this.SensorId.ReadOnly = true;
            this.SensorId.Size = new System.Drawing.Size(198, 23);
            this.SensorId.TabIndex = 1;
            this.SensorId.Text = "Loading...";
            // 
            // XCoordLabel
            // 
            this.XCoordLabel.AutoSize = true;
            this.XCoordLabel.Location = new System.Drawing.Point(49, 69);
            this.XCoordLabel.Name = "XCoordLabel";
            this.XCoordLabel.Size = new System.Drawing.Size(51, 15);
            this.XCoordLabel.TabIndex = 0;
            this.XCoordLabel.Text = "X coord:";
            // 
            // XCoord
            // 
            this.XCoord.Location = new System.Drawing.Point(106, 66);
            this.XCoord.Name = "XCoord";
            this.XCoord.Size = new System.Drawing.Size(198, 23);
            this.XCoord.TabIndex = 1;
            this.XCoord.Text = "Loading...";
            // 
            // YCoordLabel
            // 
            this.YCoordLabel.AutoSize = true;
            this.YCoordLabel.Location = new System.Drawing.Point(49, 98);
            this.YCoordLabel.Name = "YCoordLabel";
            this.YCoordLabel.Size = new System.Drawing.Size(51, 15);
            this.YCoordLabel.TabIndex = 0;
            this.YCoordLabel.Text = "Y coord:";
            // 
            // YCoord
            // 
            this.YCoord.Location = new System.Drawing.Point(106, 95);
            this.YCoord.Name = "YCoord";
            this.YCoord.Size = new System.Drawing.Size(198, 23);
            this.YCoord.TabIndex = 1;
            this.YCoord.Text = "Loading...";
            // 
            // ZCoordLabel
            // 
            this.ZCoordLabel.AutoSize = true;
            this.ZCoordLabel.Location = new System.Drawing.Point(49, 127);
            this.ZCoordLabel.Name = "ZCoordLabel";
            this.ZCoordLabel.Size = new System.Drawing.Size(51, 15);
            this.ZCoordLabel.TabIndex = 0;
            this.ZCoordLabel.Text = "Z coord:";
            // 
            // ZCoord
            // 
            this.ZCoord.Location = new System.Drawing.Point(106, 124);
            this.ZCoord.Name = "ZCoord";
            this.ZCoord.Size = new System.Drawing.Size(198, 23);
            this.ZCoord.TabIndex = 1;
            this.ZCoord.Text = "Loading...";
            // 
            // LastCheckLabel
            // 
            this.LastCheckLabel.AutoSize = true;
            this.LastCheckLabel.Location = new System.Drawing.Point(9, 156);
            this.LastCheckLabel.Name = "LastCheckLabel";
            this.LastCheckLabel.Size = new System.Drawing.Size(91, 15);
            this.LastCheckLabel.TabIndex = 0;
            this.LastCheckLabel.Text = "Last check date:";
            // 
            // LastCheck
            // 
            this.LastCheck.Location = new System.Drawing.Point(106, 153);
            this.LastCheck.Name = "LastCheck";
            this.LastCheck.ReadOnly = true;
            this.LastCheck.Size = new System.Drawing.Size(198, 23);
            this.LastCheck.TabIndex = 1;
            this.LastCheck.Text = "Loading...";
            // 
            // LastValueLabel
            // 
            this.LastValueLabel.AutoSize = true;
            this.LastValueLabel.Location = new System.Drawing.Point(4, 185);
            this.LastValueLabel.Name = "LastValueLabel";
            this.LastValueLabel.Size = new System.Drawing.Size(96, 15);
            this.LastValueLabel.TabIndex = 0;
            this.LastValueLabel.Text = "Last check value:";
            // 
            // LastValue
            // 
            this.LastValue.Location = new System.Drawing.Point(106, 182);
            this.LastValue.Name = "LastValue";
            this.LastValue.ReadOnly = true;
            this.LastValue.Size = new System.Drawing.Size(198, 23);
            this.LastValue.TabIndex = 1;
            this.LastValue.Text = "Loading...";
            // 
            // BlockIdLabel
            // 
            this.BlockIdLabel.AutoSize = true;
            this.BlockIdLabel.Location = new System.Drawing.Point(48, 214);
            this.BlockIdLabel.Name = "BlockIdLabel";
            this.BlockIdLabel.Size = new System.Drawing.Size(52, 15);
            this.BlockIdLabel.TabIndex = 0;
            this.BlockIdLabel.Text = "Block Id:";
            // 
            // BlockId
            // 
            this.BlockId.Location = new System.Drawing.Point(106, 211);
            this.BlockId.Name = "BlockId";
            this.BlockId.ReadOnly = true;
            this.BlockId.Size = new System.Drawing.Size(198, 23);
            this.BlockId.TabIndex = 1;
            this.BlockId.Text = "Loading...";
            // 
            // DataDataGrid
            // 
            this.DataDataGrid.AllowUserToAddRows = false;
            this.DataDataGrid.AllowUserToDeleteRows = false;
            this.DataDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDataGrid.Location = new System.Drawing.Point(310, 8);
            this.DataDataGrid.Name = "DataDataGrid";
            this.DataDataGrid.ReadOnly = true;
            this.DataDataGrid.RowTemplate.Height = 25;
            this.DataDataGrid.Size = new System.Drawing.Size(377, 339);
            this.DataDataGrid.TabIndex = 2;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(611, 366);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(106, 240);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(198, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 401);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DataDataGrid);
            this.Controls.Add(this.BlockId);
            this.Controls.Add(this.BlockIdLabel);
            this.Controls.Add(this.LastValue);
            this.Controls.Add(this.LastValueLabel);
            this.Controls.Add(this.LastCheck);
            this.Controls.Add(this.LastCheckLabel);
            this.Controls.Add(this.ZCoord);
            this.Controls.Add(this.ZCoordLabel);
            this.Controls.Add(this.YCoord);
            this.Controls.Add(this.YCoordLabel);
            this.Controls.Add(this.XCoord);
            this.Controls.Add(this.XCoordLabel);
            this.Controls.Add(this.SensorId);
            this.Controls.Add(this.SensorIdLabel);
            this.Controls.Add(this.SensorName);
            this.Controls.Add(this.SensorNameLabel);
            this.Name = "DataWindow";
            this.Text = "Sensor\'s history";
            this.Load += new System.EventHandler(this.DataWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SensorNameLabel;
        private TextBox SensorName;
        private Label SensorIdLabel;
        private TextBox SensorId;
        private Label XCoordLabel;
        private TextBox XCoord;
        private Label YCoordLabel;
        private TextBox YCoord;
        private Label ZCoordLabel;
        private TextBox ZCoord;
        private Label LastCheckLabel;
        private TextBox LastCheck;
        private Label LastValueLabel;
        private TextBox LastValue;
        private Label BlockIdLabel;
        private TextBox BlockId;
        private DataGridView DataDataGrid;
        private Button Back;
        private Button Save;
    }
}