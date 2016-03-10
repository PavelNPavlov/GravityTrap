namespace GravityTrap.Mechanics.Atractors
{
    using UnityEngine;

    using Core;

    public class Atractor : InteractableObject
    {
        void Start()
        {
            this.SetColors();
        }

        void Update()
        {

        }

        public void ChangeColor(ForceColor color)
        {
            this.Colors[0] = color;
        }

        public override void SetColors()
        {
            base.SetColors();

            this.Colors.Add(ForceColor.Red);
        }
    }
}
