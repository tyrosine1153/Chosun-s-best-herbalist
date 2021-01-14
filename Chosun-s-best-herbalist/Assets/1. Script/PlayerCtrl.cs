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
        h = GameManager.Instance.isAction ? 0 : Input.GetAxisRaw("Horizontal");
        v = GameManager.Instance.isAction ? 0 : Input.GetAxisRaw("Vertical");

        // Debug.Log(h + ", " + v);

        hDown = Input.GetButtonDown("Horizontal");
        vDown = Input.GetButtonDown("Vertical");
        hUp = Input.GetButtonUp("Horizontal");
        vUp = Input.GetButtonUp("Vertical");

        if (hDown || vUp)
            _isHorizonmove = true;
        else if (vDown || hUp)
            _isHorizonmove = false;

        try {
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
        catch (NullReferenceException ex) {
            Debug.LogError("Fucking anima");
        }
        
        if (Input.GetKeyDown(KeyCode.Z))
            Debug.Log("ZZZZ");
    }

    void FixedUpdate()
    {
        _moveVec = _isHorizonmove ? new Vector2(h, 0) : new Vector2(0, v);
        transform.Translate(_moveVec * moveSpeed, Space.Self);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if (other.gameObject.layer == 9)
            {
                Debug.Log("NPC");
                UIManager.Instance.isTalk = true;
                UIManager.Instance.TalkToNPC(other.gameObject);
            }
        }
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if (other.gameObject.layer == 8)
            {
                Debug.Log("Herb");
                GameManager.Instance.isAction = true;
                _animator.SetBool("isGathering",true);
                GameManager.Instance.GetItem(other.gameObject);
            }
        }
    }
}