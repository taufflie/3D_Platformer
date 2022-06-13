using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity101_RigidbodyController : MonoBehaviour
{
    private Animator anim;
    public float Speed = 10f;
    public float JumpHeight = 2f;
    public float GroundDistance = 0.5f;
    public float DashDistance = 5f;
    public LayerMask Ground;
    public Transform GroundChecker;

    private Rigidbody _body;
    private Vector3 _inputs = Vector3.zero;
    private bool _isGrounded = true;

    void Start()
    {
        _body = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        _isGrounded = Physics.CheckSphere(GroundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);


        _inputs = Vector3.zero;
        _inputs.x = Input.GetAxis("Horizontal");
        _inputs.z = Input.GetAxis("Vertical");

        if (_inputs != Vector3.zero)
        { 
        anim.SetBool("Iswalking", true);
        }
          
        else
        {
        anim.SetBool("Iswalking", false);
        }

        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _body.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
            anim.SetTrigger("IsJumping");
        }
        if (Input.GetButtonDown("Dash"))
        {
            Vector3 dashVelocity = Vector3.Scale(_inputs, DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime)));
            _body.AddForce(dashVelocity, ForceMode.VelocityChange);
            anim.SetTrigger("IsDashing");
        }
    }


    void FixedUpdate()
    {
        MovePlayer(_inputs);
    }

    private void MovePlayer(Vector3 direction)
    {
        direction = _body.rotation * direction;
        _body.MovePosition(_body.position + direction * Speed * Time.fixedDeltaTime);
    }
}
