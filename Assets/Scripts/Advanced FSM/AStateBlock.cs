using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AStateBlock : MonoBehaviour
{
    public abstract void OnStart(GameObject user, GameObject target);
    public abstract AState OnUpdate(GameObject user, GameObject target);
    public abstract void OnEnd(GameObject user, GameObject target);
}
