﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMachineGun : WeaponBase
{
    /// <summary>
    /// Shoot will spawn a new bullet, provided enough time has passed compared to our fireDelay.
    /// </summary>
    public override void Shoot()
    {
        float CurrentTime = Time.time;

        // Have a delay so we don't shoot too many bullets
        if (CurrentTime - lastFiredTime > fireDelay)
        {
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y);

            Instantiate(bullet, spawnPosition, transform.rotation);

            lastFiredTime = CurrentTime;
        }
    }
    /// <summary>
    /// SampleMethod is a sample of how to use abstraction by
    /// specification. It converts a provided integer to a float.
    /// </summary>
    /// <param name="number">any integer</param>
    /// <returns>the number parameter as a float</returns>
    public float SampleMethod(int number)
    {
        return number;
    }
}