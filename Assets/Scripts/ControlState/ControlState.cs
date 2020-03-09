using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControlState 
{
    // Start is called before the first frame update
    protected PlayerController controller;
    public abstract void Move(); // This is abstract so it MUST be implemented in derived classes.
   

    public virtual void Enter()
    {

    } // Virtual so can be overriden in derived classes.
    public virtual void Leave()
    {


    }

    public ControlState(PlayerController theController) // Constructor that takes an argument.
    {
        controller = theController;
    }
}
