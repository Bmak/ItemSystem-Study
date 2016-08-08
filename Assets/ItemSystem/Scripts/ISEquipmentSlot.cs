using UnityEngine;
using System.Collections;
using ItemSystem;
using System;


namespace ItemSystem
{
    public class ISEquipmentSlot : IISEquipmentSlot
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private Sprite _icon;

        public Sprite Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}


