using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTheGame : MonoBehaviour
{
    public bool EnteredTrigger;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("Player1") || other.CompareTag("Player2")) && !EnteredTrigger)
        {

            EnteredTrigger = other.GetComponent<PlayerController>().IsHoldingBall;
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if ((other.CompareTag("Player1") || other.CompareTag("Player2")) && !EnteredTrigger)
        {

            EnteredTrigger = other.GetComponent<PlayerController>().IsHoldingBall;

        }
    }
}
