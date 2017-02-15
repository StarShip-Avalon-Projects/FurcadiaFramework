using System.Data;
using System.IO;
using System.Reflection;

namespace Furcadia
{
    internal class SpeciesTable
    {
        private static DataTable dt = null;

        public static void PrimeTable()
        {
            try
            {
                //using (Stream streamie = Assembly.GetExecutingAssembly()
                //        .GetManifestResourceStream("Furcadia.Resources.SpeciesTable.csv"))
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Furcadia.Resources.SpeciesTable.csv");

                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    result = result.Replace("\r", "");
                    result = result.Replace("\"", "");
                    string[] csvRows = result.Split('\n');
                    string[] fields = null;
                    dt = new DataTable();

                    foreach (string Field in csvRows[0].Split(new char[] { ',' }))
                        dt.Columns.Add(new DataColumn(Field, typeof(string)));
                    for (int i = 1; i < csvRows.Length; i++)
                    {
                        fields = csvRows[i].Split(',');
                        DataRow row = dt.NewRow();
                        row.ItemArray = fields;
                        dt.Rows.Add(row);
                    }
                }
            }
            catch
            {
            }
        }

        //Convert Species to number
        public static int SpecNum(int species, int special)
        {
            int result = 0;
            if (dt == null)
                PrimeTable();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int Special = 0;
                int.TryParse(dt.Rows[i]["Special"].ToString(), out Special);
                if (Special == special)
                {
                    switch (Special)
                    {
                        // Rodent
                        case 0:
                        case 10:
                        case 40:
                        case 50:
                        case 80:
                        case 100:
                        // Equine
                        case 1:
                        case 11:
                        case 41:
                        case 51:
                        case 81:
                        case 101:
                        // Feline
                        case 2:
                        case 12:
                        case 42:
                        case 52:
                        case 82:
                        case 102:
                        // cainine
                        case 3:
                        case 13:
                        case 43:
                        case 53:
                        case 83:
                        case 103:
                        // Musteline
                        case 4:
                        case 14:
                        case 44:
                        case 54:
                        case 84:
                        case 104:
                        // Lapine
                        case 5:
                        case 15:
                        case 45:
                        case 55:
                        case 85:
                        case 105:
                        // Squirrel
                        case 6:
                        case 16:
                        case 46:
                        case 56:
                        case 86:
                        case 106:
                        // Bovine
                        case 7:
                        case 17:
                        case 47:
                        case 57:
                        case 87:
                        case 107:
                        // SUrsine
                        case 8:
                        case 18:
                        case 48:
                        case 58:
                        case 88:
                        case 108:
                        // Squirrel
                        case 9:
                            result = species + 1;
                            break;

                        default:
                            int.TryParse(dt.Rows[i]["DS"].ToString(), out result);
                            break;
                    }
                    break;
                }
            }

            return result;
        }

        public static int WingsNum(int species, int special)
        {
            int result = 0;
            if (dt == null)
                PrimeTable();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int Special = 0;
                int.TryParse(dt.Rows[i]["Special"].ToString(), out Special);
                if (Special == special)
                {
                    int.TryParse(dt.Rows[i]["Wings"].ToString(), out result);
                    break;
                }
            }

            return result;
        }

        ////convert Species to name
        //public static string SpecName(int species, int special)
        //{
        //    if (dt == null)
        //        PrimeTable();
        //    DataRow[] dr = dt.Select("special = " + special);

        //    return "";
        //}
    }
}