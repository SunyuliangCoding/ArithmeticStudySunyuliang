/**************************************************************************      
项    目:        哈希表
作    者:        SYL syl
创建时间:        2018/12/6 11:52:03
Copyright (c)    北京迪威特科技有限公司

描    述：
***************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace 哈希表
{
    public class HashTable<T1, T2>
    {
        private HashItem<T1, T2>[] datas;
        private int arrayLength = 5;

        private decimal loadFactor = 0;

        private int _dataLength { get; set; }
        public int DataLength { get => _dataLength; }


        public HashTable()
        {
            datas = new HashItem<T1, T2>[arrayLength];
            _dataLength = 0;
        }

        public void Add(T1 key, T2 value)
        {
            if (arrayLength > 0.8)
            {
                //启动扩容
            }

            var hashItem = new HashItem<T1, T2>() { Key = key, Value = value };
            var index = key.GetHashCode() % arrayLength;
            if (datas[index] != null)
            {
                var loopCount = this.arrayLength;
                //处理哈希冲突               
                for (int i = index + 1; i < loopCount; i++)
                {
                    if (datas[i] == null)
                    {
                        datas[i] = hashItem;
                        break;
                    }
                    if (i == loopCount - 1)
                    {
                        i = 0;
                        loopCount = index;
                    }
                }
            }
            this.datas[index] = hashItem;
            _dataLength++;
            this.loadFactor = _dataLength / arrayLength;
        }
        public T2 Get(T1 Key)
        {
            var index = Key.GetHashCode() % arrayLength;
            var hashItem = datas[index];

            if (hashItem.Key.Equals(Key))
            {
                return hashItem.Value;

            }
            else
            {
                for (int i = index + 1; i < arrayLength; i++)
                {
                    if (hashItem.Key.Equals(Key) && hashItem.IsDelete == false)
                    {
                        return hashItem.Value;
                    }
                }
                return default(T2);
            }
        }

        public void Delete(T1 key)
        {
            var index = key.GetHashCode() % arrayLength;
            var hashItem = datas[index];
            if (hashItem != null)
            {
                //相等说明可以删除
                if (hashItem.Key.Equals(key))
                {

                    hashItem.IsDelete = true;
                }
                else
                {
                    var loopCount = this.arrayLength;
                    //处理哈希冲突               
                    for (int i = index + 1; i < loopCount; i++)
                    {
                        if (datas[i].Key.Equals(key) || datas[i].IsDelete == false)
                        {
                            datas[i].IsDelete = true;
                            break;
                        }
                        if (i == loopCount - 1)
                        {
                            i = 0;
                            loopCount = index;
                        }
                    }
                }
            }
        }
    }

    public class HashItem<T1, T2>
    {
        public T1 Key { get; set; }
        public T2 Value { get; set; }

        public bool IsDelete = false;
    }


}
