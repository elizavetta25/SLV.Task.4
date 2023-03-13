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
    /// Логика взаимодействия для TaskPage7.xaml
    /// </summary>
    public partial class TaskPage7 : Page
    {
        public TaskPage7()
        {
            InitializeComponent();
        }
        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(TbN.Text);
                int M = Convert.ToInt32(TbM.Text);
                int K = N, c = 0;
                for (int i = 0; i < N; i++)
                {
                    while (3 * K >= i)
                    {
                        K--;
                        c++;
                    }
                }
                MessageBox.Show($"k = {K}, наибольшее целое = {c}", "Системное сообщение",
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
