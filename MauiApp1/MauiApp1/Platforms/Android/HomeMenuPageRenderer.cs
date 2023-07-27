using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Microsoft.Maui.Controls.Compatibility;
// using Java.Lang.Object;
// using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View = Android.Views.View;

// [assembly: ExportRenderer(typeof(MauiApp1.HomeMenu), typeof(MauiApp1.Platforms.Android.HomeMenuPageRenderer))]
namespace MauiApp1.Platforms.Android
{
    public class HomeMenuPageRenderer : PageHandler, View.IOnKeyListener
    {
        public IntPtr Handle => throw new NotImplementedException();

        public int JniIdentityHashCode => throw new NotImplementedException();

        public JniObjectReference PeerReference => throw new NotImplementedException();

        public JniPeerMembers JniPeerMembers => throw new NotImplementedException();

        public JniManagedPeerStates JniManagedPeerState => throw new NotImplementedException();

        public bool OnKey(View v, [GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            // Handler handler = new Handler();
            // IMauiHandlersCollection handlers = new MauiHandlersCollection();

            throw new NotImplementedException();
        }

        public void SetJniIdentityHashCode(int value)
        {
            throw new NotImplementedException();
        }

        public void SetPeerReference(JniObjectReference reference)
        {
            throw new NotImplementedException();
        }

        public void SetJniManagedPeerState(JniManagedPeerStates value)
        {
            throw new NotImplementedException();
        }

        public void UnregisterFromRuntime()
        {
            throw new NotImplementedException();
        }

        public void DisposeUnlessReferenced()
        {
            throw new NotImplementedException();
        }

        public void Disposed()
        {
            throw new NotImplementedException();
        }

        public void Finalized()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        // override DispatchKeyEvent
        //public override 
        //{
        //    // DispatchKeyEvent(KeyEvent ke)
        //    return false;
        //}
    }
}
