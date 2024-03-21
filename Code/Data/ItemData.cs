using System;
using UnityEngine;

namespace _Project.Common.ItemSystem
{
    public abstract class ItemData : ScriptableObject
    {
        [SerializeField] private int _itemId = 0;
        [SerializeField] private string _itemName = "Item";
        [SerializeField] private string _itemDescription = "Description";
        [SerializeField] private bool _isStackable;
        [SerializeField] private Sprite _itemIcon = null;


        public int Id => _itemId;
        public string Name => _itemName;
        public string Description => _itemDescription;
        public bool Stackable => _isStackable;
        public Sprite Icon => _itemIcon;
    }
}