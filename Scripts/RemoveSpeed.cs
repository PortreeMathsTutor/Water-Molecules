using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveSpeed : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;
    float temp;
    float speedThreshold;
    public float slowDownRate = 0.1f; // Rate at which the object slows down

    private Rigidbody rb;

    void Start()
    {
        speedThreshold = 1f;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        temp = scoreManager.temp * 50;
        speedThreshold = temp;
        if (rb.velocity.magnitude < speedThreshold)
        {
          
            // Gradually reduce the velocity
            rb.velocity = rb.velocity * (1 - slowDownRate * Time.deltaTime);
        }
    }
}