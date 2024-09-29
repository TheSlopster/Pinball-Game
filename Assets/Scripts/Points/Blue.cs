using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{
    public PointCollection pointCollection;
    public int bluePoints = 1500;

    public void BluePoints()
    {
        pointCollection.points = bluePoints + pointCollection.points;
    }
}
