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
using System.Windows.Shapes;

namespace task_management
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        task_ManagmentEntities db=new task_ManagmentEntities();
        Task task = new Task();
        public Employee()
        {
            InitializeComponent();
            load1();
            load2();
        }
        public void load1()
        {
            DG_tasks.ItemsSource = db.Tasks.Where(u => u.task_status == "Pending"||u.task_status== "In Progress").ToList();
            DG_tasks.CanUserAddRows = false;
        }

        public void load2()
        {
            DG_completed.ItemsSource = db.Tasks.Where(u =>  u.task_status == "Completed").ToList();
            DG_completed.CanUserAddRows = false;
        }

        private void DG_tasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DG_tasks.SelectedItem is Task selected)
            {
                task = selected;
                task_id.Text = selected.task_id.ToString();
                combo2_status.Text = selected.task_status;         
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            task.task_status = combo2_status.Text;
            db.SaveChanges();
            load1();
            load2();
        }
    }
}
