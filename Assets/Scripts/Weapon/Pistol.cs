using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public override void Shoot(Transform shootPoint, Transform shootPoint1, Transform shootPoint2)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.identity);
    }
}
