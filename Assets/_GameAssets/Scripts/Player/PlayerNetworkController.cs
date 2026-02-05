using Unity.Cinemachine;
using Unity.Netcode;
using Unity.Services.Matchmaker.Models;
using UnityEngine;

public class PlayerNetworkController : NetworkBehaviour
{
    [SerializeField] private CinemachineCamera _playerCamera;

    public override void OnNetworkSpawn()
    {
        _playerCamera.gameObject.SetActive(IsOwner);
    }
}