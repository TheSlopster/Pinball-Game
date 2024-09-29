using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{
    public PointCollection pointCollection;
    public int greenPoints = 500;

    public void GreenPoints()
    {
        pointCollection.points = greenPoints + pointCollection.points;
    }
}
