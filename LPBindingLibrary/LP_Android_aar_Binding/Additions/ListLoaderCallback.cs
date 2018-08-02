using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents
{
    public partial class ChatMessageRecyclerView
    {
        public partial class ListLoaderCallback : Android.Support.V4.App.LoaderManager.ILoaderCallbacks
        {
            public IntPtr Handle => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            //public void OnLoaderReset(Android.Support.V4.Content.Loader loader)
            //{
            //    throw new NotImplementedException();
            //}

            public void OnLoadFinished(Android.Support.V4.Content.Loader loader, Java.Lang.Object data)
            {
                throw new NotImplementedException();
            }

            Android.Support.V4.Content.Loader Android.Support.V4.App.LoaderManager.ILoaderCallbacks.OnCreateLoader(int id, Bundle args)
            {
                throw new NotImplementedException();
            }
        }
    }
}