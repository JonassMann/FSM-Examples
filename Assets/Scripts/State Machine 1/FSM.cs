using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM : MonoBehaviour
{
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
