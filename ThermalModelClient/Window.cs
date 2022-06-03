using ThermalModelClient.Model;

namespace ThermalModelClient
{
    public partial class Window : Form
    {
        /// <summary>
        /// Number of columns in the grid.
        /// </summary>
        private const int numberOfColumns = 6;

        public Window()
        {
            InitializeComponent();
        }

        private async void Window_Load(object sender, EventArgs e)
        {
            await UpdateWindowInfo();
            while(true)
            {
                await Task.Delay(1000);
                await UpdateWindowInfo();
            }

        }

        private async Task UpdateWindowInfo()
        {
            var clusters = await ConnectionLayer.GetInfo();

            if (clusters == null) return;
            if (!clusters.Any()) return;

            UpdateChoosenCombobox(clusters, ChoosenCluster);
            var choosencluster = (Cluster?)ChoosenCluster.SelectedItem;


            if (choosencluster == null) return;
            if (choosencluster.Blocks == null) return;

            UpdateChoosenCombobox(choosencluster.Blocks, ChoosenBlock);
        }

        private void UpdateChoosenCombobox
            (IEnumerable<IdClass> objects, ComboBox comboBox)
        {
            var copyOfChoosenClusterItems = comboBox.Items.Cast<IdClass>().ToList();

            foreach (var obj in objects)
            {
                bool updated = false;
                for (int objNumber = 0;
                    objNumber < copyOfChoosenClusterItems.Count();
                    objNumber++)
                {
                    var clusterInChoosen = (IdClass?)comboBox.Items[objNumber];

                    if (clusterInChoosen == null)
                        throw new ArgumentNullException($"{obj.GetType().Name} in choosen can't be null!");

                    if (obj.Id == clusterInChoosen.Id)
                    {
                        comboBox.Items[objNumber] = obj;
                        updated = true;
                        break;
                    }
                }

                if (!updated)
                {
                    comboBox.Items.Add(obj);
                }
            }
        }

        private void ChoosenCluster_LostFocus(object sender, EventArgs e)
        {
            var combobox = (ComboBox)sender;
            var cluster = (Cluster?)combobox.SelectedItem;

            if (cluster == null) return;
            if (cluster.Blocks == null) return;

            UpdateChoosenCombobox(cluster.Blocks, ChoosenBlock);

            if (cluster.Name != null)
                ClusterName.Text = cluster.Name;
        }

        private void ChoosenBlock_LostFocus(object sender, EventArgs e)
        {
            var combobox = (ComboBox)sender;
            var block = (Block?)combobox.SelectedItem;

            if (block == null) return;

            if (block.Name != null)
                BlockName.Text = block.Name;
        }

        private void UpdateSensorGrid(IEnumerable<Sensor> sensors)
        {
            SensorsGrid.Rows.Clear();

            int height = sensors.Count();
            int width = numberOfColumns;

            int rowHeight = (SensorsGrid.Size.Height - 40) / (height - 1);
            int columnWidth = (SensorsGrid.Size.Width - 45) / (width - 1);


        }

        private void ClusterName_LostFocus(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            var cluster = (Cluster?)ChoosenCluster.SelectedItem;

            if (cluster == null) return;

            cluster.Name = textbox.Text;
            Saver.Save(cluster);
        }

        private void BlockName_LostFocus(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            var block = (Block?)ChoosenBlock.SelectedItem;

            if (block == null) return;

            block.Name = textbox.Text;
            Saver.Save(block);
        }

        private void ChoosenBlockLabel_Click(object sender, EventArgs e)
        {

        }

        

        private void ChoosenClusterLabel_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}