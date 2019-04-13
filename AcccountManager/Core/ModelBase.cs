using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace AcccountManager.Core
{
    public class ModelBase<T>
    {
        public T Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
