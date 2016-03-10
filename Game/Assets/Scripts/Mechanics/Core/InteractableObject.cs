namespace GravityTrap.Mechanics.Core
{
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic;
    public abstract class InteractableObject : MonoBehaviour
    {
        public List<ForceColor> Colors;
        // Use this for initialization

        public virtual void SetColors()
        {
            this.InitColorList();
        }

        protected void InitColorList()
        {
            this.Colors = new List<ForceColor>();
        }
    }
}
