using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_State_Chase : Simple_State
{
    [SerializeField] private Simple_State idleState;
    [SerializeField] private Simple_State shootState;

    [SerializeField] private float idleDistance;
    [SerializeField] private float shootDistance;

    [SerializeField] private float speed;

    public override Simple_State StateUpdate()
    {
        #region Checks
        if (Vector2.Distance(transform.position, player.transform.position) > idleDistance)
            return idleState;

        if (Vector2.Distance(transform.position, player.transform.position) < shootDistance)
            return shootState;
        #endregion

        #region Actions
        rb.velocity = (player.transform.position - transform.position).normalized * speed;
        #endregion

        return null;
    }
}