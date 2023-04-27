using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AFSM : MonoBehaviour
{
    /*
    
    A more advanced version of a Finite State Machine

    In addition to previous functionality, breaks states up into blocks
    Allows for more flexibility in State creation as blocks can be reused

     */

    public AState currentState;

    private void Start()
    {
        if (currentState != null)
            currentState.StateStart();
    }

    private void Update()
    {
        AState nextState = currentState?.StateUpdate();

        if (nextState != null)
            NextState(nextState);
    }

    private void NextState(AState nextState)
    {
        currentState.StateEnd();
        currentState = nextState;
        currentState.StateStart();
    }
}
