using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class vt
    {
        public static string baglanti = @"Data Source=DESKTOP-HG2TT45\SQLEXPRESS;
                           Initial Catalog=OdevEvProje;
                           User Id=sa; Password=qw-1;";

        public static SqlConnection con = new SqlConnection(baglanti);
    }
}
