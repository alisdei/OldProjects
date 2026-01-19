using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace MvcTest.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Title { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Edicion { get; set; }
    }
}