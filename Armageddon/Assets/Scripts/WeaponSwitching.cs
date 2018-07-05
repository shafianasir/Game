using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{

    public int currentWeapon = 0;
    public int maxWeapons = 2;
    public Animator theAnimator;

    void Start()
    {
        SelectWeapon(0);
    }

    public void Switch()
    {
        if (currentWeapon + 1 <= maxWeapons)
        {
            currentWeapon++;
        }
        else
        {
            currentWeapon = 0;
        }
        SelectWeapon(currentWeapon);
    }

    void SelectWeapon(int index)
    {
        for (var i = 0; i < transform.childCount; i++)
        {
            if (i == index)
            {
                if (transform.GetChild(i).name == "Fists")
                {
                    theAnimator.SetBool("WeaponIsOn", false);
                }
                else
                {
                    theAnimator.SetBool("WeaponIsOn", true);
                }
                transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}