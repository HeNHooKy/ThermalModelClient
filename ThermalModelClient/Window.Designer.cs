namespace ThermalModelClient
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChoosenCluster = new System.Windows.Forms.ComboBox();
            this.ChoosenClusterLabel = new System.Windows.Forms.Label();
            this.ChoosenBlock = new System.Windows.Forms.ComboBox();
            this.ChoosenBlockLabel = new System.Windows.Forms.Label();
            this.ClusterName = new System.Windows.Forms.TextBox();
            this.ClusterNameLabel = new System.Windows.Forms.Label();
            this.BlockNameLabel = new System.Windows.Forms.Label();
            this.BlockName = new System.Windows.Forms.TextBox();
            this.SensorsLabel = new System.Windows.Forms.Label();
            this.SensorsGrid = new System.Windows.Forms.DataGridView();
            this.History = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SensorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoosenCluster
            // 
            this.ChoosenCluster.FormattingEnabled = true;
            this.ChoosenCluster.Location = new System.Drawing.Point(12, 30);
            this.ChoosenCluster.Name = "ChoosenCluster";
            this.ChoosenCluster.Size = new System.Drawing.Size(219, 23);
            this.ChoosenCluster.TabIndex = 0;
            this.ChoosenCluster.LostFocus += new System.EventHandler(this.ChoosenCluster_LostFocus);
            // 
            // ChoosenClusterLabel
            // 
            this.ChoosenClusterLabel.AutoSize = true;
            this.ChoosenClusterLabel.Location = new System.Drawing.Point(12, 12);
            this.ChoosenClusterLabel.Name = "ChoosenClusterLabel";
            this.ChoosenClusterLabel.Size = new System.Drawing.Size(85, 15);
            this.ChoosenClusterLabel.TabIndex = 1;
            this.ChoosenClusterLabel.Text = "Choose cluster";
            // 
            // ChoosenBlock
            // 
            this.ChoosenBlock.FormattingEnabled = true;
            this.ChoosenBlock.Location = new System.Drawing.Point(12, 81);
            this.ChoosenBlock.Name = "ChoosenBlock";
            this.ChoosenBlock.Size = new System.Drawing.Size(219, 23);
            this.ChoosenBlock.TabIndex = 0;
            this.ChoosenBlock.LostFocus += new System.EventHandler(this.ChoosenBlock_LostFocus);
            // 
            // ChoosenBlockLabel
            // 
            this.ChoosenBlockLabel.AutoSize = true;
            this.ChoosenBlockLabel.Location = new System.Drawing.Point(12, 63);
            this.ChoosenBlockLabel.Name = "ChoosenBlockLabel";
            this.ChoosenBlockLabel.Size = new System.Drawing.Size(79, 15);
            this.ChoosenBlockLabel.TabIndex = 1;
            this.ChoosenBlockLabel.Text = "Choose block";
            // 
            // ClusterName
            // 
            this.ClusterName.Location = new System.Drawing.Point(343, 30);
            this.ClusterName.Name = "ClusterName";
            this.ClusterName.Size = new System.Drawing.Size(263, 23);
            this.ClusterName.TabIndex = 2;
            this.ClusterName.LostFocus += new System.EventHandler(this.ClusterName_LostFocus);
            // 
            // ClusterNameLabel
            // 
            this.ClusterNameLabel.AutoSize = true;
            this.ClusterNameLabel.Location = new System.Drawing.Point(257, 33);
            this.ClusterNameLabel.Name = "ClusterNameLabel";
            this.ClusterNameLabel.Size = new System.Drawing.Size(80, 15);
            this.ClusterNameLabel.TabIndex = 1;
            this.ClusterNameLabel.Text = "Cluster name:";
            // 
            // BlockNameLabel
            // 
            this.BlockNameLabel.AutoSize = true;
            this.BlockNameLabel.Location = new System.Drawing.Point(257, 84);
            this.BlockNameLabel.Name = "BlockNameLabel";
            this.BlockNameLabel.Size = new System.Drawing.Size(72, 15);
            this.BlockNameLabel.TabIndex = 1;
            this.BlockNameLabel.Text = "Block name:";
            // 
            // BlockName
            // 
            this.BlockName.Location = new System.Drawing.Point(343, 81);
            this.BlockName.Name = "BlockName";
            this.BlockName.Size = new System.Drawing.Size(263, 23);
            this.BlockName.TabIndex = 2;
            this.BlockName.LostFocus += new System.EventHandler(this.BlockName_LostFocus);
            // 
            // SensorsLabel
            // 
            this.SensorsLabel.AutoSize = true;
            this.SensorsLabel.Location = new System.Drawing.Point(12, 123);
            this.SensorsLabel.Name = "SensorsLabel";
            this.SensorsLabel.Size = new System.Drawing.Size(50, 15);
            this.SensorsLabel.TabIndex = 3;
            this.SensorsLabel.Text = "Sensors:";
            // 
            // SensorsGrid
            // 
            this.SensorsGrid.AllowUserToAddRows = false;
            this.SensorsGrid.AllowUserToDeleteRows = false;
            this.SensorsGrid.AllowUserToResizeColumns = false;
            this.SensorsGrid.AllowUserToResizeRows = false;
            this.SensorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SensorsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.History});
            this.SensorsGrid.Location = new System.Drawing.Point(12, 141);
            this.SensorsGrid.MultiSelect = false;
            this.SensorsGrid.Name = "SensorsGrid";
            this.SensorsGrid.RowTemplate.Height = 25;
            this.SensorsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SensorsGrid.Size = new System.Drawing.Size(1038, 297);
            this.SensorsGrid.TabIndex = 4;
            this.SensorsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SensorsGrid_CellContentClick);
            this.SensorsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            // 
            // History
            // 
            this.History.HeaderText = "History";
            this.History.Name = "History";
            this.History.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.History.Text = "open";
            this.History.UseColumnTextForButtonValue = true;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.SensorsGrid);
            this.Controls.Add(this.SensorsLabel);
            this.Controls.Add(this.BlockName);
            this.Controls.Add(this.ClusterName);
            this.Controls.Add(this.BlockNameLabel);
            this.Controls.Add(this.ChoosenBlockLabel);
            this.Controls.Add(this.ClusterNameLabel);
            this.Controls.Add(this.ChoosenClusterLabel);
            this.Controls.Add(this.ChoosenBlock);
            this.Controls.Add(this.ChoosenCluster);
            this.Name = "Window";
            this.Text = "Thermal model simple client";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SensorsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ChoosenCluster;
        private Label ChoosenClusterLabel;
        private ComboBox ChoosenBlock;
        private Label ChoosenBlockLabel;
        private TextBox ClusterName;
        private Label ClusterNameLabel;
        private Label BlockNameLabel;
        private TextBox BlockName;
        private Label SensorsLabel;
        private DataGridView SensorsGrid;
        private DataGridViewButtonColumn History;
    }
}