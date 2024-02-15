using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXia.TestCreateTable2
{
    [Table("TestCreateTable2")]
    public class TestCreateTable2
    {
        public virtual int Id { get; set; }

        public virtual string String { get; set; }

        public virtual decimal Decimal { get; set; }
    }
}
