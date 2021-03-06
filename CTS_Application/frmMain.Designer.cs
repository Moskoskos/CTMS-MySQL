﻿namespace CTS_Application
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCV = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscribersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpHistoryStart = new System.Windows.Forms.DateTimePicker();
            this.dtpHistoryEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chrtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.historianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetToGrah = new CTS_Application.DataSetToGrah();
            this.historianTableAdapter = new CTS_Application.DataSetToGrahTableAdapters.historianTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alarmeventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimerecordedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmhistorianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctsDataSetAlarm = new CTS_Application.ctsDataSetAlarm();
            this.alarm_historianTableAdapter = new CTS_Application.ctsDataSetAlarmTableAdapters.alarm_historianTableAdapter();
            this.tmrUpdateGui = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblStateConst = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsprgBat = new System.Windows.Forms.ToolStripProgressBar();
            this.tslblBat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblDBStatConst = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblDBStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblRAMConst = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblRAM = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rbtnRealtime = new System.Windows.Forms.RadioButton();
            this.rbtnHistory = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRealtimeUnit = new System.Windows.Forms.ComboBox();
            this.cboRealtimeRange = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToGrah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmhistorianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctsDataSetAlarm)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 26;
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV.ForeColor = System.Drawing.Color.Blue;
            this.lblCV.Location = new System.Drawing.Point(368, 80);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(60, 31);
            this.lblCV.TabIndex = 27;
            this.lblCV.Text = "N/A";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.subscribersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // subscribersToolStripMenuItem
            // 
            this.subscribersToolStripMenuItem.Name = "subscribersToolStripMenuItem";
            this.subscribersToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.subscribersToolStripMenuItem.Text = "Subscribers";
            this.subscribersToolStripMenuItem.Click += new System.EventHandler(this.subscribersToolStripMenuItem_Click);
            // 
            // dtpHistoryStart
            // 
            this.dtpHistoryStart.Location = new System.Drawing.Point(135, 66);
            this.dtpHistoryStart.Name = "dtpHistoryStart";
            this.dtpHistoryStart.Size = new System.Drawing.Size(139, 20);
            this.dtpHistoryStart.TabIndex = 7;
            this.dtpHistoryStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpHistoryEnd
            // 
            this.dtpHistoryEnd.Location = new System.Drawing.Point(135, 111);
            this.dtpHistoryEnd.Name = "dtpHistoryEnd";
            this.dtpHistoryEnd.Size = new System.Drawing.Size(139, 20);
            this.dtpHistoryEnd.TabIndex = 8;
            this.dtpHistoryEnd.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "End Date";
            // 
            // chrtTemp
            // 
            chartArea1.AxisX.LabelStyle.Format = "dd/MM/yy HH:mm";
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Format = "#0°C";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "Temperature";
            this.chrtTemp.ChartAreas.Add(chartArea1);
            this.chrtTemp.DataSource = this.historianBindingSource;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chrtTemp.Legends.Add(legend1);
            this.chrtTemp.Location = new System.Drawing.Point(8, 144);
            this.chrtTemp.Name = "chrtTemp";
            series1.BorderWidth = 2;
            series1.ChartArea = "Temperature";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.LabelFormat = "\"yyyy-MM-dd HH:mm\"";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "datetime_recorded";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "value";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.ChartArea = "Temperature";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Orange;
            series2.LabelFormat = "\"yyyy-MM-dd HH:mm\"";
            series2.Legend = "Legend1";
            series2.Name = "SpLow";
            series2.XValueMember = "datetime_recorded";
            series2.YValueMembers = "setpoint_low";
            series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series3.ChartArea = "Temperature";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.LabelFormat = "\"yyyy-MM-dd HH:mm\"";
            series3.Legend = "Legend1";
            series3.Name = "SpHigh";
            series3.XValueMember = "datetime_recorded";
            series3.YValueMembers = "setpoint_high";
            this.chrtTemp.Series.Add(series1);
            this.chrtTemp.Series.Add(series2);
            this.chrtTemp.Series.Add(series3);
            this.chrtTemp.Size = new System.Drawing.Size(1156, 335);
            this.chrtTemp.TabIndex = 30;
            this.chrtTemp.Text = "chart1";
            // 
            // historianBindingSource
            // 
            this.historianBindingSource.DataMember = "historian";
            this.historianBindingSource.DataSource = this.dataSetToGrah;
            // 
            // dataSetToGrah
            // 
            this.dataSetToGrah.DataSetName = "DataSetToGrah";
            this.dataSetToGrah.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historianTableAdapter
            // 
            this.historianTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Current Temperature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Start Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alarmeventidDataGridViewTextBoxColumn,
            this.datetimerecordedDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alarmhistorianBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(536, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 104);
            this.dataGridView1.TabIndex = 60;
            // 
            // alarmeventidDataGridViewTextBoxColumn
            // 
            this.alarmeventidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alarmeventidDataGridViewTextBoxColumn.DataPropertyName = "alarm_event_id";
            this.alarmeventidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.alarmeventidDataGridViewTextBoxColumn.Name = "alarmeventidDataGridViewTextBoxColumn";
            this.alarmeventidDataGridViewTextBoxColumn.ReadOnly = true;
            this.alarmeventidDataGridViewTextBoxColumn.Width = 43;
            // 
            // datetimerecordedDataGridViewTextBoxColumn
            // 
            this.datetimerecordedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datetimerecordedDataGridViewTextBoxColumn.DataPropertyName = "datetime_recorded";
            this.datetimerecordedDataGridViewTextBoxColumn.HeaderText = "Occurred";
            this.datetimerecordedDataGridViewTextBoxColumn.Name = "datetimerecordedDataGridViewTextBoxColumn";
            this.datetimerecordedDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimerecordedDataGridViewTextBoxColumn.Width = 76;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alarmhistorianBindingSource
            // 
            this.alarmhistorianBindingSource.DataMember = "alarm_historian";
            this.alarmhistorianBindingSource.DataSource = this.ctsDataSetAlarm;
            // 
            // ctsDataSetAlarm
            // 
            this.ctsDataSetAlarm.DataSetName = "ctsDataSetAlarm";
            this.ctsDataSetAlarm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alarm_historianTableAdapter
            // 
            this.alarm_historianTableAdapter.ClearBeforeFill = true;
            // 
            // tmrUpdateGui
            // 
            this.tmrUpdateGui.Interval = 2000;
            this.tmrUpdateGui.Tick += new System.EventHandler(this.tmrUpdateGui_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblStateConst,
            this.tslblState,
            this.tsprgBat,
            this.tslblBat,
            this.tslblDBStatConst,
            this.tslblDBStat,
            this.tslblRAMConst,
            this.tslblRAM,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1161, 22);
            this.statusStrip1.TabIndex = 61;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblStateConst
            // 
            this.tslblStateConst.Name = "tslblStateConst";
            this.tslblStateConst.Size = new System.Drawing.Size(75, 17);
            this.tslblStateConst.Text = "Battery state:";
            // 
            // tslblState
            // 
            this.tslblState.Name = "tslblState";
            this.tslblState.Size = new System.Drawing.Size(29, 17);
            this.tslblState.Text = "N/A";
            // 
            // tsprgBat
            // 
            this.tsprgBat.Name = "tsprgBat";
            this.tsprgBat.Size = new System.Drawing.Size(100, 16);
            this.tsprgBat.Value = 50;
            // 
            // tslblBat
            // 
            this.tslblBat.Name = "tslblBat";
            this.tslblBat.Size = new System.Drawing.Size(16, 17);
            this.tslblBat.Text = "...";
            // 
            // tslblDBStatConst
            // 
            this.tslblDBStatConst.Name = "tslblDBStatConst";
            this.tslblDBStatConst.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.tslblDBStatConst.Size = new System.Drawing.Size(117, 17);
            this.tslblDBStatConst.Text = "Database status:";
            // 
            // tslblDBStat
            // 
            this.tslblDBStat.Name = "tslblDBStat";
            this.tslblDBStat.Size = new System.Drawing.Size(29, 17);
            this.tslblDBStat.Text = "N/A";
            // 
            // tslblRAMConst
            // 
            this.tslblRAMConst.Name = "tslblRAMConst";
            this.tslblRAMConst.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.tslblRAMConst.Size = new System.Drawing.Size(135, 17);
            this.tslblRAMConst.Text = "Memory utilization:";
            // 
            // tslblRAM
            // 
            this.tslblRAM.Name = "tslblRAM";
            this.tslblRAM.Size = new System.Drawing.Size(16, 17);
            this.tslblRAM.Text = "...";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // rbtnRealtime
            // 
            this.rbtnRealtime.AutoSize = true;
            this.rbtnRealtime.Checked = true;
            this.rbtnRealtime.Location = new System.Drawing.Point(12, 27);
            this.rbtnRealtime.Name = "rbtnRealtime";
            this.rbtnRealtime.Size = new System.Drawing.Size(66, 17);
            this.rbtnRealtime.TabIndex = 62;
            this.rbtnRealtime.TabStop = true;
            this.rbtnRealtime.Text = "Realtime";
            this.rbtnRealtime.UseVisualStyleBackColor = true;
            this.rbtnRealtime.CheckedChanged += new System.EventHandler(this.rbtnRealtime_CheckedChanged);
            // 
            // rbtnHistory
            // 
            this.rbtnHistory.AutoSize = true;
            this.rbtnHistory.Location = new System.Drawing.Point(135, 27);
            this.rbtnHistory.Name = "rbtnHistory";
            this.rbtnHistory.Size = new System.Drawing.Size(57, 17);
            this.rbtnHistory.TabIndex = 63;
            this.rbtnHistory.Text = "History";
            this.rbtnHistory.UseVisualStyleBackColor = true;
            this.rbtnHistory.CheckedChanged += new System.EventHandler(this.rbtnHistory_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Range";
            // 
            // cboRealtimeUnit
            // 
            this.cboRealtimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRealtimeUnit.FormattingEnabled = true;
            this.cboRealtimeUnit.Items.AddRange(new object[] {
            "minutes",
            "hours",
            "days"});
            this.cboRealtimeUnit.Location = new System.Drawing.Point(57, 66);
            this.cboRealtimeUnit.Name = "cboRealtimeUnit";
            this.cboRealtimeUnit.Size = new System.Drawing.Size(72, 21);
            this.cboRealtimeUnit.TabIndex = 66;
            this.cboRealtimeUnit.SelectedIndexChanged += new System.EventHandler(this.cboRealtimeUnit_SelectedIndexChanged);
            // 
            // cboRealtimeRange
            // 
            this.cboRealtimeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRealtimeRange.FormattingEnabled = true;
            this.cboRealtimeRange.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cboRealtimeRange.Location = new System.Drawing.Point(15, 66);
            this.cboRealtimeRange.Name = "cboRealtimeRange";
            this.cboRealtimeRange.Size = new System.Drawing.Size(39, 21);
            this.cboRealtimeRange.TabIndex = 1;
            this.cboRealtimeRange.SelectedIndexChanged += new System.EventHandler(this.cboRealtimeRange_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 504);
            this.Controls.Add(this.cboRealtimeRange);
            this.Controls.Add(this.cboRealtimeUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnHistory);
            this.Controls.Add(this.rbtnRealtime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHistoryEnd);
            this.Controls.Add(this.dtpHistoryStart);
            this.Controls.Add(this.chrtTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cabin Temperature Monitoring System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToGrah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmhistorianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctsDataSetAlarm)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpHistoryStart;
        private System.Windows.Forms.DateTimePicker dtpHistoryEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTemp;
        private DataSetToGrah dataSetToGrah;
        private System.Windows.Forms.BindingSource historianBindingSource;
        private DataSetToGrahTableAdapters.historianTableAdapter historianTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem subscribersToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ctsDataSetAlarm ctsDataSetAlarm;
        private System.Windows.Forms.BindingSource alarmhistorianBindingSource;
        private ctsDataSetAlarmTableAdapters.alarm_historianTableAdapter alarm_historianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmeventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimerecordedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer tmrUpdateGui;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblStateConst;
        private System.Windows.Forms.ToolStripStatusLabel tslblState;
        private System.Windows.Forms.ToolStripProgressBar tsprgBat;
        private System.Windows.Forms.ToolStripStatusLabel tslblBat;
        private System.Windows.Forms.ToolStripStatusLabel tslblDBStatConst;
        private System.Windows.Forms.ToolStripStatusLabel tslblDBStat;
        private System.Windows.Forms.ToolStripStatusLabel tslblRAMConst;
        private System.Windows.Forms.ToolStripStatusLabel tslblRAM;
        private System.Windows.Forms.RadioButton rbtnRealtime;
        private System.Windows.Forms.RadioButton rbtnHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRealtimeUnit;
        private System.Windows.Forms.ComboBox cboRealtimeRange;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}