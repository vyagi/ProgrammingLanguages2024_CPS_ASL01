namespace DelegatesAndEvents
{
    public delegate void NotifyAction();
    
    public class Elevator
    {
        public event NotifyAction NotifyAction;

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
                    //NotifyAction(); //don't do it like this
                    NotifyAction?.Invoke(); //if it is null (no one subscribed, nothing happens, it will only call if someone subscribed)
                }
            });
        }
    }
}