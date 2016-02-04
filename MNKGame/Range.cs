using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNKGame
{
    public class Range : IEnumerable<int>
    {
        public int From { get; private set; }
        public int To { get; private set; }

        public static Range Create(int upperBound)
        {
            return Range.Create(0, upperBound - 1);
        }

        public static Range Create(int from, int to)
        {
            return new Range(from, to);
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Range(int from, int to)
        {
            this.From = from;
            this.To = to;
        }

        public void ForEach(Action<int> action)
        {
            foreach (var i in this)
            {
                action(i);
            }
        }

        public class Enumerator : IEnumerator<int>
        {
            private Range range;
            private int increment;
            private int current;

            int IEnumerator<int>.Current
            {
                get
                {
                    return this.current;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.current;
                }
            }

            public Enumerator(Range range)
            {
                this.range = range;
                this.increment = range.From < range.To ? 1 : -1;
            }

            void IDisposable.Dispose()
            {
            }

            bool IEnumerator.MoveNext()
            {
                this.current += this.increment;
                return this.current < this.range.To;
            }

            void IEnumerator.Reset()
            {
                this.current = this.range.From;
            }
        }
    }


}
