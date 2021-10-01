using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]//hangi stunun birincil  belirlemeye yarıyor
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }//başlık
        public string BlogContent { get; set; }//içerik alanı
        public string BlogSmallImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }//oluşturma date
        public bool BlogStatus { get; set; }
        //ilişkiler
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }



    }
}
