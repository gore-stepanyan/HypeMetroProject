
namespace Metro
{
    partial class EditStationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStationForm));
            this.timeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stationNameTextBox = new System.Windows.Forms.TextBox();
            this.stationLineTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minimumUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rushHourListView = new System.Windows.Forms.ListView();
            this.timeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stressUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteRushHourButton = new System.Windows.Forms.Button();
            this.addRushHourButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stressUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timeBox
            // 
            this.timeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeBox.FormatString = "t";
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
            this.timeBox.SelectedIndexChanged += new System.EventHandler(this.timeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // stationNameTextBox
            // 
            this.stationNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.stationNameTextBox, "stationNameTextBox");
            this.stationNameTextBox.Name = "stationNameTextBox";
            this.stationNameTextBox.TextChanged += new System.EventHandler(this.stationNameTextBox_TextChanged);
            // 
            // stationLineTextBox
            // 
            this.stationLineTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.stationLineTextBox, "stationLineTextBox");
            this.stationLineTextBox.Name = "stationLineTextBox";
            this.stationLineTextBox.TextChanged += new System.EventHandler(this.stationLineTextBox_TextChanged);
            // 
            // applyButton
            // 
            resources.ApplyResources(this.applyButton, "applyButton");
            this.applyButton.Name = "applyButton";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stationLineTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stationNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.minimumUpDown);
            this.groupBox2.Controls.Add(this.maximumUpDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // minimumUpDown
            // 
            resources.ApplyResources(this.minimumUpDown, "minimumUpDown");
            this.minimumUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minimumUpDown.Name = "minimumUpDown";
            this.minimumUpDown.ValueChanged += new System.EventHandler(this.minimumUpDown_ValueChanged);
            // 
            // maximumUpDown
            // 
            resources.ApplyResources(this.maximumUpDown, "maximumUpDown");
            this.maximumUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maximumUpDown.Name = "maximumUpDown";
            this.maximumUpDown.ValueChanged += new System.EventHandler(this.maximumUpDown_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Name = "label4";
            // 
            // rushHourListView
            // 
            this.rushHourListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timeColumn,
            this.stressColumn});
            this.rushHourListView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rushHourListView.FullRowSelect = true;
            this.rushHourListView.HideSelection = false;
            resources.ApplyResources(this.rushHourListView, "rushHourListView");
            this.rushHourListView.Name = "rushHourListView";
            this.rushHourListView.UseCompatibleStateImageBehavior = false;
            this.rushHourListView.View = System.Windows.Forms.View.Details;
            // 
            // timeColumn
            // 
            resources.ApplyResources(this.timeColumn, "timeColumn");
            // 
            // stressColumn
            // 
            resources.ApplyResources(this.stressColumn, "stressColumn");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stressUpDown);
            this.groupBox3.Controls.Add(this.timeBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.deleteRushHourButton);
            this.groupBox3.Controls.Add(this.addRushHourButton);
            this.groupBox3.Controls.Add(this.rushHourListView);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // stressUpDown
            // 
            resources.ApplyResources(this.stressUpDown, "stressUpDown");
            this.stressUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stressUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.stressUpDown.Name = "stressUpDown";
            this.stressUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.stressUpDown.ValueChanged += new System.EventHandler(this.stressUpDown_ValueChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Name = "label5";
            // 
            // deleteRushHourButton
            // 
            this.deleteRushHourButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.deleteRushHourButton, "deleteRushHourButton");
            this.deleteRushHourButton.Name = "deleteRushHourButton";
            this.deleteRushHourButton.UseVisualStyleBackColor = true;
            this.deleteRushHourButton.Click += new System.EventHandler(this.deleteRushHourButton_Click);
            // 
            // addRushHourButton
            // 
            this.addRushHourButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.addRushHourButton, "addRushHourButton");
            this.addRushHourButton.Name = "addRushHourButton";
            this.addRushHourButton.UseVisualStyleBackColor = true;
            this.addRushHourButton.Click += new System.EventHandler(this.addRushHourButton_Click);
            // 
            // EditStationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.applyButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditStationForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.EditStationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stressUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stationNameTextBox;
        private System.Windows.Forms.TextBox stationLineTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown minimumUpDown;
        private System.Windows.Forms.NumericUpDown maximumUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView rushHourListView;
        private System.Windows.Forms.ColumnHeader timeColumn;
        private System.Windows.Forms.ColumnHeader stressColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteRushHourButton;
        private System.Windows.Forms.Button addRushHourButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown stressUpDown;
        private System.Windows.Forms.ComboBox timeBox;
    }
}