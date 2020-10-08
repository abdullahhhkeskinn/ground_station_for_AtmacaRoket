using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class graphName : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (mainElements.currentGraphId)
        {
            case 1:
                text.text = " Yükseklik Grafiği";
                break;
            case 2:
                text.text = " Basınç Grafiği";
                break;
            case 3:
                text.text = " İvme Grafiği";
                break;
            case 4:
                text.text = " Hız Grafiği";
                break;
        }
    }
}
