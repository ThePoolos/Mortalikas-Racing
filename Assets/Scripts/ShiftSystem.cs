using UnityEngine;

public class ShiftSystem : MonoBehaviour
{
    public enum ShiftQuality { Early, Perfect, Late, Blown }

    public ShiftQuality EvaluateShift(float currentRPM, float minPerfect, float maxPerfect)
    {
        if (currentRPM >= minPerfect && currentRPM <= maxPerfect) return ShiftQuality.Perfect;
        if (currentRPM < minPerfect) return ShiftQuality.Early;
        return ShiftQuality.Late;
    }
}
