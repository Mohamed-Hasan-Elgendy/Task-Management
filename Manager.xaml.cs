using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace task_management
{
    /// <summary>
    /// Interaction logic for Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        task_ManagmentEntities db = new task_ManagmentEntities();
        Task task =new Task();
        User user = new User(); 
        public Manager()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            DG.ItemsSource = db.Tasks.ToList();
            DG.CanUserAddRows = false;
        }

        public void clear()
        {
            taskid.Clear();
            tasktitle.Clear();
            taskdescription.Clear();
            combo_status.Text=null;
            combo_employees.Text = null;
            date.SelectedDate = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tasktitle.Text)|| string.IsNullOrEmpty(taskdescription.Text)|| combo_status.Text==null||date.SelectedDate==null)
            {
                MessageBox.Show("Please Fill All data Fields .");
            }
            else if (tasktitle.Text!=null&& taskdescription.Text!=null&&combo_employees.SelectedIndex==0)
            {
                var task = new Task()
                {
                    task_title = tasktitle.Text,
                    task_description = taskdescription.Text,
                    task_status = combo_status.Text,
                    task_Date = date.SelectedDate,
                    task_user_id=2
                };
                MessageBox.Show("Done Task Added .");
                db.Tasks.Add(task);
                db.SaveChanges();
                load();
                clear();
            }
            else if (tasktitle.Text != null && taskdescription.Text != null && combo_employees.SelectedIndex == 1)
            {
                var task = new Task()
                {
                    task_title = tasktitle.Text,
                    task_description = taskdescription.Text,
                    task_status = combo_status.Text,
                    task_Date = date.SelectedDate,
                    task_user_id = 3
                };
                MessageBox.Show("Done Task Added .");
                db.Tasks.Add(task);
                db.SaveChanges();
                load();
                clear();
            }
            else if (tasktitle.Text != null && taskdescription.Text != null && combo_employees.SelectedIndex == 2)
            {
                var task = new Task()
                {
                    task_title = tasktitle.Text,
                    task_description = taskdescription.Text,
                    task_status = combo_status.Text,
                    task_Date = date.SelectedDate,
                    task_user_id = 4
                };
                MessageBox.Show("Done Task Added .");
                db.Tasks.Add(task);
                db.SaveChanges();
                load();
                clear();
            }

        }
        private void Update(object sender, RoutedEventArgs e)
        {
            
            task.task_title=tasktitle.Text;
            task.task_description=taskdescription.Text;
            task.task_status=combo_status.Text;
            task.task_Date=date.SelectedDate;
            task.task_user_id=combo_employees.SelectedIndex+2;
            db.SaveChanges();
            load();          
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            
            db.Tasks.Remove(task);
            db.SaveChanges();
            load();
       
        }
        private void DG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clear();
            if (DG.SelectedItem is Task selected)
            {
                task = selected;
                taskid.Text = selected.task_id.ToString();
                tasktitle.Text = selected.task_title;
                taskdescription.Text = selected.task_description;
                combo_status.Text = selected.task_status;
                combo_employees.SelectedIndex =user.user_id;
                date.SelectedDate = selected.task_Date;
            }
           
            

        }

        private void combo_employees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void clearf_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }
    }
}
