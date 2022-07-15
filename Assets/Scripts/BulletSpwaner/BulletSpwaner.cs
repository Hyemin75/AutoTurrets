using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpwaner : MonoBehaviour
{
   
    private float randomFire;
    private float timeOfSpawnBullet;

    public float rotSpeed = 100.0f;
    
    public Transform Player;
    public GameObject BulletPrefab;
    public Sensor sensor;

    private void Start()
    {
        randomFire = Random.Range(0.5f, 2f);
        sensor = GetComponent<Sensor>();
    }

    void Update()
    {
        timeOfSpawnBullet += Time.deltaTime;

        if (sensor.GetCheckPlayer() == false)
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
            GameObject bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
            bullet.transform.LookAt(Player);
            timeOfSpawnBullet = 0;
        }
    }

    void OffFire()
    {
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }

}
