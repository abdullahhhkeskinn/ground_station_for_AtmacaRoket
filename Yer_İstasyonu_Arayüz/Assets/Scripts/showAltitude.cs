using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showAltitude : MonoBehaviour
{
    float a = -455; 
    public GameObject thisObject;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float shownAltitude = (allValues.yukseklik[allValues.yukseklik.Count - 1] * 780) / 7000;
        transform.localPosition = new Vector3(3,shownAltitude-394,0);
    }
}
