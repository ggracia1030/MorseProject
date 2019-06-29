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

    public void OnButtonDown()
    {
        SoundManager.Instance.PlayMorseSound();
        DataManager.Instance.AddSignal();
    }

    public void OnButtonUp()
    {
        SoundManager.Instance.StopMorseSound();
        DataManager.Instance.EndSignal();
    }
}
