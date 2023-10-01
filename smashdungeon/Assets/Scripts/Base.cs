using UnityEngine;

public class Base : MonoBehaviour
{
    public Transform topWall;
    public Transform bottomWall;
    public Transform leftWall;
    public Transform rightWall;
    public Transform enemyPrototype;
    
    // Start is called before the first frame update
    private void Start()
    {
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
        var scaleIncrease = new Vector3(Time.deltaTime / 10, 0, 0);
        topWall.localScale += scaleIncrease;
        bottomWall.localScale += scaleIncrease;
        leftWall.localScale += scaleIncrease;
        rightWall.localScale += scaleIncrease;
    }
}
