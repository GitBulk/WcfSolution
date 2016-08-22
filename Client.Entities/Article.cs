using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Client.Entities
{
    public class Article : Validatable, IExtensibleDataObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Contents { get; set; }
        public string Url { get; set; }
        public int BlogId { get; set; }

        public ExtensionDataObject ExtensionData
        {
            get;
            set;
        }

        protected override IValidator GetValidator()
        {
            return new ArticleValidator();
        }
    }
}
