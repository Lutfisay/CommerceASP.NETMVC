using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceData.Models
{
    public class Category
    {
        //Id, ParentId, Name,Description, PictureId, DisplayOrder, IsActive

        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PictureId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public List<Category> SubCategories { get; set; }
    }
}
