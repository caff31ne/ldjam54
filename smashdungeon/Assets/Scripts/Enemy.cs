using UnityEngine;

class Enemy: MonoBehaviour {
    
    private Rigidbody2D _rb;
    public float speed = 10f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _rb.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)) * speed;
    }

    private void Update() {
        if (Base.pause) {
            _rb.bodyType = RigidbodyType2D.Kinematic;
            _rb.velocity = Vector2.zero;
        }
    }

}