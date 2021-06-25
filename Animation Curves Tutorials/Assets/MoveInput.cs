using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInput : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    private Vector2 _currentPos;

    // Update is called once per frame
    private void Update()
    {
        float userInputV = Input.GetAxis("Vertical");
        float userInputH = Input.GetAxis("Horizontal");

        transform.Translate(new Vector2(userInputH, userInputV) * speed * Time.deltaTime);
    }
}