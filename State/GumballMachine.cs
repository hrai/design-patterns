namespace State
{
    public class GumballMachine : IMachine
    {
        private IState NoQuarter;
        private IState HasQuarter;
        private IState OutOfGumballs;
        private IState GumballSold;

        private IState _state;
        private readonly int _noOfGumballs;

        public GumballMachine(int noOfGumballs)
        {
            NoQuarter = new NoQuarter(this);
            HasQuarter = new HasQuarter(this);
            OutOfGumballs = new OutOfGumballs(this);
            GumballSold = new GumballSold(this);
            
            _state = this.NoQuarter;
            _noOfGumballs = noOfGumballs;

        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void DispenseGumball()
        {
            _state.DispenseGumball();
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
    }
}
