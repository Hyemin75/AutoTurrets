using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public Transform player;

    private float distance = 28f;
    private bool checkPlayer = false;
    private float dotValue;

    private Vector3 direction;
   
    // Update is called once per frame
    void Update()
    {

        dotValue = Mathf.Cos(Mathf.Deg2Rad * 60f);
        
        direction = player.position - transform.position;
        
        if(direction.magnitude < distance)
        {
            if (Vector3.Dot(direction.normalized, transform.right * -1) <= dotValue)
            {

                checkPlayer = true;
            }
            else
            {
                checkPlayer = false;
            }
        }
    
    }

    public bool GetCheckPlayer()
    {
        return checkPlayer;
    }
}
