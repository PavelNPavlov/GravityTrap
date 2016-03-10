namespace GravityTrap.Mechanics
{
    using UnityEngine;

    using Core;

    public class BlueShape : InteractableObject
    {

        void Start()
        {
            this.SetColors();
            Debug.Log("Blue Shape Created");
        }

        void Update()
        {

        }

        public override void SetColors()
        {
            base.SetColors();

            this.Colors.Add(ForceColor.Blue);
        }
    }
}
