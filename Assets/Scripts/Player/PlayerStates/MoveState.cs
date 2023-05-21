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
        if(moveX < 0)
        {
            if (PlayerController.facingRight == 1)
            {
                Vector3 scale = controller.transform.localScale;
                scale.x *= -1;
                controller.transform.localScale = scale;
            }
            PlayerController.facingRight = -1;
        }
        else if(moveX > 0)
        {
            if (PlayerController.facingRight == -1)
            {
                Vector3 scale = controller.transform.localScale;
                scale.x *= -1;
                controller.transform.localScale = scale;
            }
            PlayerController.facingRight = 1;
        }

        // Move horizontally
        controller.rb.velocity = new Vector2(moveX * controller.moveSpeed, controller.rb.velocity.y);

        // Jump
        if (Input.GetButtonDown("Jump"))
        {
            if (controller.jumpCount < 2)
            {
                controller.rb.AddForce(new Vector2(0f, controller.jumpForce), ForceMode2D.Impulse);
                controller.jumpCount++;
            }
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            controller.ChangeState(controller.echoBeamState);
        }
    }
}
