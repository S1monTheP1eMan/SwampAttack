using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    public override void Shoot(Transform shootPoint, Transform shootPoint1, Transform shootPoint2)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        Instantiate(Bullet, shootPoint1.position, Quaternion.identity);
        Instantiate(Bullet, shootPoint2.position, Quaternion.identity);
    }
}
