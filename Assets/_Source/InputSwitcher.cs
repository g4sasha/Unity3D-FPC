using UnityEngine;
using UnityEngine.UI;

public class InputSwitcher : MonoBehaviour
{
    public bool IsInputEnabled { get; private set; } = true;
    [SerializeField] private Text statusText;

    private void Start()
    {
        EnableInput();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ToggleInput();
        }

        if (Input.GetMouseButtonDown(0))
        {
            EnableInput();
        }
    }

    private void ToggleInput()
    {
        IsInputEnabled = !IsInputEnabled;
        UpdateStatusText();

        if (!IsInputEnabled)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void EnableInput()
    {
        IsInputEnabled = true;
        UpdateStatusText();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void UpdateStatusText() => statusText.text = IsInputEnabled ? string.Empty : "Input disabled";
}