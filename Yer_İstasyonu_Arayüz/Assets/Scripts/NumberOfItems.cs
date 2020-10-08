using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberOfItems : MonoBehaviour
{
    Text numberOfItems;

    // Start is called before the first frame update
    void Start()
    {  
       numberOfItems = GameObject.Find("numberOfItems").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        
        numberOfItems.text =Window_Graph.duration.ToString();
    }
}
