using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] int carbineAmmoAmount = 10;
    [SerializeField] int pistolAmmoAmount = 10;
    [SerializeField] int shotgunAmmoAmount = 5;
    int ammoAmount;
    int currentWeapon;
    // Start is called before the first frame update
    public int GetCurrentAmmo()
    {
        weaponSwitcher weapon_Switcher = GetComponent<weaponSwitcher>();
        currentWeapon = weapon_Switcher.getCurrentWeapon();

        switch (currentWeapon)
        {
            case 0:
                ammoAmount = carbineAmmoAmount;
                break;
            case 1:
                ammoAmount = pistolAmmoAmount;
                break;
            case 2:
                ammoAmount = shotgunAmmoAmount; 
                break;
        }
        return ammoAmount;
    }

    public void reduceAmmo()
    {
        weaponSwitcher weapon_Switcher = GetComponent<weaponSwitcher>();
        currentWeapon = weapon_Switcher.getCurrentWeapon();

        switch (currentWeapon)
        {
            case 0:
                if(carbineAmmoAmount > 0)
                    carbineAmmoAmount--;
                break;
            case 1:
                if (pistolAmmoAmount > 0)
                    pistolAmmoAmount--;
                break;
            case 2:
                if(shotgunAmmoAmount > 0)
                    shotgunAmmoAmount--;
                break;
        }
        
    }
}
