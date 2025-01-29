using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // We connect this in the code because the pipe is created at runtime, so after the pipe
        // is created then we need to connect logic to it via the logic manager using the logic tag associated with it.
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
            logic.AddScore(1);
    }
}
