using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABlock_CheckDistance : AStateBlock
{
    [SerializeField] private AState nextState;

    [SerializeField] private float distance;
    [SerializeField] private bool close;

    public override AState OnUpdate(GameObject user, GameObject target)
    {
        if (close == Vector2.Distance(user.transform.position, target.transform.position) <= distance)
            return nextState;

        return null;
    }

    public override void OnStart(GameObject user, GameObject target) { }

    public override void OnEnd(GameObject user, GameObject target) { }
}
