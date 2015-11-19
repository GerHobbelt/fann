﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace FANNCSharp
{
    public class AccessorEnumerator<T> : IEnumerator<T>
    {
        internal AccessorEnumerator(IAccessor<T> accessor)
        {
            CurrentIndex = 0;
        }

        public T Current
        {
            get
            {
                return Accessor[CurrentIndex];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Accessor[CurrentIndex];
            }
        }

        public void Dispose()
        {
            return;
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return CurrentIndex < Accessor.Count;
        }

        public void Reset()
        {
            CurrentIndex = 0;
        }
        private IAccessor<T> Accessor { get; set; }
        private int CurrentIndex { get; set; }
    }
}
