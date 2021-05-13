using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player Object
public class PlayerMove : MonoBehaviour
{
    private float _h;
    private float _v;
    private Vector3 _moveVector;
    public float moveSpeed;

    void FixedUpdate()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
        _moveVector = new Vector3(_h, _v);
        transform.Translate(_moveVector * moveSpeed, Space.Self);
    }
}
