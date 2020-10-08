using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == 670)
        {
            i = 570;
        }   
        transform.position = new Vector3(i, 300, 1000);
        transform.rotation = new Quaternion();
        i++;
    }
}
