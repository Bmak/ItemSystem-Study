using UnityEngine;
using System.Collections;
using ItemSystem.Editor;
using UnityEditor;


namespace ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {
        [MenuItem("ItemSystem/Database/Item System Editor %w")]
        public static void Init()
        {
            ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
            window.minSize = new Vector2(800, 600);
            window.titleContent = new GUIContent("Item System");
            window.Show();
        }

        void OnEnable()
        {

        }

        void OnGUI()
        {
            TopTabBar();
            GUILayout.BeginHorizontal();
            ListView();
            ItemDetails();
            GUILayout.EndHorizontal();

            BootomStatusBar();
        }
    }
}


