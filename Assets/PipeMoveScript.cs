using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -60;
    private LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.left * moveSpeed * Time.deltaTime + transform.position;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        if (logic.gameOverScreen.activeSelf)
        {
            moveSpeed = 0;
        }

    }
}
