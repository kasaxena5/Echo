using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoBeamState : IState
{
    private EchoBeamSpawner echoBeamSpawner;

    public void OnEnter(PlayerController controller)
    {
        echoBeamSpawner = controller.echoBeamSpawner;

        echoBeamSpawner.InstantiateBeam();
    }

    public void OnExit(PlayerController controller)
    {
    }

    public void UpdateState(PlayerController controller)
    {
        if(echoBeamSpawner.spawnCompleted)
        {
            controller.ChangeState(controller.moveState);
        }
    }
}
