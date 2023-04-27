using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABlock_Enable : AStateBlock
{
    [SerializeField] private GameObject obj;
    [SerializeField] private bool enable = true;

    public override AState OnUpdate(GameObject user, GameObject target) { return null; }

    public override void OnStart(GameObject user, GameObject target)
    {
        obj.SetActive(enable);
    }

    public override void OnEnd(GameObject user, GameObject target)
    {
        obj.SetActive(!enable);
    }
}
