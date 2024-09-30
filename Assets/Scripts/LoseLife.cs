using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseLife : MonoBehaviour
{
    public Lives life;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            life.LoseLife(1);
        }
    }
}
