using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerType : MonoBehaviour
{
    public GameObject Player, CurrentPlayer;
    private void OnMouseDown()
    {
        Player.SetActive(true);
        CurrentPlayer.SetActive(false);
    }

}
