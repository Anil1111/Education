using System.Data;
using System.IO;

namespace _005_SerializationDataSet
{
    //Этот пример говорит, что DataSet сериализуется.
    class Program
    {
        public static void SerializedDataSet(string fileName)
        {
            // Создаем DataSet; добавляем таблицу, столбец и десять строк.
            DataSet dataSet = new DataSet("myDataSet");
            DataTable dataTable = new DataTable("table1");
            DataColumn dataColumn = new DataColumn("thing");

            dataTable.Columns.Add(dataColumn);
            dataSet.Tables.Add(dataTable);

            DataRow dataRow;

            for (int i = 0; i < 10; i++)
            {
                dataRow = dataTable.NewRow();
                dataRow[0] = "Thing " + i;

                dataTable.Rows.Add(dataRow);
            }

            dataSet.WriteXml(fileName);
            dataSet.WriteXmlSchema(Path.ChangeExtension(fileName,"xsd"));
        }
        static void Main(string[] args)
        {
            SerializedDataSet("SerializedDataSet.xml");
        }
    }
}
