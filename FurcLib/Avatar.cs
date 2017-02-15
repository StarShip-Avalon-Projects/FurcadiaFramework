using System;
using System.Data;
using System.IO;
using System.Reflection;

namespace Furcadia
{
    public class Avatar
    {
        /// <summary>
        ///
        /// </summary>
        public struct Frame
        {
            public int Spec;
            public int dir;
            public int pose;
            public int gender;
            public int DS_Number;
            public int Wings;

            public void Clear()
            {
                Spec = -1;
                dir = -1;
                pose = -1;
                gender = -1;
                DS_Number = -1;
                Wings = -1;
            }
        }

        private enum av_DIR
        {
            SW,
            SE,
            NW,
            NE,
        };

        private enum av_POSE
        {
            AVPOSE_SIT,
            AVPOSE_WALK0,
            AVPOSE_STAND,
            AVPOSE_WALK1,
            AVPOSE_LIE,
        };

        private static DataTable dt = null;

        /// <summary>
        /// Primes the table.
        /// </summary>
        public static void PrimeTable()
        {
            try
            {
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Furcadia.Resources.AvatarFrames.csv");
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

        /// <summary>
        /// Specs the number.
        /// </summary>
        /// <param name="Frame">The frame.</param>
        /// <returns></returns>
        public static Frame SpecNum(int Frame)
        {
            Frame _Frame = new Frame();
            int Species = Frame - (Frame % 20);
            if (dt == null)
                PrimeTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object test = dt.Rows[i]["FrameIndex"];
                if (Convert.IsDBNull(test) == false)
                    // "Species","FrameIndex","Gender","DS"
                    if (Species == Convert.ToInt32(dt.Rows[i]["FrameIndex"]))
                    {
                        _Frame.Spec = Species;
                        int.TryParse(dt.Rows[i]["DS"].ToString(), out _Frame.DS_Number);
                        int.TryParse(dt.Rows[i]["Gender"].ToString(), out _Frame.gender);
                        int.TryParse(dt.Rows[i]["Wings"].ToString(), out _Frame.Wings);
                        switch (Frame % 20)
                        {
                            case 0:
                                _Frame.dir = (int)av_DIR.SW;
                                _Frame.pose = (int)av_POSE.AVPOSE_SIT;
                                return _Frame;

                            case 1:
                                _Frame.dir = (int)av_DIR.SW;
                                _Frame.pose = (int)av_POSE.AVPOSE_WALK0;
                                return _Frame;

                            case 2:
                                _Frame.dir = (int)av_DIR.SW;
                                _Frame.pose = (int)av_POSE.AVPOSE_STAND;
                                return _Frame;

                            case 3:
                                _Frame.dir = (int)av_DIR.SW;
                                _Frame.pose = (int)av_POSE.AVPOSE_WALK1;
                                return _Frame;

                            case 4:
                                _Frame.dir = (int)av_DIR.SE;
                                _Frame.pose = (int)av_POSE.AVPOSE_SIT;
                                return _Frame;

                            case 5:
                                _Frame.dir = (int)av_DIR.SE;
                                _Frame.pose = (int)av_POSE.AVPOSE_WALK0;
                                return _Frame;

                            case 6:
                                _Frame.dir = (int)av_DIR.SE;
                                _Frame.pose = (int)av_POSE.AVPOSE_STAND;
                                return _Frame;

                            case 7:
                                _Frame.dir = (int)av_DIR.SE;
                                _Frame.pose = (int)av_POSE.AVPOSE_WALK1;
                                return _Frame;

                            case 8:
                                _Frame.dir = (int)av_DIR.NW;
                                _Frame.pose = (int)av_POSE.AVPOSE_SIT;
                                return _Frame;

                            case 9:
                                _Frame.dir = (int)av_DIR.NW;
                                _Frame.pose = (int)av_POSE.AVPOSE_WALK0;
                                return _Frame;

                            case 10:
                                _Frame.dir = (int)av_DIR.NW;
                                _Frame.pose = (int)av_POSE.AVPOSE_STAND;
                                return _Frame;

                            case 11:
                                _Frame.dir = (int)av_DIR.NW;
                                _Frame.pose = (int)av_POSE.AVPOSE_WALK1;
                                return _Frame;

                            case 12:
                                _Frame.dir = (int)av_DIR.NE;
                                _Frame.pose = (int)av_POSE.AVPOSE_SIT;
                                return _Frame;

                            case 13:
                                _Frame.dir = (int)av_DIR.NE;
                                _Frame.pose = (int)av_POSE.AVPOSE_WALK0;
                                return _Frame;

                            case 14:
                                _Frame.dir = (int)av_DIR.NE;
                                _Frame.pose = (int)av_POSE.AVPOSE_STAND;
                                return _Frame;

                            case 15:
                                _Frame.dir = (int)av_DIR.NE;
                                _Frame.pose = (int)av_POSE.AVPOSE_WALK1;
                                return _Frame;

                            case 16:
                                _Frame.dir = (int)av_DIR.NW;
                                _Frame.pose = (int)av_POSE.AVPOSE_LIE;
                                return _Frame;

                            case 17:
                                _Frame.dir = (int)av_DIR.NE;
                                _Frame.pose = (int)av_POSE.AVPOSE_LIE;
                                return _Frame;

                            case 18:
                                _Frame.dir = (int)av_DIR.SE;
                                _Frame.pose = (int)av_POSE.AVPOSE_LIE;
                                return _Frame;

                            case 19:
                                _Frame.dir = (int)av_DIR.SW;
                                _Frame.pose = (int)av_POSE.AVPOSE_LIE;
                                return _Frame;
                        }
                    }
                    else
                    {
                        _Frame.Clear();
                        return _Frame;
                    }
            }
            _Frame.Clear();
            return _Frame;
        }

        //end class
    }
}