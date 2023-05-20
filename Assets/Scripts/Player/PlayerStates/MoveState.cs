using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : IState
{
    public void OnEnter(PlayerController controller)
    {
    }

    public void OnExit(PlayerController controller)
    {
    }

    public void UpdateState(PlayerController controller)
    {
        float moveX = Input.GetAxis("Horizontal");

        // Move horizontally
        controller.rb.velocity = new Vector2(moveX * controller.moveSpeed, controller.rb.velocity.y);

        // Jump
        if (Input.GetButtonDown("Jump"))
        {
            controller.rb.AddForce(new Vector2(0f, controller.jumpForce), ForceMode2D.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            controller.ChangeState(controller.echoBeamState);
        }
    }
}
