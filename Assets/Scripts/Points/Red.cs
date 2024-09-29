using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public PointCollection pointCollection;
    public int redPoints = 50;

    public void RedPoints()
    {
        pointCollection.points = redPoints + pointCollection.points;
    }
}
