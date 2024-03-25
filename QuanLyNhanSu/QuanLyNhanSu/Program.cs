using ontapProjects;
using System;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());

            /* Test ket noi database
             * Console.WriteLine("lay du lieu...");
            SqlConnection connection = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("ket noi database");
                connection.Open();
                Console.WriteLine("Ket noi thanh cong");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erroe:" + e.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Dong ket noi");
            }*/
        }
    }
}
