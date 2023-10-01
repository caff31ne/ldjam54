using UnityEngine;

class HealthBar: MonoBehaviour {

    public Transform activeBar;
    public Player player;

    void Start() {
    }

    void Update() {
        activeBar.localScale = new Vector3(player.health / 100, 1, 1); 
    }    
}