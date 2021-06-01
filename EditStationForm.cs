using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Metro
{
    public partial class EditStationForm : Form
    {
        private string stationName;
        private string stationLine;

        private int maximum;
        private int minimum;

        private string time;
        private int stress = 100;

        private List<(string, int)> rushHourTable = new List<(string, int)>();

        private int index;

        public EditStationForm(int index)
        {
            InitializeComponent();
            this.index = index;
            Synchronize(MetroData.StationList[index]);
            Redisplay();
        }

        private void EditStationForm_Load(object sender, EventArgs e)
        {
            timeBox.SelectedIndex = 0;
        }

        private void stationLineTextBox_TextChanged(object sender, EventArgs e)
        {
            stationLine = stationLineTextBox.Text;
        }

        private void stationNameTextBox_TextChanged(object sender, EventArgs e)
        {
            stationName = stationNameTextBox.Text;
        }

        private void maximumUpDown_ValueChanged(object sender, EventArgs e)
        {
            maximum = (int)maximumUpDown.Value;
        }

        private void minimumUpDown_ValueChanged(object sender, EventArgs e)
        {
            minimum = (int)minimumUpDown.Value;
        }

        private void timeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            time = timeBox.SelectedItem.ToString();
        }

        private void stressUpDown_ValueChanged(object sender, EventArgs e)
        {
            stress = (int)stressUpDown.Value;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (MetroData.StationList.Count(s => s.StationName == stationName) > 1)
            {
                MessageBox.Show(
                "Станция с введённым названием уже существует",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (maximumUpDown.Value < minimumUpDown.Value)
            {
                MessageBox.Show(
                "Максимальное значение не может\nбыть меньше минимального",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                Apply();
                Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Apply();
            using (FolderBrowserDialog FBD = new FolderBrowserDialog())
            {
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    string folderName = FBD.SelectedPath;
                    XmlSerializer serializer = new XmlSerializer(typeof(Station));
                    using (StreamWriter streamWriter = new StreamWriter(folderName + @"\" + MetroData.StationList[index].StationName + ".xml"))
                    {
                        serializer.Serialize(streamWriter, MetroData.StationList[index]);
                    }
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    string path = OFD.FileName;

                    XmlSerializer serializer = new XmlSerializer(typeof(Station));
                    using (StreamReader streamReader = new StreamReader(path))
                    {
                        Station newStation = (Station)serializer.Deserialize(streamReader);

                        if (MetroData.StationList.Any(s => s.StationName == newStation.StationName))
                        {
                            MessageBox.Show(
                            "Станция, которую вы пытаетесь добавить, уже существует",
                            "Предупреждение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Synchronize(newStation);
                            Redisplay();
                        }
                    }
                }
            }
        }

        private void Redisplay()
        {
            stationLineTextBox.Text = stationLine;
            stationNameTextBox.Text = stationName;
            maximumUpDown.Value = maximum;
            minimumUpDown.Value = minimum;

            rushHourListView.View = View.Details;
            rushHourListView.Items.Clear();
            foreach (var rushHour in rushHourTable)
            {
                ListViewItem lvi = new ListViewItem(rushHour.Item1);
                lvi.SubItems.Add(rushHour.Item2.ToString());
                rushHourListView.Items.Add(lvi);
            }
        }

        private void Synchronize(Station station)
        {
            stationLine = station.StationLine;
            stationName = station.StationName;
            maximum = station.Maximum;
            minimum = station.Minimum;
            rushHourTable.Clear();
            rushHourTable.AddRange(station.RushHourTable);
        }

        private void Apply()
        {
            MetroData.StationList[index].StationLine = stationLine;
            MetroData.StationList[index].StationName = stationName;
            MetroData.StationList[index].Maximum = maximum;
            MetroData.StationList[index].Minimum = minimum;
            MetroData.StationList[index].RushHourTable.Clear();
            MetroData.StationList[index].RushHourTable.AddRange(rushHourTable);
        }

        private void addRushHourButton_Click(object sender, EventArgs e)
        {
            if (rushHourTable.Any(rh => rh.Item1 == time))
            {
                MessageBox.Show(
                "Вводимый час пик уже существует",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                rushHourTable.Add((time, stress));
            }
            Redisplay();
        }

        private void deleteRushHourButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem rushHour in rushHourListView.SelectedItems)
            {
                rushHourTable.RemoveAt(rushHour.Index);
                rushHourListView.Items.Remove(rushHour);
            }
        }
    }
}
