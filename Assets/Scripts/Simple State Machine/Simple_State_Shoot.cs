using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_State_Shoot : Simple_State
{
    [SerializeField] private Simple_State chaseState;

    [SerializeField] private float chaseDistance;

    [SerializeField] private GameObject projectile;

    [SerializeField] private float shootInterval;
    [SerializeField] private float projectileSpeed;

    private float shootTimer = 0;

    public override Simple_State StateUpdate()
    {
        #region Checks
        if (Vector2.Distance(transform.position, player.transform.position) > chaseDistance)
            return chaseState;
        #endregion

        #region Actions
        rb.velocity = Vector2.zero;

        shootTimer += Time.deltaTime;
        if(shootTimer >= shootInterval)
        {
            Shoot();
            shootTimer = 0;
        }
        #endregion

        return null;
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(projectile);
        bullet.transform.position = transform.position;
        bullet.GetComponent<Rigidbody2D>().velocity = (player.transform.position - transform.position).normalized * projectileSpeed;
    }
}