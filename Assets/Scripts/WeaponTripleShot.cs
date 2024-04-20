using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTripleShot : WeaponBase
{
    [SerializeField]
    private int y = 1;

    /// <summary>
    /// Shoot will spawn a three bullets, provided enough time has passed compared to our fireDelay.
    /// </summary>
    public override void Shoot()
    {
        float CurrentTime = Time.time;

        print("Shoot triple shot");
        // Have a delay so we don't shoot too many bullets
        if (CurrentTime - lastFiredTime > fireDelay)
        {
            float x = -0.5f;

            for (int i = 0; i < 3; i++)
            {
                GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.position, transform.rotation);
                newBullet.GetComponent<MoveConstantly>().Direction = new Vector2( x + 0.5f * i, 0.5f * y);
            }

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
