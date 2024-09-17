using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter() {
        this.GetComponent<Renderer>().material.color = Color.red;
    }

    void OnMouseExit() {
        this.GetComponent<Renderer>().material.color = Color.white;
    }
}
