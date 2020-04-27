using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class DualKeyboardPlayerAssignment : MonoBehaviour
{
    [SerializeField]
    private string secondKeyboardControlScheme = "KeyboardIJKL";

    private void Awake()
    {
        TryAssignKeyboard();
    }

    public void TryAssignKeyboard()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        PlayerInput[] playerInputs = new PlayerInput[players.Length];

        for (int i = 0; i < players.Length; i++)
        {
            playerInputs[i] = players[i].GetComponent<PlayerInput>();
            if (playerInputs[i] != null && !playerInputs[i].Equals(null) && playerInputs[i].currentControlScheme == secondKeyboardControlScheme)
            {
                InputUser.PerformPairingWithDevice(Keyboard.current, playerInputs[i].user);
                break;
            }
        }
    }
}
