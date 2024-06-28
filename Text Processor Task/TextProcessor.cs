using System.IO;
using System.Threading.Tasks;

namespace Text_Processor_Task
{
    internal class TextProcessor
    {
        FileProcessor fileProcessor;
        private string _inputPathes;
        private string _outputPathes;
        private int _minLenth;
        private bool _isNeedPunctuation;

        public TextProcessor(string inputPath, string outputPath, int minLenth, bool isNeedPunctuation) 
        {
            _inputPathes = inputPath;
            _outputPathes = outputPath;
            _minLenth = minLenth;
            _isNeedPunctuation = isNeedPunctuation;
        }

        public async void Handling()
        {
            await Task.Run(() =>
            {
                string[] input = _inputPathes.Split('\n');
                string[] outputPathes = _outputPathes.Split('\n');
                for (int i = 0; i < input.Length; i++)
                {
                    string outPath = input[i] + "OUT.txt";
                    if (i < outputPathes.Length && File.Exists(outputPathes[i])) outPath = outputPathes[i];

                    fileProcessor = new FileProcessor(input[i], outPath);

                    string outstr = SingleFileHandling(fileProcessor);

                    fileProcessor.WriteString(outstr);
                    fileProcessor.CloseFile();
                }
            });
        }

        private string SingleFileHandling(FileProcessor fileProcessor)
        {
            fileProcessor.ResetPositionToStart();

            string word = "";
            string outstr = "";
            char c;

            while (!fileProcessor.IsEof)
            {
                c = fileProcessor.ReadNextChar();
               
                if (char.IsLetter(c) && !char.IsPunctuation(c)) 
                { 
                    word += c; 
                }
                else if (word.Length >= _minLenth) 
                { 
                    outstr += word;
                    if (char.IsPunctuation(c) != _isNeedPunctuation && !char.IsWhiteSpace(c)) outstr += c;
                    else if (char.IsWhiteSpace(c)) outstr += c;

                    word = ""; 
                }
                else 
                {
                    if (char.IsWhiteSpace(c) || char.IsDigit(c) || char.IsPunctuation(c) != _isNeedPunctuation)
                    {
                        outstr += c;
                    }
                    word = ""; 
                }
            }
            return outstr;
        }

    }
}
