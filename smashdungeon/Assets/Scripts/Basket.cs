using UnityEngine;
using UnityEngine.InputSystem;

public class Basket: MonoBehaviour {

    public float speed = 10f;
    public HUD hud;

    void Start() {
    }

    void Update() {

    }

    /* void OnLeftMove(InputValue input) {
        Debug.Log("Left move");

        var velocity = input.Get<Vector2>();

        GetComponent<Rigidbody2D>().velocity = velocity * speed;
    } */

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemy") {
            GameObject.Destroy(other.gameObject);
            var enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
            Debug.Log("Enemy count: " + enemyCount);
            if (enemyCount == 1) {
                Base.pause = true;
                hud.endGameDialog.gameObject.SetActive(true);
                hud.endGameDialog.title.text = "You won!";
            }
        }
    }

}