namespace adv_java_animals
{
    public class FileInput
    {
        private StreamReader inFile;
        private string fileName;

        public FileInput(string fileName)
        {
            this.fileName = fileName;
            try
            {
                if (inFile == null)
                {
                    inFile = new StreamReader(fileName, true);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void fileRead()
        {
            string line;
            try
            {
                while ((line = inFile.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public string fileReadLine()
        {
            try
            {
                string line = inFile.ReadLine();
                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
                return null;
            }
        }

        public void fileClose()
        {
            if (inFile != null) {
                try
                {
                    inFile.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }
    }
}
