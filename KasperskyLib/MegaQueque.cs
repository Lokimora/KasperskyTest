using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KasperskyLib
{
    public class MegaQueque<T>
    {
        protected object _locker = new object();

        protected Queue<T> _queque;


        public MegaQueque()
        {
            _queque = new Queue<T>();
        }


        public void Push(T item)
        {

            lock (_locker)
            {
                _queque.Enqueue(item);
                Monitor.PulseAll(_locker);
            }

        }

        public T Pop()
        {
            lock (_locker)
            {
                while (_queque.Count == 0)
                {
                    Monitor.Wait(_locker);
                }

                return _queque.Dequeue();
            }
        }


    }
}
