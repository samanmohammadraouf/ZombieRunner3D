using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSwitcher : MonoBehaviour
{
    [SerializeField] int currentWeapon = 0;
    void Start()
    {
        setWeaponActive();
    }

    public void setWeaponActive()
    {
        int weaponIndex = 0;
        foreach(Transform weapon in transform)
        {
            if(weaponIndex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }

    public int getCurrentWeapon()
    {
        return currentWeapon;
    }
}
