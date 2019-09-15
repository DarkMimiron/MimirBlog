using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MimirBlog.Models{
    public class Entry{
        public int EntryId{ get; set; }
        public string Title{ get; set; }
        public string Text{ get; set; }
        public DateTime CreationDate{ get; set; }
        public ICollection<EntryTag> EntryTags{ get; set; }

        public Entry(){
            EntryTags = new Collection<EntryTag>();
            CreationDate = DateTime.Now;
        }
    }
}