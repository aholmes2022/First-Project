using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferentPath : MonoBehaviour
{
    Vector2 tempPos;
    Vector2 startPos;
    public GameObject cube;
    Vector3 scale;
    Vector3 originScale;


    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        tempPos = transform.position;

        scale = new Vector3(0.01f, -0.01f, 0f);
        originScale = new Vector3(1f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (cube.transform.position.x > 11)
        {
            transform.position = tempPos;
            cube.transform.localScale = originScale;
        }
        else
        {
            if (cube.transform.position.x > 5)
            {
                cube.transform.localScale += scale;
            }
            cube.transform.Translate(1 * Time.deltaTime, 0, 0);
        }

        Debug.Log("X Position: " + cube.transform.position.x);
    }
}
