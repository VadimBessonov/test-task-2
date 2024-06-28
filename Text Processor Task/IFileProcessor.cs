
namespace Text_Processor_Task
{
    internal interface IFileProcessor
    {
        char ReadNextChar();

        void ResetPositionToStart();

        void CloseFile();

        bool IsEof { get; }
    }
}
