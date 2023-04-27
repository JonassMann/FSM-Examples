using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AFSM : MonoBehaviour
{
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
