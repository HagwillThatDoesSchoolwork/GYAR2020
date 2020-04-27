using System.Collections.Generic;
using UnityEngine;

public class CachedPlayerData : MonoBehaviour
{
    static List<Selector> selectors;

    static public Dictionary<string, int> player1, player2, player3, player4;

    static public int NrOfActivePlayers { get; private set; }

    private void Awake() => DontDestroyOnLoad(gameObject);

    static public void CachePlayerData()
    {
        Selector[] selectorArray = new Selector[4];
        GameObject[] selectorGameObjects = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < selectorArray.Length; i++)
            selectorArray[i] = selectorGameObjects[i].GetComponent<Selector>();

        selectors = new List<Selector>();
        selectors.AddRange(selectorArray);

        List<int> inactivePlayers = new List<int>();
        for (int i = 0; i < selectorArray.Length; i++)
        {
            if (selectors[i].SelectedCharacterID == 0)
                inactivePlayers.Add(i);
        }

        for (int i = inactivePlayers.Count; i > 0; i--)
            selectors.RemoveAt(inactivePlayers[i - 1]);

        NrOfActivePlayers = selectors.Count;

        for (int i = 0; i < selectors.Count; i++)
        {
            switch (i)
            {
                case 0:
                    player1 = new Dictionary<string, int>
                    {
                        { "character", selectors[i].SelectedCharacterID },
                        { "team", selectors[i].SelectedTeamID },
                        { "device", selectors[i].ConnectedDeviceID },
                        { "user", selectors[i].PlayerIndex }
                    };
                    break;
                case 1:
                    player2 = new Dictionary<string, int>
                    {
                        { "character", selectors[i].SelectedCharacterID },
                        { "team", selectors[i].SelectedTeamID },
                        { "device", selectors[i].ConnectedDeviceID },
                        { "user", selectors[i].PlayerIndex }
                    };
                    break;
                case 2:
                    player3 = new Dictionary<string, int>
                    {
                        { "character", selectors[i].SelectedCharacterID },
                        { "team", selectors[i].SelectedTeamID },
                        { "device", selectors[i].ConnectedDeviceID },
                        { "user", selectors[i].PlayerIndex }
                    };
                    break;
                case 3:
                    player4 = new Dictionary<string, int>
                    {
                        { "character", selectors[i].SelectedCharacterID },
                        { "team", selectors[i].SelectedTeamID },
                        { "device", selectors[i].ConnectedDeviceID },
                        { "user", selectors[i].PlayerIndex }
                    };
                    break;
            }
        }
    }
}
