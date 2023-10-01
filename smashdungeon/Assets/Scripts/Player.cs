using UnityEngine;
using UnityEngine.InputSystem;

class Player: MonoBehaviour {

    public float speed = 10f;
    public float health = 100f;
    
    private void Start() {
    }

    private void Update() {
    }

    private void OnMove(InputValue input) {
        var velocity = input.Get<Vector2>();
        if (velocity != Vector2.zero)
            GetComponent<Rigidbody2D>().velocity = velocity * speed;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemy") {
            health -= 10f;
        }
    }

}