using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetting : MonoBehaviour
{
    public GameObject Player;

    private bool checkTrigger = false;


    void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Player")
        {
            checkTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            checkTrigger = false;
        }
    }


    public bool GetCheckTrigger()
    {
        return checkTrigger;
    }

}
