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
    /// Логика взаимодействия для TaskPage6.xaml
    /// </summary>
    public partial class TaskPage6 : Page
    {
        public TaskPage6()
        {
            InitializeComponent();
        }
        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(TbN.Text);
                int M = Convert.ToInt32(TbM.Text);
                int K = 0, c = 0;
                for (int i = 0; i < N; i++)
                {
                    while (3 * K <= i)
                    {
                        K++;
                        c++;
                    }
                }
                MessageBox.Show($"k = {K}, наименьшее целое = {c} ", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
                TbN.Text = string.Empty;
                TbM.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
