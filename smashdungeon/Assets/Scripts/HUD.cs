using UnityEngine;

public class HUD: MonoBehaviour {

    public GameObject endGameDialog;
    public Base gameBase;

    void Start() {}

    void Update() {}

    public void OnGameOver() {
        endGameDialog.SetActive(false);
        gameBase.Restart();
    }
}