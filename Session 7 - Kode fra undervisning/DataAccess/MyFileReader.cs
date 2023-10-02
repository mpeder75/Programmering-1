namespace Session_7___Exercise.DataAccess
{
    public class MyFileReader
    {
        public string rootPath;
        public string[] txtLines;

        public MyFileReader(string rootPath)
        {
            this.rootPath = rootPath;
            this.txtLines = ReadFromFile();
        }

        public string[] ReadFromFile()
        {
            string path = rootPath + "persons.csv";

            if (File.Exists(path))
            {
                string[] txtLines = File.ReadAllLines(path);
                return txtLines;
            }
            else
            {
                return new string[0];
            }
        }
    }
}
