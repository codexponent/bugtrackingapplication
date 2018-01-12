namespace BugTrackingApplication {
    partial class UserChart {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtrackingapplicationDataSet = new BugTrackingApplication.bugtrackingapplicationDataSet();
            this.groupTableTableAdapter = new BugTrackingApplication.bugtrackingapplicationDataSetTableAdapters.groupTableTableAdapter();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingapplicationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.groupTableBindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(294, 188);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "groupname";
            series2.YValueMembers = "id";
            series2.YValuesPerPoint = 32;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupTableBindingSource
            // 
            this.groupTableBindingSource.DataMember = "groupTable";
            this.groupTableBindingSource.DataSource = this.bugtrackingapplicationDataSet;
            // 
            // bugtrackingapplicationDataSet
            // 
            this.bugtrackingapplicationDataSet.DataSetName = "bugtrackingapplicationDataSet";
            this.bugtrackingapplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupTableTableAdapter
            // 
            this.groupTableTableAdapter.ClearBeforeFill = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 64);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Back";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // UserChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 740);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.chart1);
            this.Name = "UserChart";
            this.Text = "UserChart";
            this.Load += new System.EventHandler(this.UserChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingapplicationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private bugtrackingapplicationDataSet bugtrackingapplicationDataSet;
        private System.Windows.Forms.BindingSource groupTableBindingSource;
        private bugtrackingapplicationDataSetTableAdapters.groupTableTableAdapter groupTableTableAdapter;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}