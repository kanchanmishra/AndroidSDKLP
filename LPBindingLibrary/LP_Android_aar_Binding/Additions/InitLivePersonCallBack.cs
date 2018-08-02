using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Com.Liveperson.Infra.Callbacks
{
    public interface InitLivePersonCallBack
    {
        void onInitSucceed();

        void onInitFailed(Exception var1);
    }
}