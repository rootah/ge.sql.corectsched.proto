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
            var checkeddays = checkedComboBoxEdit1.EditValue.ToString();        //  строка отмеченных дней (1, 3, 5)
            var hours = comboBox1.Text;                                         //  часы ( 1 OR 2 OR 3)
            
            var arr = new[] {", "};                                             // строка для удаления запятых и пробелов
            ResArr = checkeddays.Split(arr, StringSplitOptions.None);           // вычисленный массив отмеченных дней [1, 3, 5]
            
            var count = 0;                                                      // счетчик недель
            var dayscount = 24/Convert.ToInt32(hours);                          // вычисляем общее количество дней
            var weekscount = 24 / (ResArr.Count() * Convert.ToInt32(hours));    // количество недель (24 ак. часа / (количество дней * часы))

            var firstcount = 0;                                                 // счетчик количества элем. массива дней
            var finaldate = 0;                                                  // счетчик количества элем. вычисленного массива дней
            
            Dates = new string[dayscount];                                      // финально рассчитанный массив дат

            var delta = 0 - (int)dateEdit1.DateTime.Date.DayOfWeek;             // разница между воскресеньем [0] и днем DateEdit1

            DateTime sunday;
            DateTime nextsunday;
            if ((int) dateEdit1.DateTime.Date.DayOfWeek > Convert.ToInt32(ResArr[0])) // если первый день в списке миновал то прыгаем на след. неделю
            {
                sunday = dateEdit1.DateTime.Date.AddDays(delta).AddDays(7);
                nextsunday = dateEdit1.DateTime.Date.AddDays(delta).AddDays(14);
            }
            else // иначе вычисляем воскресенье за спиной и впереди
            {
                sunday = dateEdit1.DateTime.Date.AddDays(delta);
                nextsunday = dateEdit1.DateTime.Date.AddDays(delta).AddDays(7);
            }

            while (count < weekscount)                                          // от 0 и до тех пор пока не обойдем все недели
            {
                while (firstcount < ResArr.Count())                             // от 0 до количества дней в неделе
                {
                    if (ResArr[firstcount] == "0")                              // если это 0 (вск)
                    {
                        Dates[finaldate] = sunday.AddDays(7).ToShortDateString(); // добавляем дату след воскресенья
                    }
                    else
                    {
                        Dates[finaldate] = sunday.AddDays(Convert.ToInt32(ResArr[firstcount])).ToShortDateString(); // иначе добавляем дату текущего элемента массива (1 - пн. - 01.10.13 и т.д.)
                    }
                    firstcount++;   // плюсуем счетчик исходного массива
                    finaldate++;    // плюсуем счетчик вычисляемого массива
                } // неделю обошли

                firstcount = 0; // обнуляем счетчик массива дней
                count++;    // плюсуем счетчик недель
                sunday = nextsunday; // двигаемся на неделю вперед
                nextsunday = sunday.AddDays(7); // след. вск. + 1
            }

            //var a = Dates;
            //var b = new ArrayList(Dates);
            gridControl1.DataSource = new ArrayList(Dates);
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
            var datesarr = SchedCalc._dates(this, checkedComboBoxEdit1.EditValue.ToString(), Convert.ToInt32(comboBox1.Text), (int)dateEdit1.DateTime.DayOfWeek, dateEdit1.DateTime);
            
            var group = textEdit1.Text;
            var time = TimeSpan.Parse(timeEdit1.Time.ToShortTimeString());
            var addhour = Convert.ToInt16(comboBox1.Text);
            const string subj = "Rozzary";for (int i = 0; i < datesarr.Count(); i++)
            {
                var date = DateTime.Parse(datesarr[i]);
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

        private void button5_Click(object sender, EventArgs e)
        {
            var checkeddays = checkedComboBoxEdit1.EditValue.ToString();        //  строка отмеченных дней (1, 3, 5)

            var arr = new[] { ", " };                                             // строка для удаления запятых и пробелов
            ResArr = checkeddays.Split(arr, StringSplitOptions.None);

            labelControl1.Text = ResArr[0];
        }}
}