using dummy_class_library;

namespace cshar_programming
{
    internal class DummyDerived2:DummyBase
    {
        public void Q()
        {
            a = 1;//private
            b = 2;//protected
            c = 3;//public
            d = 4;//internal
            e = 5;//protected internal
            f = 6;//private protected
        }
    }
}
