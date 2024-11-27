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

namespace task_management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        task_ManagmentEntities db = new task_ManagmentEntities();
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text)|| string.IsNullOrWhiteSpace(password.Password))
            {
                MessageBox.Show( "Error : Please Fill All Data feilds");
            }
            else
            {
                var user = db.Users.FirstOrDefault(u => u.user_name == username.Text.ToLower() && u.user_password == password.Password);
                if (user!=null&&user.user_role== "Manager")
                {
                    MessageBox.Show( "Welcome Manager :"+user.user_name);
                    Manager manager = new Manager();
                    manager.Show();
                    this.Close();
                }

                else if (user != null && user.user_role == "Employee")
                {
                    MessageBox.Show("Welcome Employee :" + user.user_name);
                    Employee employee = new Employee();
                    employee.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(MessageBoxImage.Error + "Invalid Username Or Password Sorry :(");
                }
            }

        }
    }
}
