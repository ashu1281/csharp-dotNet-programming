namespace cshar_programming
{
    internal abstract class ResistorCollection : IResister
    {
       private protected List<IResister> list = new List<IResister>();


        //Add function that add Resistor to List
        public void Add(IResister ir)
        {
            list.Add(ir);
        }

        public abstract double GetResistance();

    }
}
