using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egimTop : MonoBehaviour
{
    float tiltAroundZ ;
    float tiltAroundX ;
    float tiltAroundY;
    // Start is called before the first frame update
    void Start()
    {
        tiltAroundZ = 1;
        tiltAroundX = 1;
        tiltAroundY = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        tiltAroundZ = allValues.gyro_z[allValues.gyro_z.Count-1];
        tiltAroundX = allValues.gyro_x[allValues.gyro_x.Count - 1];
        tiltAroundY = allValues.gyro_y[allValues.gyro_y.Count - 1];
         

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundY, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
    }
}
