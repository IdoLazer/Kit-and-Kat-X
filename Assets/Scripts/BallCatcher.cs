using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCatcher : MonoBehaviour
{

    public PlayerController playerController;


    private bool canThrow = true;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Ball") && canThrow)
        {
            playerController.Catch(collider);
        }
    }

    public void Throw()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        canThrow = false;
        yield return new WaitForSeconds(0.2f);
        canThrow = true;
    }
}
