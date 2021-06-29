using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace hhhh.Data
{
    class e_mail
    {
        [PrimaryKey, Column("_id")]
        public int Id { get; set; }
        public string Email_Addr { get; set; }

        //0 -> RED
        //1 -> BLACK
        //2 -> WHITE
    }
}
