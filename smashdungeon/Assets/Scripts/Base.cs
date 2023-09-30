using UnityEngine;

public class Base : MonoBehaviour
{
    public Transform topWall;
    public Transform bottomWall;
    public Transform leftWall;
    public Transform rightWall;
    
    // Start is called before the first frame update
    private void Start()
    {
        
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
