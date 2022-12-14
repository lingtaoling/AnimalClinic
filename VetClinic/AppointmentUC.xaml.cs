using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VetClinic
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class AppointmentUC : UserControl
    {
        public AppointmentUC()
        {
            InitializeComponent();
        }


        private void BtnAppointment_Click(object sender, RoutedEventArgs e)
        {
            AppointmentUC newAppointment = new AppointmentUC(
            TbxName.Text,
            TbxPName.Text,
            TbxDoctor.Text,
            (DateTime)DpAppointment.SelectedDate.Add(
            (DateTime)TpAppointment.SelectedTime), TbkNotes.Text);
            LvAppointment.ItemsSource = dbContext.Appointments.ToList();
            Globals.dbContext.Appointments.Add(newAppointment);
            Globals.dbContext.SaveChanges();


        }
    }
}
