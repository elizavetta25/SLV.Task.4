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
    /// Логика взаимодействия для TaskPage8.xaml
    /// </summary>
    public partial class TaskPage8 : Page
    {
        public TaskPage8()
        {
            InitializeComponent();
        }
        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(TbA.Text);
                double N = Convert.ToDouble(TbN.Text);
                double S = 0, C = 0;
                for (int i = 1; i <= N; i++)
                {
                    S += 1 / i;
                    if (S > A)
                    {
                        C = i;
                    }
                }
                MessageBox.Show($" Сумма = {S}, Наименьшее из целых N = {C}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
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
