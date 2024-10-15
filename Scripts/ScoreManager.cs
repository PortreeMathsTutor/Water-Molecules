using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// if you make this script then you can create a SriptableObject called ScoreManager
[CreateAssetMenu(menuName ="ScoreManager")]
public class ScoreManager : ScriptableObject
{public float temp;
  
    private void OnEnable()
    {
      temp = 0.01f;
    }

    public void AddTemp(float amount)
    {
        temp = amount;
    }
}
