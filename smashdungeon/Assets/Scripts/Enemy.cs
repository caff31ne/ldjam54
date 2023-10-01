using UnityEngine;

class Enemy: MonoBehaviour {
    
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _rb.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }

    private void Update() {
        
    }

}