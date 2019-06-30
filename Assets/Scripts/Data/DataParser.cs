using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataParser
{
    public const double POINT_TIME_VALUE = 1 / 10F;
    public const double LINE_TIME_VALUE = 3 * POINT_TIME_VALUE;
    public const double TIME_BETWEEN_LETTERS = LINE_TIME_VALUE;
    public const double TIME_BETWEEN_WORDS = 3 * LINE_TIME_VALUE;

    public static string SignalDataToMorse(SignalData data)
    {
        string ret = "";

        if(data.SignalDurationTime >= LINE_TIME_VALUE - POINT_TIME_VALUE)
        {
            ret = "-";
        }
        else { ret = "·"; }

        return ret;
    }

    public static string SignalDataArrayToMorse(SignalData[] data)
    {
        string ret = "";
        if (data == null || data.Length == 0) return "";

        ret += SignalDataToMorse(data[0]);
        for (int i = 1; i < data.Length; i++)
        {
            if(TimeBetweenTwoSignals(data[i-1], data[i]) >= TIME_BETWEEN_LETTERS &&
                TimeBetweenTwoSignals(data[i - 1], data[i]) < TIME_BETWEEN_WORDS) {
                ret += "    ";
            }
            else if(TimeBetweenTwoSignals(data[i - 1], data[i]) >= TIME_BETWEEN_WORDS)
            {
                ret += "\n";
            }

            ret += SignalDataToMorse(data[i]);
        }

        return ret;
    }

    public static double TimeBetweenTwoSignals(SignalData data1, SignalData data2)
    {
        return data2.StartSignalTime.TotalSeconds - data1.EndSignalTime.TotalSeconds;
    }

    public static string SignalDataToText(SignalData data)
    {
        string ret = "";
        return ret;
    }

    public static string MorseToText(string data)
    {
        string ret = "";
        return ret;
    }

    public static string TextToMorse(string data)
    {
        string ret = "";
        return ret;
    }
}
