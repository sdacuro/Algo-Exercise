using System;

namespace Algo {
    public class Array2 
    {
        private int _itemCount = 0;
        int[] _data;
        public Array2(int length)
        {
            _data = new int[length];
        }

        public void Insert(int item) 
        {
            if (_itemCount == _data.Length)
                Resize();

            _data[_itemCount++] = item;
        }
        public void RemoveAt(int index) 
        {
            if (index < 0 ||  index > _itemCount)
                throw new Exception("Out of bound.");

            for(int i = index; i < _itemCount; i++) 
            {
                int nextIndex =  i + 1;
                if (nextIndex == _itemCount)
                    _data[i] = 0;
                else
                    _data[i] = _data[i + 1];
            }
            _itemCount--;
        }

        public void IntertAt(int item, int index) 
        {
            if (index < 0 ||  index > _itemCount)
                throw new Exception("Out of bound.");

            if (index == _itemCount)
                Resize();

            int[] newData = Copy();

            for(int i = index; i < _itemCount; i++) 
            {
                if (i == index)
                    _data[i] = item;

                _data[i + 1] = newData[i];
            }
            _itemCount++;
        }

        public void Reverse() 
        {
            int[] newData = Copy();
            for(int i = 0; i < _itemCount; i++) 
            {
                _data[i] = newData[_itemCount - (i +1)];
            }
        }
        public int[] Copy() 
        {
            int[] result = new int[_itemCount];

            for(int i = 0; i < _itemCount; i++)
            {
                result[i] = _data[i];
            }
            return result;
        }

        public int IndexOf(int value) 
        {
            for(int i = 0; i < _itemCount; i++) 
            {
                if(_data[i] == value)
                    return i;
            }
            return -1;
        }

        public void Print() 
        {
            for(int i = 0; i < _itemCount; i++) 
            {
                Console.WriteLine(_data[i]);  
            }  
        }

        public void Resize()
        {
            var oldData = _data;
            _data = new int[_itemCount * 2];
            for(int i = 0; i < _itemCount; i++)
            {
                _data[i] = oldData[i];
            }
        }

        public int Max() 
        {
            int maxValue = 0;
            for(int i = 0; i < _itemCount; i++)
            {
                if (_data[i] > maxValue)
                    maxValue = _data[i];
            }
            return maxValue;
        }

        private int GetPositionFirstEmptyIndex() 
        {
            int result = 0;
            foreach(var itm in _data)
            {
                if (itm == 0) 
                {
                    return  result;
                }
                result++;
            }
            return result;
        }
    }
}