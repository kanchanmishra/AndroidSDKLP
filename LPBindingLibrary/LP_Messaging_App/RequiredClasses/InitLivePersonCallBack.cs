using System;

using Android.Support.V7.App;


namespace Com.Liveperson.Infra.Callbacks
{
    public partial class InitLivePersonCallBack : AppCompatActivity, IInitLivePersonCallBack
    {
        public void OnInitFailed(Java.Lang.Exception p0)
        {
            throw new NotImplementedException();
        }

        public void OnInitSucceed()
        {
            throw new NotImplementedException();
        }
    }

}