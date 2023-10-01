using UnityEngine;
using UnityEngine.InputSystem;

class Player: MonoBehaviour {

    public float speed = 10f;
    public float health = 100f;
    private const float HealthDecrease = 10f;
    private const string EnemyTag = "Enemy";
    
    private Rigidbody2D _rb;
    
    private void Start()
    {
    }

    private void Update()
    {
    }
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue input)
    {
        var velocity = input.Get<Vector2>();
        _rb.velocity = velocity * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(EnemyTag))
        {
            health -= HealthDecrease;
            Debug.Log("Collision");
        }
    }

}