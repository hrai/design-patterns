namespace State
{
    public interface IMachine
    {
        void SetState(IState state);
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void DispenseGumball();
        IState GetOutOfGumballs();
        IState GetGumballSold();
        IState GetNoQuarter();
        IState GetHasQuarter();
        int Gumballs();
    }
}