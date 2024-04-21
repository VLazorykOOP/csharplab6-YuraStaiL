namespace Lab6
{
    internal interface IPerson : IComparable
    {
        int Age { get; }
        void Print();
    }
}
