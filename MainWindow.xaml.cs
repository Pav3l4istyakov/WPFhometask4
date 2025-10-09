using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFhometask4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<ToDo> todoList = new List<ToDo>();

        public MainWindow()
        {
            InitializeComponent();
            
            todoList.Add(new ToDo("Приготовить покушать", new DateTime(2024, 1, 15), "нет описания"));
            todoList.Add(new ToDo("Поработать", new DateTime(2024, 1, 20), "Съездить на совещание в Москву"));
            todoList.Add(new ToDo("Отдохнуть", new DateTime(2024, 2, 1), "Съездить в отпуск в Сочи"));
            UpdateTaskList(); 
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) 
        {
            string title = TitleTextBox.Text;
            DateTime? dueDate = DueDatePicker.SelectedDate;
            string description = DescriptionTextBox.Text;

            if (string.IsNullOrEmpty(title) || dueDate == null)
            {
                MessageBox.Show("Пожалуйста, заполните название и дату выполнения.");
                return;
            }

            ToDo newItem = new ToDo(title, dueDate.Value, description);

            todoList.Add(newItem);

            TitleTextBox.Text = null;
            DueDatePicker.SelectedDate = null;
            DescriptionTextBox.Text = null;

            UpdateTaskList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ToDo selectedItem = TaskListListBox.SelectedItem as ToDo;

            if (selectedItem != null)
            {
                todoList.Remove(selectedItem);
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите дело для удаления.", "Уведомление");
            }
        }

        private void AddTasksCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            AddTasksPanel.Visibility = Visibility.Visible;
        }

        private void AddTasksCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            AddTasksPanel.Visibility = Visibility.Collapsed;
        }

        private void UpdateTaskList()
        {
            TaskListListBox.ItemsSource = null;
            TaskListListBox.ItemsSource = todoList;
        }
    }
}