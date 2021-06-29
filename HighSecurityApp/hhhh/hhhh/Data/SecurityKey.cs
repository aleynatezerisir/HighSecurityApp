using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace hhhh.Data
{
    class SecurityKey
    {
        [PrimaryKey, Column("_id")]
        public int Id { get; set; }
        public int keyValue { get; set; }

        //0 -> RED
        //1 -> BLACK
        //2 -> WHITE
    }
}
