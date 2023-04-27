using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AState : MonoBehaviour
{
    private List<AStateBlock> stateBlocks;

    private GameObject user;
    private GameObject target;

    private Rigidbody2D rb;

    private void Awake()
    {
        user = transform.parent.parent.gameObject;
        target = GameObject.FindGameObjectWithTag("Player");

        rb = user.GetComponent<Rigidbody2D>();
    }

    public AState StateUpdate()
    {
        rb.velocity = Vector3.zero;

        AState returnState = null;

        foreach (AStateBlock blk in stateBlocks)
        {
            returnState = blk.OnUpdate(user, target);
            if (returnState != null)
                break;
        }

        return returnState;
    }

    public void StateStart()
    {
        stateBlocks = new List<AStateBlock>(GetComponents<AStateBlock>());

        foreach (AStateBlock blk in stateBlocks)
            blk.OnStart(user, target);
    }

    public void StateEnd()
    {
        foreach (AStateBlock blk in stateBlocks)
            blk.OnEnd(user, target);
    }
}
