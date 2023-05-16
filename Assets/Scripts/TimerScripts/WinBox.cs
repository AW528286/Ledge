using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour
{
    public TimerMaybe Timerl;
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("hiiiiiiiiiiiiiiiiiiii");
        Timerl.Finish();
    }
}
