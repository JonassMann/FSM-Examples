using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABlock_MoveTowards : AStateBlock
{
    private Rigidbody2D rb;

    [SerializeField] private float speed;

    public override AState OnUpdate(GameObject user, GameObject target)
    {
        rb.velocity = (target.transform.position - transform.position).normalized * speed;

        return null;
    }

    public override void OnStart(GameObject user, GameObject target)
    {
        rb = user.GetComponent<Rigidbody2D>();
    }

    public override void OnEnd(GameObject user, GameObject target) { }
}
