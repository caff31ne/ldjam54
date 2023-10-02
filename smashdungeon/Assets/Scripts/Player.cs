using UnityEngine;
using UnityEngine.InputSystem;

public class Player: MonoBehaviour {

    public float speed = 10f;
    public float health = 100f;
    private const float HealthDecrease = 10f;
    private const string EnemyTag = "Enemy";
    
    private Rigidbody2D _rb;

    public HUD hud;

    public Basket basket;
    
    private void Start()
    {
        Debug.Log("Basket start");
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
        if (Base.pause) {
            _rb.velocity = Vector2.zero;
            return;
        }
        var velocity = input.Get<Vector2>();
        _rb.velocity = velocity * speed;
    }

    void OnLeftMove(InputValue input) {
        if (Base.pause) {
            basket.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            return;
        }

        var velocity = input.Get<Vector2>();

        basket.GetComponent<Rigidbody2D>().velocity = velocity * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(EnemyTag))
        {
            health -= HealthDecrease;
            //Debug.Log("Collision");

            if (health <= 0) {
                Base.pause = true;
                hud.endGameDialog.gameObject.SetActive(true);
                hud.endGameDialog.title.text = "You lose!";
            }
        }
    }

}