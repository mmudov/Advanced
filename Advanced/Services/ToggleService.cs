using Advanced.Blazor;

//Components using JavaScript don't work
//using Microsoft.JSInterop;
//Components using JavaScript don't work

namespace Advanced.Services
{
    public class ToggleService
    {
        private List<MultiNavLink> components = new List<MultiNavLink>();
        private bool enabled = true;
        
        public void EnrolComponents(IEnumerable<MultiNavLink> comps)
        {
            components.AddRange(comps);
        }

        //Components using JavaScript don't work
        //[JSInvokable]
        //Components using JavaScript don't work

        public bool ToggleComponents()
        {
            enabled = !enabled;
            components.ForEach(c => c.SetEnabled(enabled));
            return enabled;
        }
    }
}
