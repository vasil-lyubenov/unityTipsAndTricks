using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleExecutionOrder : MonoBehaviour
{
    protected static int index = 0;

    protected void Start()
    {
        Debug.Log("Simple execution on Start!");
    }

    protected void Update()
    {
        Debug.Log("Updating simple execution order!");
    }

    protected void LateUpdate()
    {
        Debug.Log("LateUpdating simple execution order!");
    }
}
