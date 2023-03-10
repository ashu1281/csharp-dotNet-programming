using System;

namespace csharp_programming
{
    internal class DummyDerived : DummyBase
    {
        private int j;
        public DummyDerived(int i, int j) : base(i) {
            this.j = j;
        }
    }
}
