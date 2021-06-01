namespace Metro
{
    partial class MetroForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.testCounterLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.finishTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.finishTimeLabel = new System.Windows.Forms.Label();
            this.tranportationCountLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteNode = new System.Windows.Forms.Button();
            this.makeNodeButton = new System.Windows.Forms.Button();
            this.deleteStation = new System.Windows.Forms.Button();
            this.stationListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lineColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stationListLabel = new System.Windows.Forms.Label();
            this.addStation = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.intervalTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteHour = new System.Windows.Forms.Button();
            this.addHour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeTableListView = new System.Windows.Forms.ListView();
            this.hourColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.intervalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.testNumberLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.testNumberLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.testCounterLabel);
            this.groupBox3.Controls.Add(this.testButton);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // testCounterLabel
            // 
            resources.ApplyResources(this.testCounterLabel, "testCounterLabel");
            this.testCounterLabel.Name = "testCounterLabel";
            // 
            // testButton
            // 
            resources.ApplyResources(this.testButton, "testButton");
            this.testButton.Name = "testButton";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.finishTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.startTimePicker);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // finishTimePicker
            // 
            resources.ApplyResources(this.finishTimePicker, "finishTimePicker");
            this.finishTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finishTimePicker.Name = "finishTimePicker";
            this.finishTimePicker.Value = new System.DateTime(2020, 11, 11, 0, 0, 0, 0);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // startTimePicker
            // 
            resources.ApplyResources(this.startTimePicker, "startTimePicker");
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Value = new System.DateTime(2020, 11, 10, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startTimeLabel);
            this.groupBox2.Controls.Add(this.finishTimeLabel);
            this.groupBox2.Controls.Add(this.tranportationCountLabel);
            this.groupBox2.Controls.Add(this.countLabel);
            this.groupBox2.Controls.Add(this.currentTimeLabel);
            this.groupBox2.Controls.Add(this.label10);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // startTimeLabel
            // 
            resources.ApplyResources(this.startTimeLabel, "startTimeLabel");
            this.startTimeLabel.Name = "startTimeLabel";
            // 
            // finishTimeLabel
            // 
            resources.ApplyResources(this.finishTimeLabel, "finishTimeLabel");
            this.finishTimeLabel.Name = "finishTimeLabel";
            // 
            // tranportationCountLabel
            // 
            resources.ApplyResources(this.tranportationCountLabel, "tranportationCountLabel");
            this.tranportationCountLabel.Name = "tranportationCountLabel";
            // 
            // countLabel
            // 
            resources.ApplyResources(this.countLabel, "countLabel");
            this.countLabel.Name = "countLabel";
            // 
            // currentTimeLabel
            // 
            resources.ApplyResources(this.currentTimeLabel, "currentTimeLabel");
            this.currentTimeLabel.Name = "currentTimeLabel";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteNode);
            this.tabPage2.Controls.Add(this.makeNodeButton);
            this.tabPage2.Controls.Add(this.deleteStation);
            this.tabPage2.Controls.Add(this.stationListView);
            this.tabPage2.Controls.Add(this.stationListLabel);
            this.tabPage2.Controls.Add(this.addStation);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteNode
            // 
            resources.ApplyResources(this.deleteNode, "deleteNode");
            this.deleteNode.Name = "deleteNode";
            this.deleteNode.UseVisualStyleBackColor = true;
            this.deleteNode.Click += new System.EventHandler(this.deleteNode_Click);
            // 
            // makeNodeButton
            // 
            resources.ApplyResources(this.makeNodeButton, "makeNodeButton");
            this.makeNodeButton.Name = "makeNodeButton";
            this.makeNodeButton.UseVisualStyleBackColor = true;
            this.makeNodeButton.Click += new System.EventHandler(this.makeNodeButton_Click);
            // 
            // deleteStation
            // 
            resources.ApplyResources(this.deleteStation, "deleteStation");
            this.deleteStation.Name = "deleteStation";
            this.deleteStation.UseVisualStyleBackColor = true;
            this.deleteStation.Click += new System.EventHandler(this.deleteStation_Click);
            // 
            // stationListView
            // 
            this.stationListView.AllowDrop = true;
            this.stationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.lineColumn,
            this.nodeColumn});
            this.stationListView.FullRowSelect = true;
            this.stationListView.GridLines = true;
            this.stationListView.HideSelection = false;
            resources.ApplyResources(this.stationListView, "stationListView");
            this.stationListView.Name = "stationListView";
            this.stationListView.UseCompatibleStateImageBehavior = false;
            this.stationListView.View = System.Windows.Forms.View.Details;
            this.stationListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.stationListView_ColumnClick);
            this.stationListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.stationListView_MouseDoubleClick);
            // 
            // nameColumn
            // 
            resources.ApplyResources(this.nameColumn, "nameColumn");
            // 
            // lineColumn
            // 
            resources.ApplyResources(this.lineColumn, "lineColumn");
            // 
            // nodeColumn
            // 
            resources.ApplyResources(this.nodeColumn, "nodeColumn");
            // 
            // stationListLabel
            // 
            resources.ApplyResources(this.stationListLabel, "stationListLabel");
            this.stationListLabel.Name = "stationListLabel";
            // 
            // addStation
            // 
            resources.ApplyResources(this.addStation, "addStation");
            this.addStation.Name = "addStation";
            this.addStation.UseVisualStyleBackColor = true;
            this.addStation.Click += new System.EventHandler(this.addStation_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.intervalTextBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.timeBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.deleteHour);
            this.tabPage3.Controls.Add(this.addHour);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.timeTableListView);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // intervalTextBox
            // 
            resources.ApplyResources(this.intervalTextBox, "intervalTextBox");
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // timeBox
            // 
            this.timeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Items.AddRange(new object[] {
            resources.GetString("timeBox.Items"),
            resources.GetString("timeBox.Items1"),
            resources.GetString("timeBox.Items2"),
            resources.GetString("timeBox.Items3"),
            resources.GetString("timeBox.Items4"),
            resources.GetString("timeBox.Items5"),
            resources.GetString("timeBox.Items6"),
            resources.GetString("timeBox.Items7"),
            resources.GetString("timeBox.Items8"),
            resources.GetString("timeBox.Items9"),
            resources.GetString("timeBox.Items10"),
            resources.GetString("timeBox.Items11"),
            resources.GetString("timeBox.Items12"),
            resources.GetString("timeBox.Items13"),
            resources.GetString("timeBox.Items14"),
            resources.GetString("timeBox.Items15"),
            resources.GetString("timeBox.Items16"),
            resources.GetString("timeBox.Items17"),
            resources.GetString("timeBox.Items18"),
            resources.GetString("timeBox.Items19"),
            resources.GetString("timeBox.Items20"),
            resources.GetString("timeBox.Items21"),
            resources.GetString("timeBox.Items22"),
            resources.GetString("timeBox.Items23")});
            resources.ApplyResources(this.timeBox, "timeBox");
            this.timeBox.Name = "timeBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // deleteHour
            // 
            resources.ApplyResources(this.deleteHour, "deleteHour");
            this.deleteHour.Name = "deleteHour";
            this.deleteHour.UseVisualStyleBackColor = true;
            this.deleteHour.Click += new System.EventHandler(this.deleteHour_Click);
            // 
            // addHour
            // 
            resources.ApplyResources(this.addHour, "addHour");
            this.addHour.Name = "addHour";
            this.addHour.UseVisualStyleBackColor = true;
            this.addHour.Click += new System.EventHandler(this.addHour_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // timeTableListView
            // 
            this.timeTableListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.timeTableListView.AutoArrange = false;
            this.timeTableListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hourColumn,
            this.intervalColumn});
            this.timeTableListView.FullRowSelect = true;
            this.timeTableListView.GridLines = true;
            this.timeTableListView.HideSelection = false;
            resources.ApplyResources(this.timeTableListView, "timeTableListView");
            this.timeTableListView.Name = "timeTableListView";
            this.timeTableListView.UseCompatibleStateImageBehavior = false;
            this.timeTableListView.View = System.Windows.Forms.View.Details;
            this.timeTableListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.timeTableListView_ColumnClick);
            // 
            // hourColumn
            // 
            resources.ApplyResources(this.hourColumn, "hourColumn");
            // 
            // intervalColumn
            // 
            resources.ApplyResources(this.intervalColumn, "intervalColumn");
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.statisticsChart);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // statisticsChart
            // 
            chartArea1.AxisX.Interval = 2D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.statisticsChart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.statisticsChart.Legends.Add(legend1);
            resources.ApplyResources(this.statisticsChart, "statisticsChart");
            this.statisticsChart.Name = "statisticsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Пассажиропоток";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt64;
            this.statisticsChart.Series.Add(series1);
            // 
            // startbutton
            // 
            resources.ApplyResources(this.startbutton, "startbutton");
            this.startbutton.Name = "startbutton";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // exitbutton
            // 
            resources.ApplyResources(this.exitbutton, "exitbutton");
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            resources.ApplyResources(this.openButton, "openButton");
            this.openButton.Name = "openButton";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // testNumberLabel
            // 
            resources.ApplyResources(this.testNumberLabel, "testNumberLabel");
            this.testNumberLabel.Name = "testNumberLabel";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // resultLabel
            // 
            resources.ApplyResources(this.resultLabel, "resultLabel");
            this.resultLabel.Name = "resultLabel";
            // 
            // MetroForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MetroForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MetroForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker finishTimePicker;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button addStation;
        private System.Windows.Forms.Label stationListLabel;
        private System.Windows.Forms.ListView stationListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader lineColumn;
        private System.Windows.Forms.Button deleteStation;
        private System.Windows.Forms.ListView timeTableListView;
        private System.Windows.Forms.ColumnHeader hourColumn;
        private System.Windows.Forms.ColumnHeader intervalColumn;
        private System.Windows.Forms.Button deleteHour;
        private System.Windows.Forms.Button addHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button makeNodeButton;
        private System.Windows.Forms.ColumnHeader nodeColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox timeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.MaskedTextBox intervalTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button deleteNode;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tranportationCountLabel;
        private System.Windows.Forms.Label finishTimeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label testCounterLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label testNumberLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resultLabel;
    }
}

