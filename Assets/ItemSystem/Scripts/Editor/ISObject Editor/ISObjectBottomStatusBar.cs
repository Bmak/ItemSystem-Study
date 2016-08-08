using UnityEngine;
using System.Collections;

namespace ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        void BootomStatusBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));

            GUILayout.Label("Status Bar");

            GUILayout.EndHorizontal();
        }
    }
}
