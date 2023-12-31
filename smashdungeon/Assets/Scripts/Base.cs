using UnityEngine;

public class Base: MonoBehaviour
{
    public Transform topWall;
    public Transform bottomWall;
    public Transform leftWall;
    public Transform rightWall;
    public Transform enemyPrototype;

    private Vector3 topWallOriginalScale = Vector3.zero;
    private Vector3 bottomWallOriginalScale = Vector3.zero;
    private Vector3 leftWallOriginalScale = Vector3.zero;
    private Vector3 rightWallOriginalScale = Vector3.zero;

    public Player player;

    public static bool pause = false;
    
    // Start is called before the first frame update
    private void Start()
    {
        topWallOriginalScale = topWall.localScale;
        bottomWallOriginalScale = bottomWall.localScale;
        leftWallOriginalScale = leftWall.localScale;
        rightWallOriginalScale = rightWall.localScale;
        SpawnEnemies();
    }

    private void SpawnEnemies() {
        for (int i = 0; i < 10; i++)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        var enemy = Instantiate(enemyPrototype, transform);
        enemy.transform.position = new Vector3(Random.Range(-12.0f, 12.0f),
            Random.Range(-8.0f, 8.0f), 0);
    }

    // Update is called once per frame
    private void Update()
    {
        var scaleIncrease = new Vector3(Time.deltaTime / 5, 0, 0);
        topWall.localScale += scaleIncrease;
        bottomWall.localScale += scaleIncrease;
        leftWall.localScale += scaleIncrease;
        rightWall.localScale += scaleIncrease;
    }

    public void Restart() {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies) {
            GameObject.Destroy(enemy.gameObject);
        }
        SpawnEnemies();

        player.health = 100;
        pause = false;
        topWall.localScale = topWallOriginalScale;
        bottomWall.localScale = bottomWallOriginalScale;
        leftWall.localScale = leftWallOriginalScale;
        rightWall.localScale = rightWallOriginalScale;
    }
}
