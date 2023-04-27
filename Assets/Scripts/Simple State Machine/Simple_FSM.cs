using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_FSM : MonoBehaviour
{
    public Simple_State currentState;

    private void Update()
    {
        Simple_State nextState = currentState?.StateUpdate();

        if (nextState != null)
            currentState = nextState;
    }
}
