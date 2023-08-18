using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTrainingAugust_229061.Pages.Modul5
{
    public class BoostrapCSSFixFieldCssClassprovider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
           var isinvalid= editContext.GetValidationMessages(fieldIdentifier).Any();
            return isinvalid ? "is-invalid" : "is-valid";
        }
    }
}
