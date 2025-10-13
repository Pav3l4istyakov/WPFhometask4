using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для AddToTask.xaml
    /// </summary>
    public partial class AddToTask : Window
    {
       

        public AddToTask()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleTextBox.Text;
            DateTime? dueDate = DueDatePicker.SelectedDate;
            string description = DescriptionTextBox.Text;

            ToDo newItem = new ToDo(title, dueDate.GetValueOrDefault(), false, description);
            MainWindow.TodoList.Add(newItem);

            this.Close();
        }
    }
}

