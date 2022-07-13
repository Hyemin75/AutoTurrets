using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public void Die()
    {
        gameObject.SetActive(false);
        Gamemanager gamemanager = FindObjectOfType<Gamemanager>();

        FindObjectOfType<Gamemanager>().End();
    }


    
}
