using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System;

public class moveSphere : MonoBehaviour
{
    RectTransform rectTransform;
    mapSettings myMap; 

    double destinationLat;
    double destinationLon;
    
    private void Start()
    {
        myMap = gameObject.AddComponent(typeof(mapSettings)) as mapSettings;
    }

    void Update()
    {
        destinationLat = allValues.koordinat_x[allValues.koordinat_x.Count-1];
        destinationLon = allValues.koordinat_y[allValues.koordinat_y.Count-1];
        moveToCoordinates();
       
    }
    
    private void moveToCoordinates()
    {
        int realMapWidth = myMap.realMapWidth();
        int realMapHeigth = myMap.realMapHeigth();

        double targetXDistance= myMap.HaversineInM(myMap.Mapbottom,myMap.Mapleft, myMap.Mapbottom,destinationLon);
        double targetYDistance = myMap.HaversineInM(myMap.Mapbottom, myMap.Mapleft, destinationLat, myMap.Mapleft);

        double xScale = targetXDistance / (realMapWidth);
        double yScale = targetYDistance / (realMapHeigth);

        double xVector = (myMap.actualMapWidth * xScale) ;
        double yVector = (myMap.actualMapHeight * yScale);

        rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2((float)xVector, (float)yVector);
    }
}
