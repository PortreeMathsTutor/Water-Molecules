using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JiggleEffect : MonoBehaviour
{
    //I put this script on the prefab. 
    //The Spawner script uses the fact that it has this script on it to find it.
    // When a molecule spawns it immediatly runs the public void Initialize(ScoreManager scoreManager)
   
    [SerializeField]
    private ScoreManager scoreManager;
    float jiggleIntensity; // Intensity of the jiggle
    float temp;
    private Rigidbody rb;

    void Start()
    {
        jiggleIntensity =  transform.position.x;
    
        rb = GetComponent<Rigidbody>();
    }
    public void Initialize(ScoreManager scoreManager)
    {
        this.scoreManager = scoreManager;
    }
    void FixedUpdate()
    {
        temp = scoreManager.temp*100;
        // Apply random forces to create a jiggling effect
        Vector3 randomForce = new Vector3(
          Random.Range(-jiggleIntensity, jiggleIntensity), Random.Range(-jiggleIntensity, jiggleIntensity), Random.Range(-jiggleIntensity, jiggleIntensity)
        ) * temp;

        rb.AddForce(randomForce, ForceMode.Force);
    }
}