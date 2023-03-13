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
    /// Логика взаимодействия для TaskPage11.xaml
    /// </summary>
    public partial class TaskPage11 : Page
    {
        public TaskPage11()
        {
            InitializeComponent();
        }
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(TbX.Text);
                int N = Convert.ToInt32(TbN.Text);
                double a = 1;
                if (N > 0)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        a += Math.Pow(X, i) / i;
                    }
                    MessageBox.Show($" Произведение = {a}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                if (N < 0)
                    MessageBox.Show($"Число N не может быть отрицательным", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);

                TbN.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
