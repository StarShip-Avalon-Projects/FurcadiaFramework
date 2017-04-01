using System;
using System.Data;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Furcadia.Security
{
    internal class SslCert
    {
        #region Public Constructors

        public SslCert()
        {
            //Do webrequest to get info on secure site
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://mail.google.com");
            request.AllowAutoRedirect = false;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();

            //retrieve the ssl cert and assign it to an X509Certificate object
            X509Certificate cert = request.ServicePoint.Certificate;

            //convert the X509Certificate to an X509Certificate2 object by passing it into the constructor
            X509Certificate2 cert2 = new X509Certificate2(cert);

            string cn = cert2.GetIssuerName();
            string cedate = cert2.GetExpirationDateString();
            string cpub = cert2.GetPublicKeyString();

            // display the cert dialog box
            //X509Certificate2.d(cert2);
        }

        #endregion Public Constructors

        #region Public Methods

        public static void PrintDataSet(DataSet ds)
        {
            // Print out all tables and their columns
            foreach (DataTable table in ds.Tables)
            {
                Console.WriteLine("TABLE '{0}'", table.TableName);
                Console.WriteLine("Total # of rows: {0}", table.Rows.Count);
                Console.WriteLine("---------------------------------------------------------------");

                foreach (DataColumn column in table.Columns)
                {
                    Console.WriteLine("- {0} ({1})", column.ColumnName, column.DataType.ToString());
                }  // foreach column

                Console.WriteLine(System.Environment.NewLine);
            }  // foreach table

            // Print out table relations
            foreach (DataRelation relation in ds.Relations)
            {
                Console.WriteLine("RELATION: {0}", relation.RelationName);
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Parent: {0}", relation.ParentTable.TableName);
                Console.WriteLine("Child: {0}", relation.ChildTable.TableName);
                Console.WriteLine(System.Environment.NewLine);
            }  // foreach relation
        }

        public void RunSample()
        {
            // Create the web request
            HttpWebRequest request
                = WebRequest.Create("http://xml.weather.yahoo.com/forecastrss?p=94704") as HttpWebRequest;

            // Get response
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // Load data into a dataset
                DataSet dsWeather = new DataSet();
                dsWeather.ReadXml(response.GetResponseStream());

                // Print dataset information
                PrintDataSet(dsWeather);
            }
        }

        #endregion Public Methods
    }
}