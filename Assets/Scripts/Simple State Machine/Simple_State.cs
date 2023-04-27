using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Simple_State : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected GameObject player;

    private void Awake()
    {
        rb = transform.parent.parent.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public abstract Simple_State StateUpdate();
}
