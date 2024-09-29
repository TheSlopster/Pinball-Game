using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour
{
    public PointCollection pointCollection;
    public int yellowPoints = 250;

    public void YellowPoints()
    {
        pointCollection.points = yellowPoints + pointCollection.points;
    }
}
