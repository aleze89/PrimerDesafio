using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio.Models
{
    public class Comments
    {
        public int CommentsId { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public ICollection<PrimerDesafio.Models.User> Users { get; set; }

    }
}
