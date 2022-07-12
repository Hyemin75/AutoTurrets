using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpwaner : MonoBehaviour
{
   
    public float rotSpeed = 100.0f;
    
    public GameObject BulletPrefab;
    public Transform Player;
    public Targetting targetting;

    private void Start()
    {
        targetting = GetComponent<Targetting>();
    }

    void Update()
    {

        if (targetting.GetCheckTrigger())
        {
            OnFire();
        }
        else
        {
            OffFire();
        }

    }
     

    void OnFire()
    {
        transform.LookAt(Player);
    }

    void OffFire()
    {
        //��� ȸ���ؾ� ��
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }

}
