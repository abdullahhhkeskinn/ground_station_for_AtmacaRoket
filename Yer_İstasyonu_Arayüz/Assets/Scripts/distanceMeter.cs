using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distanceMeter : MonoBehaviour
  
{
    public Text text;
    miniMapSettings myMap;
    moveMiniTracker trc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = HaversineInM(36.894284, 30.6723833, 36.892686, 30.666902).ToString();
    }

    double _eQuatorialEarthRadius = 6378.1370D;
    double _d2r = (Mathf.PI / 180D);


    public int HaversineInM(double lat1, double long1, double lat2, double long2)
    {
        return (int)(1000D * HaversineInKM(lat1, long1, lat2, long2));
    }

    public double HaversineInKM(double lat1, double long1, double lat2, double long2)
    {
        double dlong = (long2 - long1) * _d2r;
        double dlat = (lat2 - lat1) * _d2r;
        double a = System.Math.Pow(System.Math.Sin(dlat / 2D), 2D) + System.Math.Cos(lat1 * _d2r) * System.Math.Cos(lat2 * _d2r) * System.Math.Pow(System.Math.Sin(dlong / 2D), 2D);
        double c = 2D * System.Math.Atan2(System.Math.Sqrt(a), System.Math.Sqrt(1D - a));
        double d = _eQuatorialEarthRadius * c;

        return d;
    }

}
