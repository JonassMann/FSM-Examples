using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_FSM : MonoBehaviour
{
    /*
    
    The simpleste version of a finite state machine

    Runs the current state and changes state if another is returned

     */

    public Simple_State currentState;

    private void Update()
    {
        Simple_State nextState = currentState?.StateUpdate();

        if (nextState != null)
            currentState = nextState;
    }
}
