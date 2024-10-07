using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    [SerializeField] private Toggle toggle;
    [SerializeField] private Light light;
    // Start is called before the first frame update
    void Start()
    {
        toggle.onValueChanged.AddListener(Toggle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle(bool value) {
        light.enabled = value;
    }
}
