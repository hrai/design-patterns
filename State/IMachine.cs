namespace State
{
    public interface IMachine
    {
        void SetState(IState state);
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void ResetBall();
        void Refill(int balls);
        /* void DispenseGumball(); */
        IState GetOutOfGumballs();
        IState GetGumballSold();
        IState GetNoQuarter();
        IState GetHasQuarter();
        IState GetWinner();

        int Gumballs();
    }
}
