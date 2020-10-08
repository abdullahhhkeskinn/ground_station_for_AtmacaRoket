using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Globalization;
using System;
using System.Threading;

public class getValues : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 9600);
    

    // Start is called before the first frame update

    void Start()
    {
        if (!sp.IsOpen)
        {
            sp.Open();
        }
    }


    void Update()
    {

        string a = sp.ReadLine();
        string[] b = a.Split('*');
  
        Debug.Log(a);
        CultureInfo info = new CultureInfo("fa-IR");
        info.NumberFormat.NumberDecimalSeparator = ".";
        Thread.CurrentThread.CurrentCulture = info;
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

        if (a.Contains("AY"))
        {
            a = a.Replace("AY", "");
            b = a.Split(',');
            Debug.Log(b[0]);
            Debug.Log(b[1]);
            allValues.yedek_koordinat_x.Add(double.Parse(b[0]));
            allValues.yedek_koordinat_y.Add(double.Parse(b[1]));
        }

        if (a.Contains("AA"))
        {
            a = a.Replace("AA", "");
            b = a.Split('*');
            allValues.koordinat_x.Add(double.Parse(b[0]));
            allValues.koordinat_y.Add(double.Parse(b[1]));
            allValues.ivme.Add(float.Parse(b[2]));
            allValues.gyro_x.Add(float.Parse(b[3]));
            allValues.gyro_y.Add(float.Parse(b[4]));
            allValues.gyro_z.Add(float.Parse(b[5]));
            allValues.yukseklik.Add(float.Parse(b[6]));
            allValues.hiz.Add(float.Parse(b[7]));
            allValues.basinc.Add(float.Parse(b[8]));
        }
    }
}