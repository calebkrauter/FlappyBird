using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = .55f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.left * moveSpeed * Time.deltaTime + transform.position;
    }
}
