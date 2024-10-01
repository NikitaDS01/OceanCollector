using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractMovePlayer : MonoBehaviour
{
    public enum TypeMove
    {
        Keyboard = 0,
        Phone = 1
    }

    private bool _isRight;
    private float _speed;
    private Rigidbody2D _rigidbody;
    private Transform _transform;

    public AbstractMovePlayer(
        Rigidbody2D rigidbody, Transform transform,
        float moveSpeed, bool isRight = false
        )
    {
        this._isRight = isRight;
        this._rigidbody = rigidbody;
        this._transform = transform;
    }

    protected bool isRight => this._isRight;
    protected Rigidbody2D rigidbody => this._rigidbody;
    protected Transform transform => this._transform;
    public float Speed => this._speed;

    public abstract TypeMove Type { get; }
    public abstract void Move();

    protected void Flip(float direction)
    {
        if (direction < 0)
        {
            _isRight = isRight;
            Vector3 scale = _transform.localScale;
            scale.x *= -1f;
            _transform.localScale = scale;
        }
    }

}
