using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressureGraphEnable : MonoBehaviour
{
    public Button Button;
    private mainElements mE;
    void Start()
    {
        Button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        mainElements.currentGraphId = 2 ;
    }
}
