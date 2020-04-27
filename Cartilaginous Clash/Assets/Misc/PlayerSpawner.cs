using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] characterArray;

    GameObject[] players;
    private Dictionary<int, GameObject> characters;

    private void Awake()
    {
        for (int i = 0; i < characterArray.Length; i++)
            characters.Add(i, characterArray[i]);

        int nrOfActivePlayers = CachedPlayerData.NrOfActivePlayers;
        players = new GameObject[nrOfActivePlayers];

        for (int i = 0; i < nrOfActivePlayers; i++)
        {
            switch (i)
            {
                case 0:
                    characters.TryGetValue(CachedPlayerData.player1["character"], out GameObject character);
                    GameObject newPlayer = PlayerInput.Instantiate(character, CachedPlayerData.player1["user"], null, -1, InputSystem.GetDeviceById(CachedPlayerData.player1["device"])).gameObject;
                    //Respawn(newplayer); Make sure that the player is facing the closest enemy when respawned
                    break;
                case 1:
                    characters.TryGetValue(CachedPlayerData.player2["character"], out character);
                    newPlayer = PlayerInput.Instantiate(character, CachedPlayerData.player2["user"], null, -1, InputSystem.GetDeviceById(CachedPlayerData.player2["device"])).gameObject;
                    //Respawn(newplayer); Make sure that the player is facing the closest enemy when respawned
                    break;
                case 2:
                    characters.TryGetValue(CachedPlayerData.player3["character"], out character);
                    newPlayer = PlayerInput.Instantiate(character, CachedPlayerData.player3["user"], null, -1, InputSystem.GetDeviceById(CachedPlayerData.player3["device"])).gameObject;
                    //Respawn(newplayer); Make sure that the player is facing the closest enemy when respawned
                    break;
                case 3:
                    characters.TryGetValue(CachedPlayerData.player4["character"], out character);
                    newPlayer = PlayerInput.Instantiate(character, CachedPlayerData.player4["user"], null, -1, InputSystem.GetDeviceById(CachedPlayerData.player4["device"])).gameObject;
                    //Respawn(newplayer); Make sure that the player is facing the closest enemy when respawned
                    break;
            }
        }
    }

    
}

