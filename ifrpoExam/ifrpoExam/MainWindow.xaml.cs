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

namespace ifrpoExam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Inner.Text == "")
            {
                if (Outer.Text == "")
                {
                    MessageBox.Show("Не введены диаметры подшипника");
                }  
                                else
                {
                    try
                    {
                        OuterReadius.Text = Convert.ToString(Convert.ToInt32(Outer.Text) / 2);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Введены не числовые данные");
                    }
                }    
            }
            else
            {
                try
                {
                    InnerRadius.Text = Convert.ToString(Convert.ToInt32(Inner.Text) / 2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введены не числовые данные");
                }
            }
        }
    }
}
