using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetwrokManager : NetworkManager
{
    

    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);

        MyNetworkPlayer player = player = conn.identity.GetComponent<MyNetworkPlayer>();

        Color randomChosenColor = new Color(
            Random.Range(0f,1.0f),
            Random.Range(0f, 1.0f),
            Random.Range(0f, 1.0f));

        
        player.SetPlayerName($"Player {numPlayers}");
        player.SetPlayerColor(randomChosenColor);
        


        Debug.Log($"There are {numPlayers} players in the server");
    }

}
