namespace adv_java_animals
{
    public class FileOutput
    {
        StreamWriter outFile = null;
        private string fileName;

        public FileOutput(string fileName)
        {
            this.fileName = fileName;
            try
            {
                outFile = new StreamWriter(fileName, true);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void fileWrite(string line)
        {
            try
            {
                outFile.Write(line + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public void fileClose()
        {
            if (outFile != null) {
                try
                {
                    outFile.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }
    }
}
