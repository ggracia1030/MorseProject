using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputManager : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI outputText;

    public void SetOutputText(string text)
    {
        outputText.text = text;
    }
}
