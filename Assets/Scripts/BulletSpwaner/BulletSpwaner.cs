using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpwaner : MonoBehaviour
{
   
    public float rotSpeed = 100.0f;
    private float randomFire;
    private float timeOfSpawnBullet;
    public GameObject BulletPrefab;
    public Transform Player;
    public Targetting targetting;

    private void Start()
    {
        targetting = GetComponent<Targetting>();
        randomFire = Random.Range(0.5f, 2f);
    }



    void Update()
    {
        timeOfSpawnBullet += Time.deltaTime;

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

        if (timeOfSpawnBullet > randomFire)
        {
            GameObject bullet = Instantiate(BulletPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            bullet.transform.LookAt(Player);
            timeOfSpawnBullet = 0;
        }
    }

    void OffFire()
    {
        //계속 회전해야 함
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }

}
