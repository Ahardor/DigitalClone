using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] Slider slider;
    private String text;
    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener(Slide);
        text = slider.value.ToString();
    }

    void OnGUI() {
        GUI.Label(new Rect(10, 10, 100, 20), text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Slide(float value) {
        text = value.ToString();
    }
}
