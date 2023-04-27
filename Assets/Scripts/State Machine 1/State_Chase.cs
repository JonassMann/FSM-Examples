using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Chase : State
{
    [SerializeField] private State idleState;
    [SerializeField] private State shootState;

    [SerializeField] private float idleDistance;
    [SerializeField] private float shootDistance;

    [SerializeField] private GameObject symbol;

    [SerializeField] private float speed;

    public override State StateUpdate()
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

    public override void StateStart()
    {
        symbol.SetActive(true);
    }

    public override void StateEnd()
    {
        symbol.SetActive(false);
    }
}