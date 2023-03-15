
namespace dummy_class_library
{
    internal class DummyDerived :DummyBase
    {
        public void M()
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
