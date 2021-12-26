using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 20f;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject hitEffect;
    [SerializeField] float timeBetweenShots = 0.5f;
    [SerializeField] int currentWeapon;


    bool canShot = true;
    void Update()
    {
        weaponSwitcher weapon_Switcher = GetComponent<weaponSwitcher>();
        currentWeapon = weapon_Switcher.getCurrentWeapon();

        switch(currentWeapon)
        {
            case 0:
                timeBetweenShots = 1f;
                damage = 20f;
                break;
            case 1:
                timeBetweenShots = 0.5f;
                damage = 10f;
                break;
            case 2:
                timeBetweenShots = 2f;
                damage = 30f;
                break;
        }

        if(Input.GetButtonDown("Fire1") && canShot)
        {
            Shoot();
        }
    }
    IEnumerator Shoot()
    {
        canShot = false;
        if(GetComponent<Ammo>().GetCurrentAmmo() > 0)
        {
            PlayMuzzleFlash();
            processRayCast();
            GetComponent<Ammo>().reduceAmmo();
        }
        yield return new WaitForSeconds(timeBetweenShots);
        canShot = true;
    }

    private void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
    }

    private void processRayCast()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, transform.forward, out hit, range))
        {
            CreateHitImpact(hit);
            //effects ... 
            //Debug.Log("shooted to :" + hit.transform.name);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target != null)
            {
                Debug.Log("shooted to :");
                target.TakeDamage(damage);
            }
        }
        else
        {
            return;
        }
    }

    private void CreateHitImpact(RaycastHit hit)
    {
        GameObject instance = Instantiate(hitEffect, hit.point,Quaternion.LookRotation(hit.normal));
        Destroy(instance,0.1f);
    }
}
