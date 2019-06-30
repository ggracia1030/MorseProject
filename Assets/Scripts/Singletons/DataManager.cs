using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : Singleton<DataManager>
{
    public enum SignalSpace { Letter, Word};
    List<SignalData> signalList;

    OutputManager outputManager;

    string currentOutputText;

    public void Init_DataManager()
    {
        signalList = new List<SignalData>();
        outputManager = GameObject.Find("Manager").GetComponent<OutputManager>();
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
        outputManager.SetOutputText(DataParser.SignalDataArrayToMorse(signalList.ToArray()));
    }

    public void ResetData()
    {
        signalList.Clear();
        outputManager.SetOutputText(DataParser.SignalDataArrayToMorse(signalList.ToArray()));
    }

   
}
