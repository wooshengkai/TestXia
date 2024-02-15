using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXia.TestCreateTable
{
    [Table("TestCreateTable")]
    public class TestCreateTable : Entity<long>
    {
        public virtual string String { get; set; }

        public virtual decimal Decimal { get; set; }

        public virtual int Integer { get; set; }

        public virtual int NewColumn { get; set; }

        public virtual int NewColumn2 { get; set; }
    }
}
