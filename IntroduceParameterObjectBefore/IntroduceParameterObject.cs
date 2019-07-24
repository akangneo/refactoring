using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class IntroduceParameterObjectExamples
    {
        public void DrawEdge(Graphics graphics, double width, double x1, double y1, double x2, double y2)
        {
            graphics.SetStokeWidth(width);
            graphics.DrawLine(x1, y1, x2, y2);
        }

        public void DrawEdgeCall(Graphics graphics)
        {
            DrawEdge(graphics, 2.0, 0.0, 0.0, 100.0, 0.0);
        }
    }

    public class LogFile
    {
        List<LogEvent> logEvents = new List<LogEvent>();

        public IEnumerable<LogEvent> GetEvents(DateTime start, DateTime end)
        {
            var result = new List<LogEvent>();
            foreach (var logEvent in logEvents)
            {
                if (logEvent.Time == start ||
                    logEvent.Time == end ||
                    (logEvent.Time > start && logEvent.Time < end))
                {
                    result.Add(logEvent);
                }
            }
            return result;
        }

        public void RemoveEvents(DateTime start, DateTime end)
        {
            var result = new List<LogEvent>();
            var count = logEvents.Count;
            for (var i = count - 1; i >= 0; i--)
            {
                var logEvent = logEvents[i];
                if (logEvent.Time == start ||
                    logEvent.Time == end ||
                    (logEvent.Time > start && logEvent.Time < end))
                {
                    result.RemoveAt(i);
                }
            }
        }
    }

}
