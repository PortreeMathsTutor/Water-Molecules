using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{[SerializeField]
    private JiggleEffect prefab;
    [SerializeField]
    private ScoreManager scoreManager;
    int latitudeSegments;
    int longitudeSegments;
    float radius;
   

    void Start()
    {     int latitudeSegments = 10; // Number of latitude segments
     int longitudeSegments = 10; // Number of longitude segments
    float radius = 10f; // Radius of the sphere
        for (int lat = 0; lat <= latitudeSegments; lat++)
        {
            float theta = lat * Mathf.PI / latitudeSegments; // Latitude angle
            float sinTheta = Mathf.Sin(theta);
            float cosTheta = Mathf.Cos(theta);

            for (int lon = 0; lon <= longitudeSegments; lon++)
            {
                float phi = lon * 2 * Mathf.PI / longitudeSegments; // Longitude angle
                float sinPhi = Mathf.Sin(phi);
                float cosPhi = Mathf.Cos(phi);

                // Convert spherical coordinates to Cartesian coordinates
                float x = radius * sinTheta * cosPhi;
                float y = radius * cosTheta;
                float z = radius * sinTheta * sinPhi;

                Vector3 spawnPosition = new Vector3(x, y, z);
                transform.position = spawnPosition;
                // Update is called once per frame

                Spawn();
            }
        }

    }
    private void Spawn()
    {
        var molecule  = Instantiate(prefab, transform.position, Quaternion.identity);
        molecule.Initialize(scoreManager);

    }
}
