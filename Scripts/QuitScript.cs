using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// I attached this to an empty gameObject.
public class QuitScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
