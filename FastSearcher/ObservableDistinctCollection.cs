using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;

namespace MIF
{
    class ObservableDistinctCollection
    {
        private Dictionary<string, FileInfo> dictionary;

        private ObservableCollection<FileInfo> list;

        public ObservableDistinctCollection()
        {
            dictionary = new Dictionary<string, FileInfo>();
            list = new ObservableCollection<FileInfo>();
        }


        public FileInfo this[int index]
        {
            get
            {
                return list[index];
            }
        }


        public int Count
        {
            get
            {
                return list.Count;
            }
        }


        public bool AddItem(FileInfo item)
        {
            string key = item.FullName;
            bool canAdd = !dictionary.ContainsKey(key);

            if (canAdd)
            {
                dictionary.Add(key, item);
                list.Add(item);
            }

            return canAdd;
        }


        public bool RemoveItem(FileInfo item)
        {
            string key = item.FullName;
            bool canDel = dictionary.ContainsKey(key);
            
            if (canDel)
            {
                dictionary.Remove(key);
                list.Remove(item);
            }

            return canDel;
        }

        public void Clear()
        {
            dictionary.Clear();
            list.Clear();
        }


        public event NotifyCollectionChangedEventHandler CollectionChanged
        {
            add
            {
                list.CollectionChanged += value;
            }

            remove
            {
                list.CollectionChanged -= value;
            }
        }
    }
}
