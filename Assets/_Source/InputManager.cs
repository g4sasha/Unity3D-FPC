using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public bool IsInputEnabled { get; private set; } = true;
    [SerializeField] private Text statusText;

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
    }

    private void EnableInput()
    {
        IsInputEnabled = true;
        UpdateStatusText();
    }

    private void UpdateStatusText()
    {
        if (IsInputEnabled)
        {
            statusText.text = "";
        }
        else
        {
            statusText.text = "Ввод отключен";
        }
    }
}