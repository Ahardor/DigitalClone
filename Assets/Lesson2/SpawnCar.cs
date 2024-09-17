using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{

    public GameObject car;
    public Vector3 location;
    public Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(car, location, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
