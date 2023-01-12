using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexExecutionOrder : SimpleExecutionOrder
{
    //Cannot be seen in normal inspector

    void Awake()
    {
        Debug.Log(string.Format("{0} has awakened", index));
    }

    new void Start()
    {
        base.Start();
        Debug.Log("Complex execution on Start!");

        // Checking if awakening of will begin execution before this Start method has ended

        //Instantiate(gameObject);
        //index++;
        
    }

    new void Update()
    {
        base.Update();
        Debug.Log("Updating complex execution order!");
    }

    new void LateUpdate()
    {
        base.LateUpdate();
        Debug.Log("LateUpdating complex execution order!");
        Debug.Break();
    }
}