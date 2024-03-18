using System.Collections;

namespace Geometry
{
    public class PolygonalChain : Segment, IMoveable, IEnumerable<Point>
    {
        private List<Point> _midpoints = new List<Point>();

        public PolygonalChain(Point start, Point end) : base(start, end) { }

        public List<Point> Midpoints => _midpoints.Select(x=>x).ToList();

        public void AddMidpoint(Point midpoint)
        {
            var allPoints = _getAllPoints();

            if (allPoints.Any(x => x.X == midpoint.X && x.Y == midpoint.Y))
                throw new ArgumentException("The midpoint already exists");

            _midpoints.Add(midpoint);
        }

        public void Move(double x, double y)
        {
            _start.Move(x, y);
            _end.Move(x, y);

            foreach (var midpoint in _midpoints)
                midpoint.Move(x, y);
        }

        public override double Length
        {
            get
            {
                var allPoints = _getAllPoints();

                var totalLength = 0.0;
                for (int i = 0; i < allPoints.Count - 1; i++)
                {
                    var start = allPoints[i];
                    var end = allPoints[i + 1];
                    totalLength += new Segment(start, end).Length;
                }

                return totalLength;
            }
        }

        private List<Point> _getAllPoints()
        {
            var allPoints = new List<Point>();

            allPoints.Add(_start);
            allPoints.AddRange(_midpoints);
            allPoints.Add(_end);

            return allPoints;
        }

        public IEnumerator<Point> GetEnumerator()
        {
            Console.WriteLine("Get Enumerator is called for the first time");
            yield return _start;
            
            Console.WriteLine("_start was already returned, now midpoints");
            
            foreach (var midpoint in _midpoints)
                yield return midpoint;

            Console.WriteLine("midpoints were already returned, now _end");

            yield return _end;

            Console.WriteLine("_end was already returned, nothing more to return");
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}