using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake was called");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start was called");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(transform.forward);
        }

    }
}
