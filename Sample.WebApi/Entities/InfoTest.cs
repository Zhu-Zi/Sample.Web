using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.WebApi.Entities
{
    [Table("infotest")]
    public class InfoTest
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("remark")]
        public string Remark { get; set; }
    }
}
