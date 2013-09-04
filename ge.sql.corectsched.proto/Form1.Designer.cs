namespace ge.sql.corectsched.proto
{
    partial class Form1
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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geprotoDataSet = new ge.sql.corectsched.proto.geprotoDataSet();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.appointmentsTableAdapter = new ge.sql.corectsched.proto.geprotoDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesTableAdapter = new ge.sql.corectsched.proto.geprotoDataSetTableAdapters.ResourcesTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.button4 = new System.Windows.Forms.Button();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button5 = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geprotoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek;
            this.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.schedulerControl.Location = new System.Drawing.Point(358, 0);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.Size = new System.Drawing.Size(742, 418);
            this.schedulerControl.Start = new System.DateTime(2013, 9, 2, 0, 0, 0, 0);
            this.schedulerControl.Storage = this.schedulerStorage;
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.WorkWeekView.AppointmentDisplayOptions.ColumnPadding.Left = 2;
            this.schedulerControl.Views.WorkWeekView.AppointmentDisplayOptions.ContinueArrowDisplayType = DevExpress.XtraScheduler.AppointmentContinueArrowDisplayType.Arrow;
            this.schedulerControl.Views.WorkWeekView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Always;
            this.schedulerControl.Views.WorkWeekView.AppointmentDisplayOptions.ShowReminder = false;
            this.schedulerControl.Views.WorkWeekView.AppointmentDisplayOptions.ShowShadows = false;
            this.schedulerControl.Views.WorkWeekView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Always;
            this.schedulerControl.Views.WorkWeekView.AppointmentDisplayOptions.TimeDisplayType = DevExpress.XtraScheduler.AppointmentTimeDisplayType.Clock;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerControl_PopupMenuShowing);
            // 
            // schedulerStorage
            // 
            this.schedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("CustomField1", "CustomField1"));
            this.schedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ResourceIDs", "ResourceIDs"));
            this.schedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("UniqueID", "UniqueID"));
            this.schedulerStorage.Appointments.DataSource = this.appointmentsBindingSource;
            this.schedulerStorage.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage.Appointments.Mappings.Description = "Description";
            this.schedulerStorage.Appointments.Mappings.End = "EndDate";
            this.schedulerStorage.Appointments.Mappings.Label = "Label";
            this.schedulerStorage.Appointments.Mappings.Location = "Location";
            this.schedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerStorage.Appointments.Mappings.ResourceId = "ResourceID";
            this.schedulerStorage.Appointments.Mappings.Start = "StartDate";
            this.schedulerStorage.Appointments.Mappings.Status = "Status";
            this.schedulerStorage.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage.Appointments.Mappings.Type = "Type";
            this.schedulerStorage.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("CustomField1", "CustomField1"));
            this.schedulerStorage.Resources.DataSource = this.resourcesBindingSource;
            this.schedulerStorage.Resources.Mappings.Caption = "ResourceName";
            this.schedulerStorage.Resources.Mappings.Color = "Color";
            this.schedulerStorage.Resources.Mappings.Id = "ResourceID";
            this.schedulerStorage.Resources.Mappings.Image = "Image";
            this.schedulerStorage.Resources.Mappings.ParentId = "UniqueID";
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.geprotoDataSet;
            // 
            // geprotoDataSet
            // 
            this.geprotoDataSet.DataSetName = "geprotoDataSet";
            this.geprotoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.geprotoDataSet;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Light Gray";
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "put";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(12, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEdit1.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEdit1.Size = new System.Drawing.Size(148, 20);
            this.dateEdit1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(12, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.EditValue = "";
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(12, 38);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(1, "mon"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2, "tue"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(3, "wed"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(4, "thu"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(5, "fri"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(6, "sat"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(0, "sun")});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(148, 20);
            this.checkedComboBoxEdit1.TabIndex = 18;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(12, 117);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(79, 20);
            this.textEdit1.TabIndex = 24;
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2013, 9, 3, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(12, 64);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.timeEdit1.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.timeEdit1.Size = new System.Drawing.Size(148, 20);
            this.timeEdit1.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "sample put";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(166, 231);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.schedulerControl;
            this.dateNavigator1.Size = new System.Drawing.Size(186, 175);
            this.dateNavigator1.TabIndex = 28;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(148, 205);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(166, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "get string";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(239, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "labelControl1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(166, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "alt put";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ActiveGlowColor = System.Drawing.Color.Empty;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 418);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dateNavigator1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.timeEdit1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkedComboBoxEdit1);
            this.Controls.Add(this.schedulerControl);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.InactiveGlowColor = System.Drawing.Color.Empty;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geprotoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private geprotoDataSet geprotoDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private geprotoDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private geprotoDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button button6;
        public DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
        public DevExpress.XtraGrid.GridControl gridControl1;

    }
}
