using System;
using UnityEngine;

class Enemy: MonoBehaviour {
    
    public float initialSpeedX = 1.0f;
    public float initialSpeedY = 1.0f;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _rb.velocity = new Vector2(initialSpeedX, initialSpeedY);
    }

    private void Update() {
        
    }

}