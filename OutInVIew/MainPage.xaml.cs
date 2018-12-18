using OutInVIew.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace OutInVIew
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<string> strs = new ObservableCollection<string>();
        public static CollectionViewSource collectionView = new CollectionViewSource();
        public ObservableCollection<StringGroup> groupItem =
            new ObservableCollection<StringGroup>();
        public MainPage()
        {
            this.InitializeComponent();
            strs.Add("2010-08-11");
            strs.Add("2011-01-11");
            strs.Add("2008-11-11");
            strs.Add("2018-12-10");

            GetGroups();
            
        }

        public void GetGroups()
        {
            List<string> groupList = new List<string>();
            foreach (var item in strs)
            {
                string val = item.ToString().Substring(0, 7);
                if (groupList.Contains(val))
                {
                    var group = groupItem.First
                        (p => p.ToString().Substring(0, 7) == val);
                    group.groupItems.Add(item);
                }
                else
                {
                    groupList.Add(val);
                    var group = new StringGroup()
                    {
                        groupName = val
                    };
                    group.groupItems.Add(item);
                    groupItem.Add(group);
                }
            }
        }
        
    }
}
