using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float LR = Input.GetAxis("Horizontal") / 10;
        float FB = Input.GetAxis("Vertical") / 10;
        bool Sprint = Input.GetKey("left shift");
        transform.Translate(LR * (1 + (Sprint ? 1 : 0)), 0, FB * (1 + (Sprint ? 1 : 0)));
    }
}
