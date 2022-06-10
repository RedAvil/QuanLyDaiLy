using BUS_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TrangChuQuanLy());
            Application.Run(new Login());
            //Application.Run(new baocaocongno());
            //Application.Run(new phieuxuathang());
            //Application.Run(new FormChuongTrinhQLDL());         
            Console.WriteLine("START PROGRAM!");           
        }
    }
}
