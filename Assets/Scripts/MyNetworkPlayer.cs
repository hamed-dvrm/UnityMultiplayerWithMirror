using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetworkPlayer : NetworkBehaviour
{
    [SerializeField] private  Renderer playerColorRenderer = null;

    [SyncVar (hook = nameof(HandleSetPlayerNameUpdated))]
    [SerializeField]
    string playerName = "Missing name";

    [SyncVar(hook =nameof(HandleSetPlayerColorUpdated))]
    [SerializeField]
    Color playerColor = Color.black;

    [Server]
    public void SetPlayerName(string playerName)
    {
        this.playerName = playerName;
    }

    [Server]
    public void SetPlayerColor(Color color)
    {
        this.playerColor = color;
    }

    private void HandleSetPlayerColorUpdated (Color oldColor,Color newColor)
    {
        playerColorRenderer.material.SetColor("_BaseColor", newColor);
        
    }

    private void HandleSetPlayerNameUpdated(string oldPlayerName,string newPlayerName)
    {

    }

    

}
