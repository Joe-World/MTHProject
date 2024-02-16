using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wgd.Utils
{
    class ByteArray
    {
        //初始化
        private List<byte> list = new List<byte>();



        #region 属性
        //list集合
        public List<byte> List
        {
            get { return list; }
        }

        //list集合转Array数组
        public byte[] Array
        {
            get { return list.ToArray(); }
        }

        //list集合长度
        public int length
        {
            get { return list.Count; }
        }
        #endregion

        //添加一个字节
        public void Add(byte item)
        {
            list.Add(item);
        }

        //添加一个数组
        public void Add(byte[] items)
        {
            list.AddRange(items);
        }

        //添加一个集合
        public void Add(List<byte> items)
        {
            list.AddRange(items);
        }

        public void Add(byte item1, byte item2)
        {
            Add(new byte[] { item1, item2 });
        }


        public void Add(byte item1, byte item2, byte item3)
        {
            Add(new byte[] { item1, item2, item3 });
        }


        public void Add(byte item1, byte item2, byte item3, byte item4)
        {
            Add(new byte[] { item1, item2, item3, item4 });
        }

        public void Add(byte item1, byte item2, byte item3, byte item4, byte item5)
        {
            Add(new byte[] { item1, item2, item3, item4, item5 });
        }

        //添加一个ByteArray类型
        public void Add(ByteArray byteArray)
        {
            Add(byteArray.Array);
        }

        //添加一个short类型
        public void Add(short value)
        {
            Add((byte)(value >> 8));
            Add((byte)value);
        }

        //添加一个Ushort类型
        public void Add(ushort value)
        {
            Add((byte)(value >> 8));
            Add((byte)value);
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
