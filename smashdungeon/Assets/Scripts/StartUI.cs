using UnityEngine;
using UnityEngine.SceneManagement;

class StartUI: MonoBehaviour {

    void Start() {}

    void Update() {}

    public void OnStart() {
        SceneManager.LoadScene("GameScene");
    }
}