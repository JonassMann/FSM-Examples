using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM : MonoBehaviour
{
    /*
    
    A normal Finite State Machine

    Runs the necessary Update function, but also has Start and End functions
    Allows for far more functionality

     */

    public State currentState;

    private void Start()
    {
        if (currentState != null)
            currentState.StateStart();
    }

    private void Update()
    {
        State nextState = currentState?.StateUpdate();

        if (nextState != null)
            NextState(nextState);
    }

    private void NextState(State nextState)
    {
        currentState.StateEnd();
        currentState = nextState;
        currentState.StateStart();
    }
}
