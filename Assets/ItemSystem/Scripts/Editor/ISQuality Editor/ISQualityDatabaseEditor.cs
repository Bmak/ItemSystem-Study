using UnityEngine;
using System.Collections;
using UnityEditor;



namespace ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor : EditorWindow
    {
        private ISQualityDatabase qualityDatabase;
        private Texture2D selectedTexture;
        private int selectedIndex = 1;
        private Vector2 _scrollPos;                                             //scroll position for the ListView

        const int SPRITE_BUTTON_SIZE = 50;

        const string DATABASE_NAME = @"QualityDatabase.asset";
        const string DATABASE_PATH = @"Database";

        [MenuItem("ItemSystem/Database/Quality Editor %i")]
        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400, 300);
            window.titleContent = new GUIContent("Quality Database");
            window.Show();
        }

        void OnEnable()
        {
            qualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase>();
            qualityDatabase = qualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
        }

        void OnGUI()
        {
            if (qualityDatabase == null)
            {
                Debug.LogWarning("qualityDatabase not loaded");
                return;
            }

            ListView();

            GUILayout.BeginHorizontal("Box",GUILayout.ExpandWidth(true));
            BottomBar();
            GUILayout.EndHorizontal();
        }

        void BottomBar()
        {
            //count
            GUILayout.Label("Qualities: " + qualityDatabase.Count);
            //add button
            if (GUILayout.Button("Add"))
            {
                qualityDatabase.Add(new ISQuality());
            }
        }

    }

}

