using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Idle : State
{
    [SerializeField] private float chaseDistance;

    [SerializeField] private State chaseState;

    [SerializeField] private GameObject symbol;

    public override State StateUpdate()
    {
        #region Checks
        if (Vector2.Distance(transform.position, player.transform.position) < chaseDistance)
            return chaseState;
        #endregion

        #region Actions
        rb.velocity = Vector2.zero;
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