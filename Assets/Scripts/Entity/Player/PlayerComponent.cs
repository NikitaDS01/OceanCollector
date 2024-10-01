using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity компонент для получения доступа к 
/// контейнеру игроку
/// </summary>
public class PlayerComponent : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private SpriteRenderer _sprite;
    private Transform _transform;

    private void Start()
    {
        this._transform = this.GetComponent<Transform>();
        this._rigidbody = this.GetComponent<Rigidbody2D>();
        this._sprite = this.GetComponent<SpriteRenderer>();
    }

    public Rigidbody2D Rigidbody => _rigidbody;
    public SpriteRenderer Sprite => _sprite;
    public Transform Transform => _transform;
}
