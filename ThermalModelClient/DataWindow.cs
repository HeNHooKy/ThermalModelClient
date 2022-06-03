using System.ComponentModel;
using ThermalModelClient.Model;

namespace ThermalModelClient
{
    public partial class DataWindow : Form
    {
        public BindingSource SensorsSource;
        private readonly Sensor sensor;

        private readonly BindingList<Data> dataList = new();


        public DataWindow(Sensor sensor)
        {
            this.sensor = sensor;
            SensorsSource = new BindingSource(dataList, null);

            InitializeComponent();
        }

        private void DataWindow_Load(object sender, EventArgs e)
        {
            LoadAllFields();
            var data = ConnectionLayer.GetData(sensor);
            

            if (data == null) return;

            data = data.OrderByDescending(d => d.CheckDate);

            foreach (var value in data)
            {
                dataList.Add(value);
            }

            DataDataGrid.DataSource = SensorsSource;
        }

        private void LoadAllFields()
        {
            SensorName.Text = sensor.Name;
            SensorId.Text = sensor.Id.ToString();
            XCoord.Text = sensor.CoordX;
            YCoord.Text = sensor.CoordY;
            ZCoord.Text = sensor.CoordZ;
            LastCheck.Text = sensor.LastCheck.ToString();
            LastValue.Text = sensor.LastValue;
            BlockId.Text = sensor.BlockId.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            sensor.Name = SensorName.Text;
            sensor.CoordX = XCoord.Text;
            sensor.CoordY = YCoord.Text;
            sensor.CoordZ = ZCoord.Text;

            Saver.Save(sensor);

            MessageBox.Show("All data saved!");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
