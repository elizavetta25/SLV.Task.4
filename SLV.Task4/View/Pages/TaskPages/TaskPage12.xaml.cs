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
    /// Логика взаимодействия для TaskPage12.xaml
    /// </summary>
    public partial class TaskPage12 : Page
    {
        public TaskPage12()
        {
            InitializeComponent();
        }
        private void BtnTask12_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(TbX.Text);
                int N = Convert.ToInt32(TbN.Text);
                double a = X;
                if (N > 0)
                {
                    for (int i = 1; i <= N; i += 2)
                    {
                        a += -1 * i * Math.Pow(X, i * i + 1) / 2 * i + 1;
                    }
                    MessageBox.Show($" Произведение = {a}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                if (N < 0)
                    MessageBox.Show($"Число N не может быть отрицательным", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                TbX.Text = string.Empty;
                TbN.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
