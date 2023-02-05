using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace ToDoListApp
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Task> tasks;

        public MainWindow()
        {
            InitializeComponent();
            tasks = new ObservableCollection<Task>();
            TasksList.ItemsSource = tasks;
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task { Description = TaskDescription.Text };
            tasks.Add(task);
            TaskDescription.Clear();
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            Task task = TasksList.SelectedItem as Task;
            if (task != null)
            {
                tasks.Remove(task);
            }
        }
    }

    public class Task
    {
        public string Description { get; set; }
    }
}
