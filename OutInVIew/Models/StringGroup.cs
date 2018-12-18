using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutInVIew.Models
{
    public class StringGroup
    {
        public string groupName { get; set; }

        public ObservableCollection<string> groupItems =
            new ObservableCollection<string>();
    }
}
