using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABlock_Shoot : AStateBlock
{
    [SerializeField] private GameObject projectile;

    [SerializeField] private float shootInterval;
    [SerializeField] private float projectileSpeed;

    private float shootTimer;

    public override AState OnUpdate(GameObject user, GameObject target)
    {
        shootTimer += Time.deltaTime;
        if (shootTimer >= shootInterval)
        {
            Shoot(target);
            shootTimer = 0;
        }

        return null;
    }

    public override void OnStart(GameObject user, GameObject target) { }

    public override void OnEnd(GameObject user, GameObject target) { }

    public void Shoot(GameObject target)
    {
        GameObject bullet = Instantiate(projectile);
        bullet.transform.position = transform.position;
        bullet.GetComponent<Rigidbody2D>().velocity = (target.transform.position - transform.position).normalized * projectileSpeed;
    }
}
