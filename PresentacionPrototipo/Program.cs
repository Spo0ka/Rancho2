﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionPrototipo
{
    public class Program
    {
        [STAThread]
        static void Main() 
        {
            Application.Run(new FrmMenu());
        }
    }
}
