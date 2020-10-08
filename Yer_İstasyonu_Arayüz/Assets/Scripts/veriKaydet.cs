using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class veriKaydet : MonoBehaviour
{
    public Button Button;
    void Start()
    {
        Button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        string path = @"c:\temp\FlightReport.txt";
        StreamWriter sw = File.CreateText(path);

        for (int i = 0; i<allValues.basinc.Count ;i++)
        {
            sw.Write(allValues.koordinat_x[i]);
            sw.Write(" ");
            sw.Write(allValues.koordinat_y[i]);
            sw.Write(" ");
            sw.Write(allValues.ivme[i]);
            sw.Write(" ");
            sw.Write(allValues.gyro_x[i]);
            sw.Write(" ");
            sw.Write(allValues.gyro_y[i]);
            sw.Write(" ");
            sw.Write(allValues.gyro_z[i]);
            sw.Write(" ");
            sw.Write(allValues.yukseklik[i]);
            sw.Write(" ");
            sw.Write(allValues.hiz[i]);
            sw.Write(" ");
            sw.WriteLine(allValues.basinc[i]);
            
        }
    }
}