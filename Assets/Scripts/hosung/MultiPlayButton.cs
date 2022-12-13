using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class MultiPlayButton : MonoBehaviour
{
    [SerializeField] GameObject multiplayPanel;
    [SerializeField] GameObject playerListPanel;

    void Awake()
    {

    }

    public void OnClickMultiplayButton()
    {
        multiplayPanel.SetActive(!multiplayPanel.activeSelf);
    }

    public void OnClickPlayerListButton()
    {
        playerListPanel.SetActive(!playerListPanel.activeSelf);
    }

    void Update()
    {
        if (PhotonNetwork.InRoom && (int)PhotonNetwork.CurrentRoom.CustomProperties["maxPlayers"] > 1)
        {
            GetComponentInChildren<Text>().text = "방 설정";
        }
        // if (this.gameObject.name == "MultiplayerListBtn") return;
        // if (PhotonNetwork.InRoom && !PhotonNetwork.IsMasterClient) this.gameObject.SetActive(false);
    }
}
