using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MimirBlog.Models{
    public class Tag{
        public int TagId{ get; set; }
        public string Description{ get; set; }
        public ICollection<EntryTag> EntryTags{ get; set; }

        public Tag(){
            EntryTags = new Collection<EntryTag>();
        }
    }
}