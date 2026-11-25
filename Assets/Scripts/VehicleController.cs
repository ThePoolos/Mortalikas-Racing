using UnityEngine;

public class VehicleController : MonoBehaviour
{
    [SerializeField] private float currentRPM;
    [SerializeField] private int currentGear = 1;

    public void ShiftUp()
    {
        if (currentGear < 5) currentGear++;
    }
}
