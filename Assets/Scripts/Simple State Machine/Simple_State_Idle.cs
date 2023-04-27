using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_State_Idle : Simple_State
{
    [SerializeField] private float chaseDistance;

    [SerializeField] private Simple_State chaseState;

    public override Simple_State StateUpdate()
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
}