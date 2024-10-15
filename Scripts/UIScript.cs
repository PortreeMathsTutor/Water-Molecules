using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
// I put this script on the canvas with the slider and assigned the canvas in the
 // onValueChange box.
public class UIScript : MonoBehaviour
{
    public Slider slider; // Reference to the slider
float controlledVariable; // The variable to be controlled by the slider
    [SerializeField]
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        controlledVariable = 0.01f;
        slider.value = controlledVariable;
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }
    void OnSliderValueChanged(float value)
    {
        // Update the controlled variable with the slider value
        controlledVariable = value;
        AddTemp();
   
    }
   public void AddTemp()
    {
        scoreManager.AddTemp(controlledVariable);
    }
   
}
