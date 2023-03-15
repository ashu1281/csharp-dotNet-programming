namespace dummy_class_library
{
    internal class AnotherDummy
    {
        private DummyBase dummyBase = new DummyBase();

        public void N()
        {
            dummyBase.a = 1;//private
            dummyBase.b = 2;//protected
            dummyBase.c = 3;//public
            dummyBase.d = 4;//internal
            dummyBase.e = 5;//protected internal
            dummyBase.f = 6;//private protected
        }
    }
}
