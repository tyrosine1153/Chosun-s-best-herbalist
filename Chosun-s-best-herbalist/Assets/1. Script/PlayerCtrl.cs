using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float h;
    private float v;
    private Rigidbody2D _rigidbody;
    public float moveSpeed;
    public float maxSpeed;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        /*
        Vector2 moveVec = _rigidbody.velocity;

        // 키보드 떼면 속도 줄어들게 하는거
        if (Input.GetButtonUp("Horizontal"))
            moveVec = new Vector2(moveVec.x * 0.1f, moveVec.y);
        if (Input.GetButtonUp("Vertical"))
            moveVec = new Vector2(moveVec.x, moveVec.y * 0.1f);
        
        // 속도가 너무 크면 고정하는거
        if (math.abs(moveVec.x) > maxSpeed)
            moveVec = new Vector2(maxSpeed * (moveVec.x > 0 ? 1 : -1), moveVec.y);
        if (math.abs(moveVec.y) > maxSpeed)
            moveVec = new Vector2(moveVec.x, maxSpeed * (moveVec.y > 0 ? 1 : -1));

        _rigidbody.velocity = moveVec;
        
        _rigidbody.AddForce(new Vector2(h, v) * moveSpeed, ForceMode2D.Impulse);*/
        transform.Translate(new Vector2(h,v) * moveSpeed, Space.Self);
    }
}
