using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpwaner : MonoBehaviour
{
   
    private float timer = 0f;

    // Start is called before the first frame update

    public GameObject BulletPrefab;
    public Transform Player;

    private float randomFire = 0.0f;
    // Update is called once per frame

    private void Start()
    {
        randomFire = Random.Range(0.5f, 3f);
    }

    void Update()
        {



            timer += Time.deltaTime;

            if (timer > randomFire)
            {
                timer = 0;
            
            randomFire = Random.Range(0.5f, 2f);

            GameObject bullet = Instantiate(BulletPrefab, transform) ;
            bullet.transform.LookAt(Player);
            }
    
        }
        
    


}
