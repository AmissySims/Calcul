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

namespace Calcul
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string leftOperation = "", rightoperation = "", operatoin = "";

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            WorkPanel.Text = "";
            leftOperation = "";
            rightoperation = "";
            operatoin = "";



        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            string ContentBtn = (sender as Button).Content.ToString();
            WorkPanel.Text += ContentBtn;

            if (ContentBtn == "=")
            {
                try
                {
                    double num1 = double.Parse(leftOperation);
                    double num2 = double.Parse(rightoperation);
                    switch (operatoin)
                    {
                        case "+":
                            WorkPanel.Text = (num1 + num2).ToString();
                            break;
                        case "-":
                            WorkPanel.Text = (num1 - num2).ToString();
                            break;
                        case "*":
                            WorkPanel.Text = (num1 * num2).ToString();
                            break;
                        case "/":
                            WorkPanel.Text = (num1 / num2).ToString();
                            break;
                    }
                    leftOperation = WorkPanel.Text;
                    rightoperation = "";
                    operatoin = "";
                }
                catch (Exception q)
                {
                    WorkPanel.FontSize = 10;
                    WorkPanel.Text = q.Message;
                }


            }


            else
            {
                if (leftOperation == "")
                    leftOperation = ContentBtn;
                else
                {
                    rightoperation = ContentBtn;
                }

            }
            if (ContentBtn == "+" || ContentBtn == "-" || ContentBtn == "*" || ContentBtn == "/")
            {
                operatoin = ContentBtn;

            }
            else
            {
            }


        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
