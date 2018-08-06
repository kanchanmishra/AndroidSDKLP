using System;

using Android.Support.V7.App;
using Java.Lang;

namespace Com.Liveperson.Infra.Callbacks
{

    public interface InitLivePersonCallBack
    {
        void  OnInitSucceed();

        void OnInitFailed(Java.Lang.Exception var1);
    }

    //public class NewInitLivePersonCallBack : IInitLivePersonCallBack
    //{
    //    public IntPtr Handle => throw new NotImplementedException();

    //    public void Dispose()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void OnInitFailed(Java.Lang.Exception p0)
    //    {
    //        throw new NotImplementedException();
    //    }

       

    //    public void OnInitSucceed()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


}