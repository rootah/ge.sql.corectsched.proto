using System;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Commands;
using DevExpress.XtraScheduler.Services;


namespace ge.sql.corectsched.proto
{
    public partial class Form1 : XtraForm
    {
        public string[] ResArr;
        public string[] Dates;

        public Form1()
        {
            InitializeComponent();
            schedulerControl.Start = DateTime.Now;
            schedulerControl.ActiveViewType = SchedulerViewType.WorkWeek;

            schedulerStorage.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            schedulerStorage.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            schedulerStorage.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;
        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(geprotoDataSet);
            geprotoDataSet.AcceptChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resourcesTableAdapter.Fill(geprotoDataSet.Resources);
            appointmentsTableAdapter.Fill(geprotoDataSet.Appointments);

            dateEdit1.DateTime = DateTime.Today;
        }

        private void schedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu)
            {
                // Hide the "Change View To" menu item.
                SchedulerPopupMenu itemChangeViewTo = e.Menu.GetPopupMenuById(SchedulerMenuItemId.SwitchViewMenu);
                itemChangeViewTo.Visible = false;

                // Remove unnecessary items.
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent);

                // Disable the "New Recurring Appointment" menu item.
                e.Menu.DisableMenuItem(SchedulerMenuItemId.NewRecurringAppointment);

                // Find the "New Appointment" menu item and rename it.
                SchedulerMenuItem item = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment);
                if (item != null) item.Caption = "&New Meeting";

                // Create a menu item for the Scheduler command.
                var service =
                    (ISchedulerCommandFactoryService)
                        schedulerControl.GetService(typeof (ISchedulerCommandFactoryService));
                SchedulerCommand cmd = service.CreateCommand(SchedulerCommandId.SwitchToGroupByResource);
                var menuItemCommandAdapter =
                    new SchedulerMenuItemCommandWinAdapter(cmd);
                var menuItem = (DXMenuItem) menuItemCommandAdapter.CreateMenuItem();
                menuItem.BeginGroup = true;
                e.Menu.Items.Add(menuItem);

                // Insert a new item into the Scheduler popup menu and handle its click event.
                e.Menu.Items.Add(new SchedulerMenuItem("Click me!", MyClickHandler));
            }
        }

        public void MyClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show(@"My Menu Item Clicked!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = checkedComboBoxEdit1.Text;
            var hours = comboBox1.Text;

            //var s = days;
            var arr = new[] {", "};
            ResArr = s.Split(arr, StringSplitOptions.None);

            var p = 0;
            while (p < ResArr.Count())
            {
                if (ResArr[p] == "mon")
                {
                    ResArr[p] = "1";
                    p++;
                }
                else
                {
                    if (ResArr[p] == "tue")
                    {
                        ResArr[p] = "2";
                        p++;
                    }
                    else
                    {
                        if (ResArr[p] == "wed")
                        {
                            ResArr[p] = "3";
                            p++;
                        }
                        else
                        {
                            if (ResArr[p] == "thu")
                            {
                                ResArr[p] = "4";
                                p++;
                            }
                            else
                            {
                                if (ResArr[p] == "fri")
                                {
                                    ResArr[p] = "5";
                                    p++;
                                }
                                else
                                {
                                    if (ResArr[p] == "sat")
                                    {
                                        ResArr[p] = "6";
                                        p++;
                                    }
                                    else
                                    {
                                        if (ResArr[p] == "sun")
                                        {
                                            ResArr[p] = "0";
                                            p++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            var count = 0;
            var dayscount = 24/Convert.ToInt32(hours);
            var arraycount = 0;
            var arraycount2 = 0;
            Dates = new string[dayscount];

            var delta = (int) DayOfWeek.Sunday - (int) dateEdit1.DateTime.Date.DayOfWeek;
            var monday = dateEdit1.DateTime.Date.AddDays(delta);
            var nextmonday = dateEdit1.DateTime.Date.AddDays(delta).AddDays(7);


            var weekscount = 24/(ResArr.Count()*Convert.ToInt32(hours));

            while (count < weekscount)
            {
                while (arraycount < ResArr.Count())
                {
                    if (ResArr[arraycount] == "0")
                    {
                        Dates[arraycount2] = monday.AddDays(7).ToShortDateString();
                    }
                    else
                    {
                        Dates[arraycount2] = monday.AddDays(Convert.ToInt32(ResArr[arraycount])).ToShortDateString();
                    }
                    arraycount++;
                    arraycount2++;
                }

                arraycount = 0;
                count++;
                monday = nextmonday;
                nextmonday = monday.AddDays(7);
            }

            var a = Dates;
            var b = new ArrayList(a);
            gridControl1.DataSource = b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var date = dateEdit1.DateTime.Date;
            var time = TimeSpan.Parse(timeEdit1.Time.ToShortTimeString());
            var addhour = Convert.ToInt16(comboBox1.Text);
            
            var apt = new Appointment(AppointmentType.Normal)
            {
                Subject = "subj",Start = date.Add(time),Location = textEdit1.Text,
                StatusId = 2,
                LabelId = 2,
                End = date.Add(time).AddHours(addhour)};

            schedulerStorage.Appointments.Add(apt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
            var group = textEdit1.Text;
            var time = TimeSpan.Parse(timeEdit1.Time.ToShortTimeString());
            var addhour = Convert.ToInt16(comboBox1.Text);
            var subj = textEdit1.Text;

            for (int i = 0; i < Dates.Count(); i++)
            {
                var date = DateTime.Parse(Dates[i]);
                var apt = new Appointment(AppointmentType.Normal)
                {
                    Subject = subj,
                    Start = date.Add(time),
                    Location = group,
                    StatusId = 2,
                    LabelId = 2,
                    End = date.Add(time).AddHours(addhour)
                };
                schedulerStorage.Appointments.Add(apt);
            }
        }
    }
}