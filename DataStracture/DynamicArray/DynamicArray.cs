namespace DataStracture.DynamicArray
{
    public class DynamicArray<T>
    {
        private T[] _data;
        private int _count;

        public DynamicArray() : this(4)
        {

        }

        public DynamicArray(int size)
        {
            _data = new T[size];
            _count = 0;
        }
        private void Resize()
        {
            int capasity = _data.Length == 0 ? 4 : _data.Length * 2;
            T[] newArray = new T[capasity];
            _data.CopyTo(newArray, 0);
            _data = newArray;
        }
        public bool IsFull()
        {
            return _count == _data.Length;
        }
        public void Add(T item)
        {
            if (this.IsFull())
                this.Resize();
            _data[_count++] = item;
        }
        public void Insert(T item, int index)
        {
            if (index > _count) return;
            if (this.IsFull())
                this.Resize();
            Array.Copy(_data, index, _data, index + 1, _count - index);
            _data[index] = item;
            _count++;

        }
        public void RemoveAt(int index)
        {
            int shiftStart = index + 1;

            if (shiftStart < _count)
                Array.Copy(_data, shiftStart, _data, index - 1, _count - shiftStart);

            _count--;
            _data[_count] = default;
        }
        public bool Remove(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_data[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_data[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(T item)
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (_data[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }
    }
}
