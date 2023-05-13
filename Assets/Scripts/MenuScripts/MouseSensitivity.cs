using System;
using UnityEngine;
using UnityEngine.UI;


public class MouseSensitivity : MonoBehaviour
{
    public bool initialized;
    public Slider mouseSensitivitySlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Sensitivity"))
        {
            this.mouseSensitivitySlider.value = PlayerPrefs.GetFloat("Sensitivity");
            Debug.Log("Loaded a sensitivity of " + this.mouseSensitivitySlider.value);
        }
        this.initialized = true;
    }

    public void SetMouseSensitivity(float val)
    {
        if (!this.initialized)
        {
            return;
        }
        if (!Application.isPlaying)
        {
            return;
        }
        PlayerPrefs.SetFloat("Sensitivity", val);
        Debug.Log("Set sensitivity to " + val);
    }

}