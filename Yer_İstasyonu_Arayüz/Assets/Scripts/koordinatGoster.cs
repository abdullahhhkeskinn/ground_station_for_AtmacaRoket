using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class koordinatGoster : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Enlem: " + allValues.koordinat_x[allValues.koordinat_x.Count - 1] + "                   " + "Boylam: " + allValues.koordinat_x[allValues.koordinat_x.Count - 1];
    }
}
