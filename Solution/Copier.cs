using Solution;

namespace CopyProgram1
{
    class Copier
    {
        private readonly IWriter _writter;
        private readonly IReader _reader;

        public Copier(IWriter writter, IReader reader)
        {
            _writter = writter;
            _reader = reader;
        }

        public void Copy()
        {
            string value;
            while ((value = _reader.Read()) != "-1")
            {
                _writter.Save(value);
            }
        }
    }
}
