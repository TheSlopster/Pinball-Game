using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    public PointCollection pointCollection;
    public int orangePoints = 100;

    public void OrangePoints()
    {
        pointCollection.points = orangePoints + pointCollection.points;
    }
}
