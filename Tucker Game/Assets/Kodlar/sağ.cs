using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sağ : MonoBehaviour
{
    public GameObject PlayerController;
    void Start()
    {

    }

    // Update is called once per frame
    public void MoveRight()
    {
        for (int a = 0; a < 10; a++)
            PlayerController.transform.position += Vector3.right * 15f * Time.deltaTime;

    }
}
