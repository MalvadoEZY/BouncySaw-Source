using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWithInUnits = 16f;
    [SerializeField] float minClamp = 1.5f;
    [SerializeField] float maxClamp = 14.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float paddleNewPos = Input.mousePosition.x / Screen.width * screenWithInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);

        paddlePos.x = Mathf.Clamp(paddleNewPos, minClamp, maxClamp);
        transform.position = paddlePos;
    }
}
