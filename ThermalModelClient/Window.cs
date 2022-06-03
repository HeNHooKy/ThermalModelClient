using System.ComponentModel;
using ThermalModelClient.Model;

namespace ThermalModelClient
{
    public partial class Window : Form
    {
        public BindingSource SensorsSource;

        private BindingList<Sensor> sensorsList 
            = new BindingList<Sensor>();

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
            SensorsSource = new BindingSource(sensorsList, null);
            SensorsGrid.DataSource = SensorsSource;

            while (true)
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

            UpdateSensorsGrid();
        }

        private void UpdateChoosenCombobox
            (IEnumerable<IdClass> objects, ComboBox comboBox)
        {
            foreach (var item in comboBox.Items.Cast<IdClass>().ToList())
            {
                var obj = objects.FirstOrDefault(o => o.Id == item.Id);
                if(obj == null)
                {
                    comboBox.Items.Remove(item);
                }
            }

            var copyOfChoosenObjItems = comboBox.Items.Cast<IdClass>().ToList();

            foreach (var obj in objects)
            {
                bool updated = false;
                for (int objNumber = 0;
                    objNumber < copyOfChoosenObjItems.Count();
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

        private void UpdateDataGrid(IEnumerable<Sensor> sensors)
        {
            foreach (var item in sensorsList.ToList())
            {
                var obj = sensors.FirstOrDefault(o => o.Id == item.Id);
                if (obj == null)
                {
                    sensorsList.Remove(item);
                }
            }

            var copyOfSensorsList = sensorsList.ToList();

            foreach (var obj in sensors)
            {
                bool updated = false;
                for (int objNumber = 0;
                    objNumber < copyOfSensorsList.Count;
                    objNumber++)
                {
                    var clusterInChoosen = (IdClass?)sensorsList[objNumber];

                    if (clusterInChoosen == null)
                        throw new ArgumentNullException($"{obj.GetType().Name} in choosen can't be null!");

                    if (obj.Id == clusterInChoosen.Id)
                    {
                        sensorsList[objNumber] = obj;
                        updated = true;
                        break;
                    }
                }

                if (!updated)
                {
                    sensorsList.Add(obj);
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

            UpdateSensorsGrid();
        }

        private void UpdateSensorsGrid()
        {
            if (SensorsGrid.Focused) return;
            if (SensorsGrid.ContainsFocus) return;

            var block = (Block?)ChoosenBlock.SelectedItem;

            if (block == null) return;
            if (block.Sensors == null) return;
            var sensors = block.Sensors.ToArray();

            UpdateDataGrid(sensors);
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

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var sensor = sensorsList[e.RowIndex];
            Saver.Save(sensor);
        }

        private void SensorsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;

            var sensor = sensorsList[e.RowIndex];

            var dataWindow = new DataWindow(sensor);
            dataWindow.ShowDialog();
        }
    }
}