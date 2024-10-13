using Compilador.Interfaces;

namespace Compilador.Inputs
{
    class ReadFile : IReadFile
    {
        private readonly string _processedContent;
        private int _currentPosition;

        public ReadFile(string path)
        {
            try
            {
                string fileContent = File.ReadAllText(path);
                _processedContent = RemoveWhitespace(fileContent);
                _currentPosition = 0;
            }
            catch (Exception ex)
            {
                throw new Exception("File could not be loaded", ex);
            }
        }

        private static string RemoveWhitespace(string input)
        {
            return new string(input.Where(c => !char.IsWhiteSpace(c)).ToArray());
        }

        public int NextChar()
        {
            if (_currentPosition >= _processedContent.Length)
            {
                return -1;
            }
            return _processedContent[_currentPosition++];
        }

        public void Rewind()
        {
            if (_currentPosition > 0)
            {
                _currentPosition--;
            }
        }
    }
}
