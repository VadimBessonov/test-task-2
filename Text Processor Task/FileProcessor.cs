using System;
using System.IO;
using System.Windows;

namespace Text_Processor_Task
{
    internal class FileProcessor : IFileProcessor
    {
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;
        public bool IsEof { get; private set; }

        /// <summary>
        /// Конструктор, открывающий файл и создающий поток для чтения
        /// </summary>
        /// <param name="path">Путь до входного файла</param>
        public FileProcessor(string path)
        {
            IsEof = true;
            OpenStreamReader(path);
        }

        /// <summary>
        /// Конструктор, открывающий файл и создающий потоки для чтения и записи.
        /// </summary>
        /// <param name="inputPath">Путь до входного файла</param>
        /// <param name="outputPath">Путь до выходного файла</param>
        public FileProcessor(string inputPath, string outputPath)
        {
            IsEof = true;
            OpenStreamReader(inputPath);
            OpenStreamWriter(outputPath);
            _streamWriter.AutoFlush = true;
        }

        /// <summary>
        /// Метод открывает поток для чтения файла
        /// </summary>
        /// <param name="path">путь до файла</param>
        private void OpenStreamReader(string path)
        {
            try
            {
                _streamReader = new StreamReader(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод открывает поток для записи в файл
        /// </summary>
        /// <param name="path">путь до файла</param>
        private void OpenStreamWriter(string path)
        {
            try
            {
                _streamWriter = new StreamWriter(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод чтения следующего символа из потока.
        /// </summary>
        /// <returns>Считанный символ.</returns>
        public char ReadNextChar()
        {
            if (IsEof == true)
            {
                throw new Exception("end of file");
            }

            int nextChar = _streamReader.Read();

            switch (nextChar)
            {
                case -1:
                    IsEof = true;
                    return '\0';
                default:
                    return (char)nextChar;
            }
        }

        /// <summary>
        /// Метод записывает один символ в файл
        /// </summary>
        /// <param name="simbol"></param>
        public void WriteChar(char simbol)
        {
            WriteStreamChecker();
            _streamWriter.Write(simbol);
        }

        /// <summary>
        /// Метод записывает текст в файл
        /// </summary>
        /// <param name="text">текст, который будет записан в файл</param>
        public void WriteString(string text)
        {
            WriteStreamChecker();
            _streamWriter.Write(text);
            
        }

        /// <summary>
        /// Метод проверяет задан ли выходной поток
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void WriteStreamChecker()
        {
            if (_streamWriter == null)
            {
                throw new Exception("No output stream");
            }
        }

        /// <summary>
        /// Сбрасывает текущую позицию потока на начало.
        /// </summary>
        public void ResetPositionToStart()
        {
            if (_streamReader == null)
            {
                IsEof = true;
                return;
            }

            _streamReader.BaseStream.Position = 0;
            IsEof = false;
        }

        /// <summary>
        /// Метод закрытия файла.
        /// </summary>
        public void CloseFile()
        {
            _streamReader?.Close();
            _streamWriter?.Close();
        }

    }
}
