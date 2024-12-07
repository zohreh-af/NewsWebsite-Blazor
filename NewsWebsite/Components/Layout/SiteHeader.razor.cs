using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace NewsWebSite.Components.Layout
{
    public partial class SiteHeader
    {
        private string username;
        [Inject]
        private AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var authenticationState = await AuthenticationStateProvider.GetAuthenticationStateAsync();

            var user = authenticationState.User;
            if (user.Identity.IsAuthenticated)
            {
                username = user.FindFirst(c => c.Type == "Username")?.Value;
            }
            else
            {
                username = "Guest";
            }

        }
    }
}
