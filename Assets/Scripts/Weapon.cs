using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bullet;
    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();   
        }
    }

    private void Shoot()
    {
        Instantiate(bullet,firePoint.position,firePoint.rotation);
    }
}
