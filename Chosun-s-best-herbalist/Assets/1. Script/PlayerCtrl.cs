using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float h;
    private float v;
    private bool hDown, vDown, hUp, vUp; 
    private Vector2 _moveVec;
    private bool _isHorizonmove;

    private Animator _animator;
    
    public float moveSpeed;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        Debug.Log(h + ", " + v);

        hDown = Input.GetButtonDown("Horizontal");
        vDown = Input.GetButtonDown("Vertical");
        hUp = Input.GetButtonUp("Horizontal");
        vUp = Input.GetButtonUp("Vertical");

        if (hDown || vUp)
            _isHorizonmove = true;
        else if (vDown || hUp)
            _isHorizonmove = false;

        if (_animator.GetInteger("hAxisRaw") != (int) h)
        {
            _animator.SetInteger("hAxisRaw", (int) h);
            _animator.SetBool("isChanged", true);
        }
        else if (_animator.GetInteger("vAxisRaw") != (int) v)
        {
            _animator.SetInteger("vAxisRaw", (int) v);
            _animator.SetBool("isChanged", true);
        }
        else
        {
            _animator.SetBool("isChanged", false);
        }
    }

    void FixedUpdate()
    {
        _moveVec = _isHorizonmove ? new Vector2(h, 0) : new Vector2(0, v);
        transform.Translate(_moveVec * moveSpeed, Space.Self);
    }
}
