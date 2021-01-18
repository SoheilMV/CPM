using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CPM
{
    public class DataPool
    {
        private readonly object _obj = new object();
        private List<Data> _datas = new List<Data>();

        /// <summary>The checks per minute.</summary>
        public int CPM
        {
            get
            {
                lock (_obj)
                {
                    var temp = 0;
                    if (_datas.Count == 0)
                    {
                        return temp;
                    }
                    try
                    {
                        for (int i = _datas.Count() - 1; i >= 0; i--)
                        {
                            if ((DateTime.Now - _datas[i].Time).TotalSeconds > 60)
                            {
                                break;
                            }
                            temp++;
                        }
                    }
                    catch
                    {
                    }
                    return temp;
                }
            }
        }

        public void Add()
        {
            _datas.Add(new Data());
        }

        public void Clear()
        {
            _datas.Clear();
        }
    }
}
