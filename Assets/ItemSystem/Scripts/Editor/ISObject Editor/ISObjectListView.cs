using UnityEngine;
using System.Collections;
using UnityEditor;

namespace ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        private Vector2 _scrollPos = Vector2.zero;
        private int _listViewWidth = 200;
        void ListView()
        {
            _scrollPos = GUILayout.BeginScrollView(_scrollPos,"Box", GUILayout.ExpandHeight(true), GUILayout.Width(_listViewWidth));
            



            GUILayout.EndScrollView();
        }
    }
}
