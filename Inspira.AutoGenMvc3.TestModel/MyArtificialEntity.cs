using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Inspira.AutoGenMvc3.TestModel
{
    public class MyArtificialEntity
    {
        [DataType("Hidden")]
        virtual public Guid ID { get; set; }
        
        [StringLength(20)]
        virtual public String MyString { get; set; }

        [DataType(DataType.MultilineText)]
        virtual public String MyClearText { get; set; }

        [UIHint("Html")]
        [DataType(DataType.Custom | DataType.Html)]
        virtual public String MyHtmlText { get; set; }

        virtual public Char MyChar { get; set; }
        virtual public Byte MyByte { get; set; }
        virtual public Int16 MyInt16 { get; set; }
        virtual public Int32 MyInt32 { get; set; }
        virtual public Int64 MyInt64 { get; set; }

        virtual public Single MySingle { get; set; }
        virtual public Double MyDouble { get; set; }
        virtual public Decimal MyDecimal { get; set; }

        [DataType(DataType.Currency)]
        virtual public Decimal MyMoney { get; set; }

        virtual public Boolean MyBoolean { get; set; }
        virtual public DateTime MyDateTime { get; set; }

        [DataType(DataType.Date)]
        virtual public DateTime MyDate { get; set; }

        [DataType(DataType.Duration)]
        virtual public TimeSpan MyTime { get; set; }
    }
}
