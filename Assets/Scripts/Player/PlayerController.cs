using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Configs")]
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public float jumpForce = 5f;

    [Header("Internal Components")]
    public Rigidbody2D rb;

    [Header("Helper Classes for the state")]
    public EchoBeamSpawner echoBeamSpawner;

    [Header("Prefabs and SO")]
    [SerializeField] private FloatReference health;

    IState currentState;
    public JumpState jumpState = new();
    public MoveState moveState = new();
    public EchoBeamState echoBeamState = new();

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        ChangeState(moveState);
    }

    void Update()
    {
        if(currentState != null)
            currentState.UpdateState(this);
    }

    public void ChangeState(IState newState)
    {
        if(currentState != null)
            currentState.OnExit(this);
        currentState = newState;
        currentState.OnEnter(this);
    }

    public void InflictDamage(float damage)
    {
        health.value = Mathf.Max(health.value - damage, 0);
    }
}

public interface IState
{
    public void OnEnter(PlayerController controller);
    public void UpdateState(PlayerController controller);
    public void OnExit(PlayerController controller);
}