using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smk_resto1
{
    class Env
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=smk_resto;Integrated Security=True");
    }
}
