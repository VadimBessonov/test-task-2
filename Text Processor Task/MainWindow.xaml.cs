using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Text_Processor_Task
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

        private void StartHandling(object sender, RoutedEventArgs e)
        {
            bool isNeedPunctuation = IsNeedPunctuation.IsChecked.Value;
            int minWordLenth = int.Parse(string.Join("", MinCharsInWord.Text.Where(c => char.IsDigit(c))));

            TextProcessor textProcessor = new TextProcessor(InputFilePathes.Text, OutputPathes.Text, minWordLenth, isNeedPunctuation);
            textProcessor.Handling();
        }

        /// <summary>
        /// Метод выбора входных файлов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFile(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "File"; // Default file name
            dialog.DefaultExt = ".txt"; // Default file extension
            dialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            dialog.Multiselect = true;

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                InputFilePathes.Text = "";
                for (int i = 0; i < dialog.FileNames.Length; i++)
                {
                    InputFilePathes.Text += dialog.FileNames[i];
                    if (i + 1 < dialog.FileNames.Length) InputFilePathes.Text += '\n';
                }
            }
        }

        /// <summary>
        /// Метод позволяет вводить только числа в текстбокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnlyDigitInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

    }
}
