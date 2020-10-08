using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveyedek : MonoBehaviour
{
    RectTransform rectTransform;
    miniMapSettings myMap;
    getValues gtValues;

    public double destinationLat;
    public double destinationLon;

    private void Start()
    {
        myMap = gameObject.AddComponent(typeof(miniMapSettings)) as miniMapSettings;
    }

    void Update()
    {
        destinationLat = allValues.koordinat_x[allValues.yedek_koordinat_x.Count - 1];
        destinationLon = allValues.koordinat_y[allValues.yedek_koordinat_y.Count - 1];
        moveToCoordinates();

    }

    private void moveToCoordinates()
    {
        int realMapWidth = myMap.realMapWidth();
        int realMapHeigth = myMap.realMapHeigth();

        double targetXDistance = myMap.HaversineInM(myMap.Mapbottom, myMap.Mapleft, myMap.Mapbottom, destinationLon);
        double targetYDistance = myMap.HaversineInM(myMap.Mapbottom, myMap.Mapleft, destinationLat, myMap.Mapleft);

        double xScale = targetXDistance / (realMapWidth);
        double yScale = targetYDistance / (realMapHeigth);

        double xVector = (myMap.actualMapWidth * xScale);
        double yVector = (myMap.actualMapHeight * yScale);

        rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2((float)xVector, (float)yVector);

    }
}
