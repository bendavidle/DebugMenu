using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace DebugMenu;

public class DebugMenuMod : MelonMod
{

    private bool _menuToggle = false;

    public override void OnLateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            var debugController = GameObject.Find("Debug Menu").GetComponent<DebugMenuController>();

            debugController.uiParent.SetActive(!_menuToggle);

            _menuToggle = !_menuToggle;
        }
    }

}
