using UnityEngine;
using UnityEngine.InputSystem;

public class Selector : MonoBehaviour
{
    [SerializeField]
    private int nrOfCharacters = 1;
    private bool selectCharacter = true;


    private int selectedTeamID = 0;

    public int ConnectedDeviceID { get; private set; }

    public int PlayerIndex { get; private set; }

    public int SelectedTeamID
    {
        get { return selectedTeamID; }
        private set
        {
            print($"TeamID value: {value}");
            if (value >= 0 && value < 4)
                selectedTeamID = value;
        }
    }

    private int selectedCharacterID = 0;
    public int SelectedCharacterID
    {
        get { return selectedCharacterID; }
        private set
        {
            print($"CharID value: {value}");
            if (value >= 0 && value < nrOfCharacters)
                selectedCharacterID = value;
        }
    }

    private void Awake()
    {
        PlayerInput playerInput = GetComponent<PlayerInput>();
        PlayerIndex = playerInput.playerIndex;
        ConnectedDeviceID = playerInput.devices[0].deviceId;
    }

    public void Select(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            SelectedCharacterID += (int)MathW.Sign(context.ReadValue<Vector2>().x);
            SelectedTeamID += (int)MathW.Sign(context.ReadValue<Vector2>().y);
        }
    }
}
