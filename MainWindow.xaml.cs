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
        private List<ToDo> ToDoList = new List<ToDo>();

        public MainWindow()
        {
            InitializeComponent();
            ToDoList.Add(new ToDo("Приготовить покушать", new DateTime(2024, 1, 15), "нет описания"));
            ToDoList.Add(new ToDo("Поработать", new DateTime(2024, 1, 20), "Съездить на совещание в Москву"));
            ToDoList.Add(new ToDo("Отдохнуть", new DateTime(2024, 2, 1), "Съездить в отпуск в Сочи"));
            UpdateTaskList(); 
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) 
        {
            string Title = TitleTextBox.Text;
            DateTime? DueDate = DueDatePicker.SelectedDate;
            string Description = DescriptionTextBox.Text;

            if (string.IsNullOrEmpty(Title) || DueDate == null)
            {
                MessageBox.Show("Пожалуйста, заполните название и дату выполнения.");
                return;
            }

            ToDo NewItem = new ToDo(Title, DueDate.Value, Description);

            ToDoList.Add(NewItem);

            TitleTextBox.Text = null;
            DueDatePicker.SelectedDate = null;
            DescriptionTextBox.Text = null;

            UpdateTaskList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ToDo SelectedItem = TaskListListBox.SelectedItem as ToDo;

            if (SelectedItem != null)
            {
                ToDoList.Remove(SelectedItem);
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
            TaskListListBox.ItemsSource = ToDoList;
        }
    }
}