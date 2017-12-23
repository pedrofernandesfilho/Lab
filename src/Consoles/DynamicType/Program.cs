using System;

namespace .DynamicType
{
    class TextWriter
    {
        protected dynamic config;

        public TextWriter(dynamic config)
        {
            this.config = config;
        }

        public void getFileName()
        {
            Console.WriteLine(config.FileName + config.Extension);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var config = new { Extension = ".txt", FileName = "poem" };
            TextWriter txt = new TextWriter(config);
            txt.getFileName();

            Console.ReadLine();
        }
    }
}
