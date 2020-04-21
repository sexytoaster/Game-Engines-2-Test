using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrafficLights : MonoBehaviour
{
    public float lightCount;
    public float radius;
    public GameObject trafficLight;
    public GameObject Car;
    private Vector3 centrePos = new Vector3 (0, 0, 0);

    // Start is called before the first frame update
    void Awake()
    {
        InstantiateLights();
    }
    
    void InstantiateLights()
    {
        float angle = 360f / lightCount;
        for(int i = 0; i < lightCount; i++)
        {
            Quaternion rotation = Quaternion.AngleAxis(i * angle, Vector3.up);
            Vector3 direction = rotation * Vector3.forward;

            Vector3 position = centrePos + (direction * radius);
            Instantiate(trafficLight, position, rotation);
        }
        Instantiate(Car, centrePos, Quaternion.identity);
    }
}
