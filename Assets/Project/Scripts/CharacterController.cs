using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float _Speed = 1f;
    float _LimitSpeed = 5f;
    [SerializeField] float _SpeedScale = 0.01f;
    [SerializeField] float _SpinSpeed = 1f;
    Animator _Animator = null;
    float _Horizontal = 0f;
    float _Vertical = 0f;
    void Start()
    {
        _Animator = GetComponent<Animator>();
    }

    void Update()
    {
        _Horizontal = Input.GetAxis("Horizontal") * _SpinSpeed * Time.deltaTime;
        _Vertical = Input.GetAxis("Vertical") * _Speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift) && _Speed < _LimitSpeed)
        {
            _Speed = Mathf.Lerp(_Speed, _LimitSpeed, _SpeedScale);
        }
        else if (_Speed != 1f)
        {
            _Speed = Mathf.Lerp(_Speed, 1f, _SpeedScale * 2);
        }

        this.transform.Translate(new Vector3(0, 0, _Vertical));
        this.transform.Rotate(new Vector3(0, _Horizontal, 0));

        if (Mathf.Abs(_Vertical) > 0)
        {
            _Animator.SetBool("IsWalking", true);
            _Animator.SetFloat("orientation", _Horizontal);
            _Animator.SetFloat("Speed", Input.GetAxis("Vertical"));
        }
        else
        {
            _Animator.SetBool("IsWalking", false);
            _Animator.SetFloat("orientation", _Horizontal);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Animator.SetTrigger("Jump");
        }

    }
}
