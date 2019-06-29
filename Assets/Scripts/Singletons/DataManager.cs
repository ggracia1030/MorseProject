using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : Singleton<DataManager>
{
    public enum SignalSpace { Letter, Word};

    List<SignalData> signalList;

    public void Init_DataManager()
    {
        signalList = new List<SignalData>();
    }

    public double TimeBetweenTwoSignals(SignalData data1, SignalData data2)
    {
        return data2.StartSignalTime.TotalSeconds - data1.EndSignalTime.TotalSeconds;
    }

    public SignalData GetSignal(int index)
    {
        if(index < 0 || index >= signalList.Count)
        {
            Debug.LogError("Index of Signal List Getter out of range.");
            return null;
        }
        else
        {
            return signalList[index];
        }
    }

    public void AddSignal()
    {
        signalList.Add(new SignalData());
    }

    public void EndSignal()
    {
        signalList[signalList.Count - 1].EndSignal();
    }
}
