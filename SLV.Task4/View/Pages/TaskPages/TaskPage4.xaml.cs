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
    /// Логика взаимодействия для TaskPage4.xaml
    /// </summary>
    public partial class TaskPage4 : Page
    {
        public TaskPage4()
        {
            InitializeComponent();
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(TbA.Text);
                int N = Convert.ToInt32(TbN.Text);
                MessageBox.Show($" {N}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                if (N < 0)
                    MessageBox.Show($"Число N не может быть отрицательным", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);

                TbA.Text = string.Empty;
                TbN.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
