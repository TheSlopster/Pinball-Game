using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCollection : MonoBehaviour
{
    public Red red;
    public Orange orange;
    public Yellow yellow;
    public Green green;
    public Blue blue;
    public int points = 0;
    public TMP_Text scoreText;

    private void Update()
    {
        scoreText.text = points.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Red")
        {
            red.RedPoints();
        }

        if (other.transform.tag == "Orange")
        {
            orange.OrangePoints();
        }

        if (other.transform.tag == "Yellow")
        {
            yellow.YellowPoints();
        }

        if (other.transform.tag == "Green")
        {
            green.GreenPoints();
        }

        if (other.transform.tag == "Blue")
        {
            blue.BluePoints();
        }

    }
}
