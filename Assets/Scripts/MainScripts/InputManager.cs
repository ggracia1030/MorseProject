using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private void Awake()
    {
        SoundManager.Instance.Init_SoundManager();
        DataManager.Instance.Init_DataManager();
    }

    public void OnMorseButtonDown()
    {
        SoundManager.Instance.PlayMorseSound();
        DataManager.Instance.AddSignal();
    }

    public void OnMorseButtonUp()
    {
        SoundManager.Instance.StopMorseSound();
        DataManager.Instance.EndSignal();
    }

    public void OnResetButtonDown()
    {
        DataManager.Instance.ResetData();
        Debug.Log("Reset Data");
    }
}
