using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Manager : NetworkBehaviour
{
    private NetworkManager manager;
    private NetworkIdentity _playerPrefab = null;
    void Awake()
    {
        manager = GetComponent<NetworkManager>();
    }
    private void Start()
    {
        manager.StartServer();
    }

    // public override void OnStartServer()
    // {
    //     base.OnStartServer();
    // }
}