using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using SupportFragment = Android.Support.V4.App.Fragment;

namespace DesignLibrary_Tutorial.Fragments
{
    public class Fragment2 : SupportFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.Fragment2, container, false);

            Button btnLogin = view.FindViewById<Button>(Resource.Id.btnLogin);
            TextInputLayout passwordWrapper = view.FindViewById<TextInputLayout>(Resource.Id.txtInputLayoutPassword);
            string txtPassword = passwordWrapper.EditText.Text;

            btnLogin.Click += (o, e) =>
            {
                if (txtPassword != "1234")
                {
                    passwordWrapper.Error = "Wrong password, try again";
                }
            };

            return view;
        }
    }
}