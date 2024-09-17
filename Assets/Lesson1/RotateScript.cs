using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Rotate36());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Rotate36() {
        while(true) {
            this.transform.Rotate(Vector3.up, 36f);

            yield return new WaitForSeconds(1f);
        }
    }
}
