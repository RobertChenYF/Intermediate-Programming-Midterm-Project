using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStateRotateAroundAPoint : ControlState
{
    // Start is called before the first frame update

    [SerializeField] private float rotateSpeed = 120;
    private float currentRotateSpeed;
    public ControlStateRotateAroundAPoint(PlayerController controller) : base(controller)
    {

    }

    public override void Move()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentRotateSpeed = -currentRotateSpeed;
        }
        controller.transform.position += new Vector3(0,0,currentRotateSpeed*Time.deltaTime);
    }

    public override void Enter()
    {
        base.Enter();
        currentRotateSpeed = rotateSpeed;
        
    }

    public override void Leave()
    {
        base.Leave();
    }
}
