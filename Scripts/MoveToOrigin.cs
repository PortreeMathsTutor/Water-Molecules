using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// I put this script on the prefab
public class MoveToOrigin : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;
    float timer;
    float temp;
    Rigidbody rb;
    Vector3 direction;
    Transform currentTransform;
   
    float forceAmount;
    void Start()
    {
        timer = 0.0f;
        rb = GetComponent<Rigidbody>();
        temp = scoreManager.temp * 100;
        direction = (Vector3.zero - transform.position).normalized;
        forceAmount = 10f / (temp);
        rb.AddForce(direction * forceAmount);
        direction = (Vector3.zero - transform.position).normalized;
        rb.AddForce(direction * 3f, ForceMode.Force);
    }
    
    void FixedUpdate()
    {
        timer += 1;
   
        if (timer%3== 0)
        {
            temp = scoreManager.temp * 100;
            forceAmount = 10f / (temp);
            direction = (Vector3.zero - transform.position).normalized;
            rb.AddForce(direction * forceAmount, ForceMode.Force);       
        }
    }
}