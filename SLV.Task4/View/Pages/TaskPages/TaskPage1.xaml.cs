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

namespace SLV.Task4.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage1.xaml
    /// </summary>
    public partial class TaskPage1 : Page
    {
        public TaskPage1()
        {
            InitializeComponent();
        }
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(TbA.Text);
                int B = Convert.ToInt32(TbB.Text);
                int N = 0;
                for (int i = A; i <= B; i++)
                {
                    N += 1;
                }
                MessageBox.Show($"Количество чисел = {N}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
