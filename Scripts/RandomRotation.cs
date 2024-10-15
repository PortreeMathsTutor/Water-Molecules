using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// I put this script on the prefab
public class RandomRotation : MonoBehaviour
{
    float time;
    float rotationSpeed; // Speed of rotation
    float rotationRange; // Range of random rotation
    float randomX;
    float randomY;
    float randomZ;
    private void Start()
    {
        rotationRange = 4f;
        rotationSpeed = 10f;
        time = transform.position.x;
    }
    void Update()
    {
        time += 1;
        if (time % 100 == 0) 
        {
            // Generate small random rotations
             randomX = Random.Range(-rotationRange, rotationRange);
             randomY = Random.Range(-rotationRange, rotationRange);
             randomZ = Random.Range(-rotationRange, rotationRange);
            // Apply the random rotations
          
        }

        transform.Rotate(new Vector3(randomX, randomY, randomZ) * rotationSpeed * Time.deltaTime);

    }
}