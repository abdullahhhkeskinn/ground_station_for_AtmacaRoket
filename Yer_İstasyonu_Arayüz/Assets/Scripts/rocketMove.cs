using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketMove : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            Vector3 position = this.transform.position;
            position.y = ((allValues.yukseklik[allValues.yukseklik.Count - 1]+3)/25)+2;
            this.transform.position = position;
        
    }
}
