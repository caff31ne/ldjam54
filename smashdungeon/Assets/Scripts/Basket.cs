using UnityEngine;
using UnityEngine.InputSystem;

class Basket: MonoBehaviour {

    public float speed = 10f;

    void Start() {
    }

    void Update() {

    }

    private void OnLeftMove(InputValue input) {
        Debug.Log("Left move");

        var velocity = input.Get<Vector2>();

        GetComponent<Rigidbody2D>().velocity = velocity * speed;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemy") {
            GameObject.Destroy(other.gameObject);
        }
    }

}