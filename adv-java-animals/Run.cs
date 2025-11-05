namespace adv_java_animals
{
    public class Run
    {
        private static FileOutput outFile = new FileOutput("animals.txt");
        private static FileInput inFile = new FileInput("animals.txt");

        public static void Main(string[] args)
        {
            List<Talkable> zoo = new List<Talkable>();

            zoo.Add(new Creater().CreateTalkable());

            foreach (Talkable thing in zoo)
            {
                printOut(thing);
            }

            // outFile.fileClose();
            // inFile.fileRead();
            // inFile.fileClose();

            FileInput indata = new FileInput("animals.txt");
            string line;
            while ((line = indata.fileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void printOut(Talkable p)
        {
            Console.WriteLine(p.getName() + " says=" + p.talk());
            // outFile.fileWrite(p.getName() + " | " + p.talk());
        }
    }
}
