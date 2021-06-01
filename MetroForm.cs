using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Metro
{
    public partial class MetroForm : Form
    {
        private EditStationForm editStationForm;
        bool columnClickCounter = true;

        public MetroForm()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        } 

        private void startbutton_Click(object sender, EventArgs e)
        {
            if (startTimePicker.Value >= finishTimePicker.Value)
            {
                MessageBox.Show(
                "Некорректно указан интервал моделирования",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if(MetroData.StationList.Count == 0)
            {
                MessageBox.Show(
                "Список станций пуст",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else 
            {
                Metro myMetro = new Metro(MetroData.StationList);
                Simulation mySimulation = new Simulation(startTimePicker.Value, finishTimePicker.Value, myMetro);

                mySimulation.Run();

                currentTimeLabel.Text = mySimulation.CurrentTime.ToString("f");

                Redisplay();
            }           
        }

        private void addStation_Click(object sender, EventArgs e)
        {
            MetroData.StationList.Add(new Station());
            Redisplay();
        }

        private void deleteStation_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in stationListView.SelectedItems)
            {
                MetroData.StationList.RemoveAt(lvi.Index);
                stationListView.Items.Remove(lvi);
            }
        }

        private void stationListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (editStationForm == null)
            {
                editStationForm = new EditStationForm(stationListView.SelectedIndices[0]);
                editStationForm.FormClosed += new FormClosedEventHandler(editStationForm_FormClosed);
            }
            editStationForm.Show();
        }

        void editStationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Redisplay();
            editStationForm = null;
        }

        private void stationListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (MetroData.StationList.Count != 0)
            {
                if (e.Column == 0)
                {
                    if (columnClickCounter)
                    {
                        var sortedStationList = MetroData.StationList.OrderBy(station => station.StationName);
                        MetroData.StationList = sortedStationList.ToList();
                        columnClickCounter = !columnClickCounter;
                    }
                    else
                    {
                        var sortedStationList = MetroData.StationList.OrderByDescending(station => station.StationName);
                        MetroData.StationList = sortedStationList.ToList();
                        columnClickCounter = !columnClickCounter;
                    }
                }

                if (e.Column == 1)
                {
                    if (columnClickCounter)
                    {
                        var sortedStationList = MetroData.StationList.OrderBy(station => station.StationLine);
                        MetroData.StationList = sortedStationList.ToList();
                        columnClickCounter = !columnClickCounter;
                    }
                    else
                    {
                        var sortedStationList = MetroData.StationList.OrderByDescending(station => station.StationLine);
                        MetroData.StationList = sortedStationList.ToList();
                        columnClickCounter = !columnClickCounter;
                    }
                }
                Redisplay();
            }
        }

        private void Redisplay()
        {
            startTimeLabel.Text = MetroData.StartTime.ToString("f");
            finishTimeLabel.Text = MetroData.FinishTime.ToString("f");

            tranportationCountLabel.Text = MetroData.TransportationCount.ToString();
            countLabel.Text = MetroData.TotalNumberOfPeople.ToString();


            stationListView.View = View.Details;
            stationListView.Items.Clear();

            foreach (Station station in MetroData.StationList)
            {
                ListViewItem slvi = new ListViewItem(station.StationName);
                slvi.SubItems.Add(station.StationLine);
                slvi.SubItems.Add(station is SubwayStation ? "*" : "");
                stationListView.Items.Add(slvi);
            }

            timeTableListView.View = View.Details;
            timeTableListView.Items.Clear();

            foreach ((string, TimeSpan) time in MetroData.TimeTable)
            {
                ListViewItem tlvi = new ListViewItem(time.Item1);
                tlvi.SubItems.Add(time.Item2.Minutes.ToString("D2") + ":" + time.Item2.Seconds.ToString("D2"));
                timeTableListView.Items.Add(tlvi);
            }

            statisticsChart.Series[0].Points.Clear();
            foreach (var point in MetroData.PeopleStats)
            {
                statisticsChart.Series[0].Points.AddXY(point.Key.Hour, point.Value);
            }
        }

        private void makeNodeButton_Click(object sender, EventArgs e)
        {
            if (stationListView.SelectedItems.Count == 2 &&
                MetroData.StationList[stationListView.SelectedIndices[0]].StationLine != MetroData.StationList[stationListView.SelectedIndices[1]].StationLine)
            {
                SubwayStation newSubwayStation1 = new SubwayStation(MetroData.StationList[stationListView.SelectedIndices[0]]);
                newSubwayStation1.MateStationName = MetroData.StationList[stationListView.SelectedIndices[1]].StationName;
                MetroData.StationList.RemoveAt(stationListView.SelectedIndices[0]);
                MetroData.StationList.Insert(stationListView.SelectedIndices[0], newSubwayStation1);

                SubwayStation newSubwayStation2 = new SubwayStation(MetroData.StationList[stationListView.SelectedIndices[1]]);
                newSubwayStation2.MateStationName = MetroData.StationList[stationListView.SelectedIndices[0]].StationName;
                MetroData.StationList.RemoveAt(stationListView.SelectedIndices[1]);
                MetroData.StationList.Insert(stationListView.SelectedIndices[1], newSubwayStation2);

                Redisplay();
            }
            else
            {
                MessageBox.Show(
                "Для создания транспортного узла\nнеобходимо выделить две станции,\nнаходящиеся на разных линиях",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
        private void deleteNode_Click(object sender, EventArgs e)
        {
            if (stationListView.SelectedItems.Count == 2 &&
                MetroData.StationList[stationListView.SelectedIndices[0]] is SubwayStation &&
                MetroData.StationList[stationListView.SelectedIndices[1]] is SubwayStation)
            {
                Station newStation1 = new Station((SubwayStation)MetroData.StationList[stationListView.SelectedIndices[0]]);
                MetroData.StationList.RemoveAt(stationListView.SelectedIndices[0]);
                MetroData.StationList.Insert(stationListView.SelectedIndices[0], newStation1);

                Station newStation2 = new Station((SubwayStation)MetroData.StationList[stationListView.SelectedIndices[1]]);
                MetroData.StationList.RemoveAt(stationListView.SelectedIndices[1]);
                MetroData.StationList.Insert(stationListView.SelectedIndices[1], newStation2);

                Redisplay();
            }
            else
            {
                MessageBox.Show(
                "Выбраны некорректные станции для развязки",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void addHour_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = new TimeSpan();
            if (MetroData.TimeTable.Any(rh => rh.Item1 == timeBox.Text))
            {
                MessageBox.Show(
                "Интервал движения для данного времени уже существует",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (!TimeSpan.TryParse("00:" + intervalTextBox.Text, out timeSpan) || timeSpan.TotalSeconds == 0)
            {
                MessageBox.Show(
                "Некорректно указан интервал",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                MetroData.TimeTable.Add((timeBox.SelectedItem.ToString(), timeSpan));
            }
            Redisplay();
        }

        private void deleteHour_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem time in timeTableListView.SelectedItems)
            {
                MetroData.TimeTable.RemoveAt(time.Index);
                timeTableListView.Items.Remove(time);
            }
        }

        private void MetroForm_Load(object sender, EventArgs e)
        {            
            timeBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FBD = new FolderBrowserDialog())
            {
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    string folderName = FBD.SelectedPath;
                    NetDataContractSerializer serializer = new NetDataContractSerializer();
                    using (FileStream stream = new FileStream(folderName + @"\data.xml", FileMode.Create))
                    {
                        MetroDataSerializable metroDataSerializable = new MetroDataSerializable();
                        serializer.Serialize(stream, metroDataSerializable);
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

                    NetDataContractSerializer serializer = new NetDataContractSerializer();
                    using (FileStream stream = new FileStream(path, FileMode.Open))
                    {
                        MetroDataSerializable data = (MetroDataSerializable)serializer.Deserialize(stream);
                        MetroData.Update(data);
                        Redisplay();
                    }
                }
            }
        }

        private void timeTableListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                if (columnClickCounter)
                {
                    var sortedTimeTable = MetroData.TimeTable.OrderBy(time => time.Item1);
                    MetroData.TimeTable = sortedTimeTable.ToList();
                    columnClickCounter = !columnClickCounter;
                }
                else
                {
                    var sortedTimeTable = MetroData.TimeTable.OrderByDescending(time => time.Item1);
                    MetroData.TimeTable = sortedTimeTable.ToList();
                    columnClickCounter = !columnClickCounter;
                }
            }

            if (e.Column == 1)
            {
                if (columnClickCounter)
                {
                    var sortedTimeTable = MetroData.TimeTable.OrderBy(time => time.Item2);
                    MetroData.TimeTable = sortedTimeTable.ToList();
                    columnClickCounter = !columnClickCounter;
                }
                else
                {
                    var sortedTimeTable = MetroData.TimeTable.OrderByDescending(time => time.Item2);
                    MetroData.TimeTable = sortedTimeTable.ToList();
                    columnClickCounter = !columnClickCounter;
                }
            }
            Redisplay();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            MetroTest myTest = new MetroTest();
            myTest.Run();

            resultLabel.Text = "успешно";
            testCounterLabel.Text = myTest.testCounter.ToString();
            testNumberLabel.Text = MetroTest.testNumber.ToString();
        }
    }
}
