using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YedekKordinat : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Yedek Enlem: " + allValues.yedek_koordinat_x[allValues.yedek_koordinat_x.Count-1] + "         " + "Yedek Boylam: " + allValues.yedek_koordinat_y[allValues.yedek_koordinat_y.Count - 1];
    }
}
