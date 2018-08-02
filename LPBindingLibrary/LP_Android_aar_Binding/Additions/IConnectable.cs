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

namespace Com.Liveperson.Infra.Messaging_ui.Fragment
{
    partial interface IConnectable
    {
        void Connect();
    }
}