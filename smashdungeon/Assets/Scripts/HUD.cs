using UnityEngine;

public class HUD: MonoBehaviour {

    public GameEndDialog endGameDialog;
    public Base gameBase;

    void Start() {}

    void Update() {}

    public void OnGameOver() {
        endGameDialog.gameObject.SetActive(false);
        gameBase.Restart();
    }
}