using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunComponent : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float chargeSpeed = 10f;
    private float chargeTime = 0f;
void Start(){

}
    void Update()
    {
                    GameObject bullet = bulletPrefab;

                  BulletComponent bulletComp = bullet.GetComponent<BulletComponent>();

        if (Input.GetButtonUp("Fire1"))
        {
    

            // Spawn bullet when Fire1 is released
           Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
 float speed = Mathf.Clamp(chargeTime, 0f, 100f);
        bulletComp.bulletSpeed = speed;
        }
        if (Input.GetButtonDown("Fire1")){
            chargeTime = 0f;
        }
        if(Input.GetButton("Fire1")){
            chargeTime += Time.deltaTime * 20;
             
        }
    }
}

