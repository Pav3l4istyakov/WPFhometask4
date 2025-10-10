using Microsoft.VisualBasic;
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
using System.Windows.Shapes;

namespace WPFhometask4
{
    /// <summary>
    /// Логика взаимодействия для AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
      
        public AddTaskWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click (object sender, RoutedEventArgs e)
        {
            string Title = TitleTextBox.Text;
            DateTime? Duedate = DueDatePicker.SelectedDate;
            string Description = DescriptionTextBox.Text;

            if(string.IsNullOrEmpty(Title) || Duedate == null)
            {
                MessageBox.Show("Дата и название дела");
                return;
            }
           
        }
    }
    
}
