/* Author: Gerolkae
 * 
 * Uses: Displaying proper badge in Look responce  and whisper
 * Logging text equivelant "[Group-Level]" IE: [Bugge-Elder]
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Reflection;

namespace Furcadia
{
    public class Badges
    {
        enum Group
        {
            none,
            Guardian = 1,
            Channel,
            Mason,
            Scribe,
            Bugge,
            Pixel,
            Welcomer,
            Helper,
            Teacher,
            Mentor,
            DEP,
            Irregular,
            Eventer
            
        };
        enum Level
        {
            none,
            Trainee = 1,
            Member,
            Elder,
            Head,
            AIC,
            Associate,
            Creator
        };
        private static DataTable dt = null;
        public static void PrimeTable()
        {
            try
            {
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Furcadia.Resources.badges.csv");
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
            catch (Exception ex)
            {

            }
        }

       public static int GetGroup(string tag)
        {
            if (tag == "")
                return 0;
            if (dt == null)
                PrimeTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object test = dt.Rows[i]["Hash"];
                if (Convert.IsDBNull(test) == false)
                    if (tag == dt.Rows[i]["Hash"])
                        return Convert.ToInt32(dt.Rows[i]["Group"]);
                    else
                        return 0;
                    
            }
            return 0;
        }
        public static int GetLevel(string tag)
        {
            if (tag == "")
                return 0;
            if (dt == null)
                PrimeTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object test = dt.Rows[i]["Hash"];
                if (Convert.IsDBNull(test) == false)
                    if (tag == dt.Rows[i]["Hash"])
                        return Convert.ToInt32(dt.Rows[i]["Level"]);
                    else
                        return 0;

            }
            return 0;
        }

        public static T NumToEnum<T>(int number)
        {
            return (T)Enum.ToObject(typeof(T), number);
        }

        public static string GetTag(string tag)
        {
            if (tag == "")
                return "";
            if (dt == null)
                PrimeTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object test = dt.Rows[i]["Hash"];
                if (Convert.IsDBNull(test) == false)
                    if (tag == (string) test)
                    {
                        int lvl = Convert.ToInt32(dt.Rows[i]["Level"]);
                        int grp = Convert.ToInt32(dt.Rows[i]["Group"]);
                        Group g = NumToEnum<Group>(grp);
                        Level l = NumToEnum<Level>(lvl);
                        return "[" + g + "-" + l + "]";
                    }


            }
            return "";
        }

    }
}
