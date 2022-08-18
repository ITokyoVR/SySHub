using System.ComponentModel;

namespace Siticone
{
    internal class UI
    {
        internal class WinForms
        {
            internal class SiticoneGradientCircleButton
            {
                public SiticoneGradientCircleButton()
                {
                }

                public object CheckedState { get; internal set; }
            }

            internal class SiticoneRoundedGradientButton
            {
                public SiticoneRoundedGradientButton()
                {
                }
            }

            internal class SiticoneDragControl
            {
                private IContainer components;

                public SiticoneDragControl(IContainer components)
                {
                    this.components = components;
                }
            }
        }
    }
}