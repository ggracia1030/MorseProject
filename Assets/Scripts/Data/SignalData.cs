using System;

public class SignalData
{
    public enum SignalType { Point, Line };

    TimeSpan startSignalTime;
    TimeSpan endSignalTime;

    public SignalData()
    {
        startSignalTime = DateTime.Now.TimeOfDay;
        endSignalTime = DateTime.Now.TimeOfDay;
    }

    public SignalData(TimeSpan now)
    {
        startSignalTime = now;
        endSignalTime = now;
    }

    public TimeSpan StartSignalTime
    {
        get { return startSignalTime; }
    }

    public TimeSpan EndSignalTime
    {
        get { return endSignalTime; }
    }

    public void EndSignal()
    {
        endSignalTime = DateTime.Now.TimeOfDay;
    }

    public double SignalDurationTime
    {
        get { return endSignalTime.TotalSeconds - startSignalTime.TotalSeconds; }
    }

    public double SignalDurationTimeMili
    {
        get { return endSignalTime.TotalMilliseconds - startSignalTime.TotalMilliseconds; }
    }
}
