namespace GravityTrap.Mechanics
{
    using UnityEngine;

    using Core;

    public class GreenShape : InteractableObject
    {

        void Start()
        {
            this.SetColors();
            Debug.Log("Green Shape Created");
        }

        void Update()
        {

        }

        public override void SetColors()
        {
            base.SetColors();

            this.Colors.Add(ForceColor.Green);
        }
    }
}
