using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected GameObject player;

    private void Awake()
    {
        rb = transform.parent.parent.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public abstract State StateUpdate();
    public abstract void StateStart();
    public abstract void StateEnd();
}
