using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableCanvas : MonoBehaviour
{
    public Button Button;
    public static bool State = false;
    public GameObject target ;


    void Start()
    {
        Button.onClick.AddListener(TaskOnClick);
        target.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
       State = !State;
       target.SetActive(State);
       Window_Graph.state = State;
       Debug.Log("You have clicked the button!");
    }
}
