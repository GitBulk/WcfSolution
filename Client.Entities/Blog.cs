using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.Runtime.Serialization;

namespace Client.Entities
{
    public class Blog : Validatable, IExtensibleDataObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Owner { get; set; }

        public ExtensionDataObject ExtensionData
        {
            get;
            set;
        }

        protected override IValidator GetValidator()
        {
            return new BlogValidator();
        }
    }
}
