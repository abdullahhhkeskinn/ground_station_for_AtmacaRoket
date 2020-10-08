using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HizIndicator : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {

    }
  
    // Update is called once per frame
    void Update()
    {
        text.text = allValues.hiz[allValues.hiz.Count-1].ToString() + " m/s" ;
    }
}
