namespace State
{
    public class GumballMachine : IMachine
    {
        private IState NoQuarter;
        private IState HasQuarter;
        private IState OutOfGumballs;
        private IState GumballSold;
        private IState Winner;

        private IState _state;
        private int _noOfGumballs;

        public GumballMachine(int noOfGumballs)
        {
            NoQuarter = new NoQuarter(this);
            HasQuarter = new HasQuarter(this);
            OutOfGumballs = new OutOfGumballs(this);
            GumballSold = new GumballSold(this);
            Winner = new Winner(this);

            _state = this.NoQuarter;
            _noOfGumballs = noOfGumballs;

        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.DispenseGumball();
        }

        public IState GetHasQuarter()
        {
            return HasQuarter;
        }

        public IState GetOutOfGumballs()
        {
            return OutOfGumballs;
        }

        public IState GetGumballSold()
        {
            return GumballSold;
        }

        public IState GetNoQuarter()
        {
            return NoQuarter;
        }

        public int Gumballs()
        {
            return _noOfGumballs;
        }

        public IState GetWinner()
        {
            return Winner;
        }

        public void ResetBall()
        {
            _noOfGumballs--;
        }

        public override string ToString()
        {
            return "Total gumballs left in the machine : " + _noOfGumballs;
        }

        public void Refill(int balls)
        {
            System.Console.WriteLine($"Refilling with {balls} balls");

            _noOfGumballs += balls;
            _state = NoQuarter;
        }
    }
}
