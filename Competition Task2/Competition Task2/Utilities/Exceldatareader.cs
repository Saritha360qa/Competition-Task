using ExcelDataReader;
using System.Data;
using System.Text;

namespace Competition_Task2.Utilities
{
    public class Exceldatareader
    {
        static List<Datacollection> dataCol = new List<Datacollection>();
        public class Datacollection
        {
            public int rowNumber { get; set; }
            public string ColName { get; set; }
            public string ColValue { get; set; }
        }
        public static void ClearData()
        {
            dataCol.Clear();
        }
        public static void fileClose(string fileName)
        {
            fileClose(fileName);
        }
        public static DataTable ExcelDataTable(string filename)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            DataTableCollection table = resultSet.Tables;
            DataTable resultTable = table["Sheet1"];
            return resultTable;
        }                
        public static void populateCollection(string filename)
        {
            DataTable table = ExcelDataTable(filename);
            for (int row = 1; row <= table.Rows.Count; row++)
            {

                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        ColName = table.Columns[col].ColumnName,
                        ColValue = table.Rows[row - 1][col].ToString()
                    };
                    dataCol.Add(dtTable);
                }
            }
        }
        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                IEnumerable<string> enumerable()
                {
                    foreach (var colData in dataCol)
                    {
                        if (colData.ColName == columnName && colData.rowNumber == rowNumber)
                        {
                            yield return colData.ColValue;
                        }
                    }
                }
                string data = enumerable().SingleOrDefault();
                return data.ToString();
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return null;
            }
        }
    }
}