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
  /*  private Vector2 _rayVec;
    private RaycastHit2D _raycast;
    private GameObject _rayObj;
*/
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
/*
        if (hDown)
            _rayVec = new Vector3(h, 0);
        else if (vDown)
            _rayVec = new Vector3(0, v);

        if (Input.GetKeyDown(KeyCode.Z)&&_rayObj)
        {
            Debug.Log(_rayObj.name);
            Action();
        }*/
    }

    void FixedUpdate()
    {
        _moveVec = _isHorizonmove ? new Vector2(h, 0) : new Vector2(0, v);
        transform.Translate(_moveVec * moveSpeed, Space.Self);
/*
        Debug.DrawRay(new Vector2(transform.position.x, transform.position.y - 0.5f), _rayVec);
        _raycast = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 0.5f), _rayVec, 1f, 8);

        if (_raycast.collider)
            _rayObj = _raycast.collider.gameObject;
        else
            _rayObj = null;*/
    }

/*    void Action()
    {
        if (_rayObj.CompareTag("Herb"))
        {
            GameManager.Instance.GetItem(_rayObj);
            Debug.Log("asdfasdf");
        }
        else if (_rayObj.CompareTag("NPC"))
        {
            GameManager.Instance.TalkToNPC(_rayObj);
        }
    }
*/
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if (other.gameObject.layer == 9)
            {
                Debug.Log("NPC");
                UIManager.Instance.isTalk = true;
                // 애니메이션
                UIManager.Instance.TalkToNPC(other.gameObject);
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if (other.gameObject.layer == 8)
            {
                Debug.Log("Herb");
                GameManager.Instance.isAction = true;
                // 애니메이션
                GameManager.Instance.GetItem(other.gameObject);
            }
        }
    }
}