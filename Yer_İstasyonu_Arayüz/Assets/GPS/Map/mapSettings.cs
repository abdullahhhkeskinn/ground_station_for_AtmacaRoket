using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;



public class mapSettings : MonoBehaviour
{

    public static string[] readArr = new string[2];

    public int actualMapHeight = 657;
    public int actualMapWidth = 1490;

    public double Maptop = 36.9010557590342;
    public double Mapbottom = 36.8897983789393;
    public double Mapleft = 30.6334687056444;
    public double Mapright = 30.6654198644241;

    public int realMapHeigth()
    {
        return HaversineInM(Mapbottom,Mapleft,Maptop,Mapleft);
    }

    public int realMapWidth()
    {
        return HaversineInM(Mapbottom, Mapleft, Mapbottom, Mapright);
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
