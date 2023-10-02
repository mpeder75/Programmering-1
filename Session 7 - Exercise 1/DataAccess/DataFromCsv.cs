
namespace Session_7___Exercise_1.DataAccess
{
    public class DataFromCsv
    {
        public string RootPath;
        public string[] File1Array;
        public string[] File2Array;
        public string[] CombinedCsvData; 

        public DataFromCsv(string rootpath)
        {
            this.RootPath = rootpath;
            this.File1Array = ReadFromCsv1("file1.csv");
            this.File2Array = ReadFromCsv2("file2.csv");
            this.CombinedCsvData = CombineCsvData(); 
        }

        public string[] ReadFromCsv1(string filename)
        {
            string path = RootPath + "file1.csv";

            if (File.Exists(path))
            {
                string[] temp = File.ReadAllLines(path);
                return temp;
            }
            else
            {
                return new string[0];
            }
        }

        public string[] ReadFromCsv2(string filename)
        {
            string path = RootPath + "file2.csv";

            if (File.Exists(path))
            {
                string[] temp = File.ReadAllLines(path);
                return temp;
            }
            else
            {
                return new string[0];
            }
        }

        public string[] CombineCsvData()
        {
            Array.Reverse(File1Array);
            Array.Reverse(File2Array);

            string[] combinedArray = new string[File2Array.Length + File1Array.Length];

            Array.Copy(File2Array, combinedArray, File2Array.Length);

            Array.Copy(File1Array, 0, combinedArray, File2Array.Length, File1Array.Length);

            this.CombinedCsvData = combinedArray;

            return combinedArray;

        }
    }
}
