namespace DelegatesAndEvents
{
    public class FloorReachedEventArgs
    {
        public int CurrentFloor { get; }

        public FloorReachedEventArgs(int currentFloor)
        {
            CurrentFloor = currentFloor;
        }
    }

    public class BetterElevator
    {
        public EventHandler<FloorReachedEventArgs> FloorReachedEvent;

        public int CurrentFloor { get; private set; }

        public int MinFloor => 0;
        public int MaxFloor => 5;
        public int MilisecondsBetweenFloors => 1000;

        public void Move(int floor)
        {
            if (floor < MinFloor || floor > MaxFloor)
                throw new ArgumentException("Invalid floor");

            Task.Run(async () =>
            {
                while (CurrentFloor != floor)
                {
                    await Task.Delay(MilisecondsBetweenFloors);

                    CurrentFloor += CurrentFloor < floor ? 1 : -1;

                    //This is how you should do it nowadays
                    FloorReachedEvent?.Invoke(this, new FloorReachedEventArgs(CurrentFloor)); 
                }
            });
        }
    }
}